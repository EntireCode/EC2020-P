using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Areas.Inventory.Data.B1;
using EC.Web.Areas.Sales.Data.ViewModels;
using EC.Web.Data;
using EC.Web.Helpers.Extensions;
using EC.Web.Helpers.Html;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EC.Web.Areas.Sales.Pages.Backlog
{
    public class WeeklyBacklogsModel : PageModel
    {
        private readonly B1DbContext _context;
        private readonly ApplicationDbContext _appDb;
        private readonly IHostingEnvironment _hostingEnvironment;

        public WeeklyBacklogsModel(B1DbContext context,
            ApplicationDbContext appDb,
            IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _appDb = appDb;
            _hostingEnvironment = hostingEnvironment;
            Weeklybacklogs = new List<WeeklyBacklogViewModel>();
        }

        [BindProperty]
        public string SalesManager { get; set; }

        public List<WeeklyBacklogViewModel> Weeklybacklogs { get; set; }

        [BindProperty]
        public List<Ufd1> SalesManagers { get; set; }

        public async Task OnGetAsync()
        {
            PopulateSalesManager();            
        }

        public async Task OnPostSearchAsync(string query)
        {
            Weeklybacklogs = GetData(SalesManager);
            PopulateSalesManager();
        }

        private void PopulateSalesManager()
        {
            var salesManagers = (from u in _context.Ufd1s.Where(x => x.TableId == "OCRD")
                                 select new SelectListItem
                                 {
                                     Value = u.FldValue,
                                     Text = u.Descr.Substring(0, 18)
                                 }).ToList();

            if (!User.IsInRole("admin"))
            {
                var user = _appDb.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                var userName = string.Format("{0} {1}", user.FirstName, user.LastName);
                salesManagers = salesManagers.Where(x => userName.Contains(x.Text)).ToList();
            }

            ViewData["SalesManagers"] = salesManagers;
        }

        private List<WeeklyBacklogViewModel> GetData(string salesManager)
        {
            var sql = System.IO.File.ReadAllText(string.Format(@"{0}\Areas\Sales\Scripts\WeeklyBacklog.txt", _hostingEnvironment.ContentRootPath));
            sql = sql.Replace("{salesManager}", salesManager);
            var result = _context.Database.RawSqlQuery<WeeklyBacklogViewModel>(
                sql,
                x => new WeeklyBacklogViewModel
                {
                    OrdDate = (DateTime)x[0],
                    SONumber = (int)x[1],
                    ShipDate = (DateTime)x[2],
                    Sales = x[3] is DBNull ? "" : (string)x[3],
                    InsideSales = (string)x[4],
                    Rep = x[5] is DBNull ? "" : (string)x[5],
                    RepComm = (decimal?)x[6],
                    Customer = x[7] == null ? "" : (string)x[7],
                    CustPONumber = x[8] is DBNull ? "" : (string)x[8],
                    Ln = (int)x[9],
                    ModelNumber = x[10] is DBNull ? "" : (string)x[10],
                    OpenAmt = (Int32)x[11],
                    Price = (decimal?)x[12],
                    OpenQty = (decimal?)x[13],
                    Notes = x[14] is DBNull ? "" : (string)x[14]
                });
            return result;
        }

        public string PrepareScript(string tableId, string fileName, int columns)
        {
            var scriptTemplateFile = string.Format(@"{0}\Helpers\Html\TableScript.txt", _hostingEnvironment.ContentRootPath);
            return TableHelper.PrepareScript(tableId, fileName, columns, scriptTemplateFile);
        }
    }
}