using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EC.Web.Areas.Sales.Data;
using Microsoft.EntityFrameworkCore;
using EC.Web.Areas.Sales.Data.ViewModels;
using AutoMapper;

namespace EC.Web.Areas.Sales.Pages.SalesForecast
{
    public class SalesForecastIndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public SalesForecastIndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SalesForecastViewModel> SalesForecasts { get; set; }

        public async Task OnGetAsync()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EC.Web.Areas.Sales.Data.Entities.SalesForecast, SalesForecastViewModel>();
            });

            IMapper mapper = config.CreateMapper();

            SalesForecasts = await _context.SalesForecasts.Select(x => mapper.Map< EC.Web.Areas.Sales.Data.Entities.SalesForecast, SalesForecastViewModel>(x)).ToListAsync();

            foreach(var item in SalesForecasts)
            {
                if (item.UJanUPrice == null)
                    item.UJanUPrice = item.UPrice;
                if (item.UFebUPrice == null)
                    item.UFebUPrice = item.UPrice;
                if (item.UMarUPrice == null)
                    item.UMarUPrice = item.UPrice;
                if (item.UAprUPrice == null)
                    item.UAprUPrice = item.UPrice;
                if (item.UMayUPrice == null)
                    item.UMayUPrice = item.UPrice;
                if (item.UJunUPrice == null)
                    item.UJunUPrice = item.UPrice;
                if (item.UJulUPrice == null)
                    item.UJulUPrice = item.UPrice;
                if (item.UAugUPrice == null)
                    item.UAugUPrice = item.UPrice;
                if (item.USepUPrice == null)
                    item.USepUPrice = item.UPrice;
                if (item.UOctUPrice == null)
                    item.UOctUPrice = item.UPrice;
                if (item.UNovUPrice == null)
                    item.UNovUPrice = item.UPrice;
                if (item.UDecUPrice == null)
                    item.UDecUPrice = item.UPrice;
            }
        }
    }
}