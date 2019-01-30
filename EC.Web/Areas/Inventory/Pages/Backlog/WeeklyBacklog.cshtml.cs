using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Areas.Inventory.Data.B1;
using EC.Web.Areas.Inventory.Data.ViewModel;
using EC.Web.Helpers.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Inventory.Pages.Backlog
{
    public class WeeklyBacklogModel : PageModel
    {
        private readonly B1DbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public WeeklyBacklogModel(B1DbContext context,
            IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public List<WeeklyBacklog> Weeklybacklogs { get; set; }

        public void OnGet()
        {
            #region ToBeRemoved
            //var data = (from t0 in _context.Ordrs.Where(x => x.USalesManager == "D" && x.Canceled == "N" && x.TaxDate >= DateTime.Today)
            //            join t2 in _context.Ohems on t0.OwnerCode equals t2.EmpId into lojt2
            //            from l2 in lojt2.DefaultIfEmpty()
            //            join t1 in _context.Rdr1s.Where(x => x.BaseType == 15 && x.LineStatus == "0") on t0.DocEntry equals t1.DocEntry into lojt1
            //            from l1 in lojt1.DefaultIfEmpty()
            //            join t3 in _context.Oshps on t0.TrnspCode equals t3.TrnspCode into lojt3
            //            from l3 in lojt3.DefaultIfEmpty()
            //            join p0 in _context.Oslps on t0.SlpCode equals p0.SlpCode into lojp0
            //            from l0 in lojp0.DefaultIfEmpty()
            //            join u1 in _context.Ufd1s on t0.USalesManager equals u1.FldValue into loju1
            //            from lu1 in loju1.DefaultIfEmpty()
            //            //join t4 in _context.Dln1s.Where(x => x.TargetType == 13) on new { l1.DocEntry, l1.BaseLine } equals new { t4.TrgetEntry, t4.LineNum } into lojt4
            //            select new WeeklyBacklog
            //            {
            //                OrdDate = (DateTime)t0.TaxDate,
            //                SONumber = t0.DocNum,
            //                ShipDate = (DateTime)l1.ShipDate,
            //                Sales = lu1.Descr.Substring(0, 18),
            //                InsideSales = l2.FirstName,
            //                Rep = ParseRep(l0.SlpName.Substring(0,2)),
            //                RepComm = l0.Commission,
            //                Customer = t0.CardCode,
            //                CustPONumber = t0.NumAtCard.Substring(0, 22),
            //                Ln = l1.LineNum + 1,
            //                ModelNumber = l1.Dscription,
            //                OpenQty = l1.OpenQty,
            //                Price = l1.Price,
            //                OpenAmt = l1.OpenQty * l1.Price
            //            }).ToList();

            //            //join t4 in _context.Dln1s.Where(x => x.TargetType == 13) on new { t1.DocEntry, t1.BaseLine } equals new { t4.TrgetEntry, t4.LineNum } into lojt4
            #endregion ToBeRemoved
            var salesManager = "D";
            Weeklybacklogs = GetData(salesManager);
        }
        
        private List<WeeklyBacklog> GetData(string salesManager)
        {
            var sql = System.IO.File.ReadAllText(string.Format(@"{0}\Areas\Sales\Scripts\WeeklyBacklog.txt", _hostingEnvironment.ContentRootPath));
            //var sql = System.IO.File.ReadAllText(@"D:\Projects\PoC\EC2020-Examples\EC.Web\Areas\Inventory\Scripts\WeeklyBacklog.txt");
            sql = sql.Replace("{salesManager}", salesManager);
            var result = _context.Database.RawSqlQuery<WeeklyBacklog>(
                sql,
                x => new WeeklyBacklog
                {
                    OrdDate = (DateTime)x[0],
                    SONumber = (int)x[1],
                    ShipDate = (DateTime)x[2],
                    Sales = x[3] is DBNull ? "" : (string)x[3],
                    InsideSales = (string)x[4],
                    Rep =  x[5] is DBNull ? "" : (string)x[5],
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
    }
}