using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Areas.Inventory.Data.B1;
using EC.Web.Helpers.Html;
using EC.Web.Services.Alert;
using EC.Web.ViewModels.Base;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace EC.Web.Areas.Inventory.Pages.DailyInventory
{
    public class DailyInventoryModel : PageModel
    {
        private readonly B1DbContext _context;

        private IHostingEnvironment _hostingEnvironment;

        public List<DailyInventory> DailyInventories { get; set; }

        public DailyInventoryModel(B1DbContext context,
            IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            DailyInventories = new List<DailyInventory>();
        }

        public async Task OnGetAsync()
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                AlertViewModel alert = new AlertViewModel
                {
                    AlertType = AlertTypes.Danger.ToString().ToLower(),
                    AlertTitle = "Failed to access report!",
                    AlertBody = string.Format("We currently have technical difficulty in accessing report, please contact with admin for help. {0}", ex.Message)
                };
                TempData.Put<AlertViewModel>("alert", alert);

                //TempData["alert"] = alert;
                //TempData["_alert.type"] = "danger";
                //TempData["_alert.title"] = "Failed to access report!";
                //TempData["_alert.body"] = string.Format("We currently have technical difficulty in accessing report, please contact with admin for help. {0}", ex.Message);
            }
        }

        //public void OnGet()
        //{
        //    try
        //    {
        //        GetData();
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["_alert.type"] = "danger";
        //        TempData["_alert.title"] = "Failed to access report!";
        //        TempData["_alert.body"] = string.Format("We currently have technical difficulty in accessing report, please contact with admin for help. {0}", ex.Message);
        //    }

        //}

        public async Task<IActionResult> OnPostExport()
        {
            string webRootFolder = _hostingEnvironment.WebRootPath;
            string outputFolder = "output";
            string fileName = string.Format("{0}-{1}.xlsx", DateTimeToString(DateTime.Now), Request.HttpContext.Session.Id);
            string url = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, fileName);
            FileInfo file = new FileInfo(Path.Combine(webRootFolder, outputFolder, fileName));
            var memory = new MemoryStream();
            using (var fs = new FileStream(Path.Combine(webRootFolder, outputFolder, fileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Data");
                // create header
                IRow row = excelSheet.CreateRow(0);
                row.CreateCell(0).SetCellValue("Item Name");
                row.CreateCell(1).SetCellValue("Item Code");
                row.CreateCell(2).SetCellValue("Whscode");
                row.CreateCell(3).SetCellValue("On Hand");
                row.CreateCell(4).SetCellValue("Committed");
                row.CreateCell(5).SetCellValue("On Order");
                row.CreateCell(6).SetCellValue("Available");
                row.CreateCell(7).SetCellValue("Whs01");
                row.CreateCell(8).SetCellValue("Whs01a");
                row.CreateCell(9).SetCellValue("Whs99");
                row.CreateCell(10).SetCellValue("Whs99a");
                // create rows
                int rowCounter = 1;
                var dataFormat = workbook.CreateDataFormat();

                foreach (var data in GetData())
                {
                    row = excelSheet.CreateRow(rowCounter++);
                    row.CreateCell(0).SetCellValue(data.ItemName);
                    row.CreateCell(1).SetCellValue(data.ItemCode);
                    row.CreateCell(2).SetCellValue(data.Whscode);
                    row.CreateCell(3).SetCellValue(string.Format("{0:0,0}", data.OnHand));
                    row.CreateCell(4).SetCellValue(string.Format("{0:0,0}", data.Committed));
                    row.CreateCell(5).SetCellValue(string.Format("{0:0,0}", data.OnOrder));
                    row.CreateCell(6).SetCellValue(string.Format("{0:0,0}", data.Available));
                    row.CreateCell(7).SetCellValue(string.Format("{0:0,0}", data.Whs01));
                    row.CreateCell(8).SetCellValue(string.Format("{0:0,0}", data.Whs01a));
                    row.CreateCell(9).SetCellValue(string.Format("{0:0,0}", data.Whs99));
                    row.CreateCell(10).SetCellValue(string.Format("{0:0,0}", data.Whs99a));
                }

                workbook.Write(fs);
            }

            using (var stream = new FileStream(Path.Combine(webRootFolder, outputFolder, fileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        public class DailyInventory
        {
            public string ItemName { get; set; }

            public string ItemCode { get; set; }

            public string Whscode { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? OnHand { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? Committed { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? OnOrder { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? Available { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? Whs01 { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? Whs01a { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? Whs99 { get; set; }

            [DisplayFormat(DataFormatString = "{0:N0}")]
            public decimal? Whs99a { get; set; }
        }

        private List<DailyInventory> GetData()
        {
            string[] warehouses = { "01", "01-A", "99", "99-A" };

            var data1 = (from m1 in _context.Oitws
                         join m0 in _context.Oitms on m1.ItemCode equals m0.ItemCode
                         join b1 in _context.Oitbs on m0.ItmsGrpCod equals b1.ItmsGrpCod into b1s
                         from x in b1s.DefaultIfEmpty()
                         where (m0.ItmsGrpCod != 109 || (m1.OnHand != 0 && m0.ItmsGrpCod == 109))
                         && m0.QryGroup6 == "Y"
                         && (m0.QryGroup1 == "Y" || m0.QryGroup10 == "Y")
                         && m0.QryGroup3 != "Y"
                         && m0.QryGroup20 != "Y"
                         && m0.SellItem == "Y"
                         && m1.OnHand != 0
                         && warehouses.Contains(m1.WhsCode)
                         && m0.FrozenFor != "Y"
                         select new DailyInventory
                         {
                             ItemName = m0.ItemName,
                             ItemCode = m1.ItemCode,
                             Whscode = m1.WhsCode,
                             OnHand = m1.OnHand == null ? 0 : m1.OnHand,
                             OnOrder = m1.OnOrder == null ? 0 : m1.OnOrder,
                             Committed = m1.IsCommited == null ? 0 : m1.IsCommited,
                             Available = (m1.OnHand == null ? 0 : m1.OnHand) -
                                m1.IsCommited == null ? 0 : m1.IsCommited +
                                m1.OnOrder == null ? 0 : m1.OnOrder,
                             Whs01 = m1.WhsCode == "01" ? m1.OnHand : 0,
                             Whs01a = m1.WhsCode == "01-A" ? m1.OnHand : 0,
                             Whs99 = m1.WhsCode == "99" ? m1.OnHand : 0,
                             Whs99a = m1.WhsCode == "99-A" ? m1.OnHand : 0
                         });

            var data2 = (from d in data1
                         group d by d.ItemName into g
                         select new DailyInventory
                         {
                             ItemName = g.Key,
                             OnHand = g.Sum(x => x.OnHand),
                             Committed = g.Sum(x => x.Committed),
                             OnOrder = g.Sum(x => x.OnOrder),
                             Available = g.Sum(x => x.Available),
                             Whs01 = g.Sum(x => x.Whs01),
                             Whs01a = g.Sum(x => x.Whs01a),
                             Whs99 = g.Sum(x => x.Whs99),
                             Whs99a = g.Sum(x => x.Whs99a),
                         });

            DailyInventories = data2.ToList();

            return DailyInventories;
        }

        private string DateTimeToString(DateTime dateTime)
        {
            return string.Format("{0}{1}{2}{3}{4}{5}",
                dateTime.Year.ToString(),
                dateTime.Month.ToString("D2"),
                dateTime.Day.ToString("D2"),
                dateTime.Hour.ToString("D2"),
                dateTime.Minute.ToString("D2"),
                dateTime.Second.ToString("D2"));
        }

        public string PrepareScript(string tableId, string fileName, int columns)
        {
            var scriptTemplateFile = string.Format(@"{0}\Helpers\Html\TableScript.txt", _hostingEnvironment.ContentRootPath);
            return TableHelper.PrepareScript(tableId, fileName, columns, scriptTemplateFile);
        }
    }
}