using System;
using System.Collections.Generic;
using System.Linq;
using EC.Web.Areas.RMA.Data;
using EC.Web.Areas.Shared.Services;
using EC.Web.Data;
using EC.Web.Services.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    public class RMARequestBaseModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IB1UserService _b1UserService;
        private readonly IB1ProductService _b1ProductService;
        private readonly IB1CardService _b1CardService;

        public List<SelectListItem> RMAStatuses { get; set; }
        public List<SelectListItem> RMACaseStatuses { get; set; }
        public List<SelectListItem> RMALocations { get; set; }
        public List<SelectListItem> WarrantyStatuses { get; set; }
        public List<SelectListItem> SalesPersons { get; set; }
        public List<SelectListItem> RMAPersons { get; set; }
        public List<SelectListItem> Technicians { get; set; }
        public List<SelectListItem> B1Customers { get; set; }
        public List<SelectListItem> B1Products { get; set; }
        public List<SelectListItem> RMACorrectiveActions { get; set; }
        public List<SelectListItem> RMAReports { get; set; }

        public RMARequestBaseModel(
            IUserService userService,
            IB1UserService b1UserService,
            IB1CardService b1CardService,
            IB1ProductService b1ProductService)
        {
            _userService = userService;
            _b1UserService = b1UserService;
            _b1ProductService = b1ProductService;
            _b1CardService = b1CardService;

            RMAStatuses = (from s in Enum.GetNames(typeof(RMAStatus)).ToList()
                           select new SelectListItem
                           {
                               Text = s,
                               Value = s
                           }).ToList();

            RMAReports = (from r in Enum.GetNames(typeof(RMAReport)).ToList()
                            select new SelectListItem
                            {
                                Text = r,
                                Value = r
                            }).ToList();

            RMACaseStatuses = (from s in Enum.GetNames(typeof(RMACaseStatus)).ToList()
                           select new SelectListItem
                           {
                               Text = s,
                               Value = s
                           }).ToList();

            RMALocations = (from l in Enum.GetNames(typeof(RMALocation)).ToList()
                            select new SelectListItem
                            {
                                Text = l,
                                Value = l
                            }).ToList();

            WarrantyStatuses = (from w in Enum.GetNames(typeof(WarrantyStatus)).ToList()
                            select new SelectListItem
                            {
                                Text = w,
                                Value = w
                            }).ToList();

            SalesPersons = (from u in _b1UserService.GetSalesPersons()
                            select new SelectListItem
                            {
                                Text = u.User_Code,
                                Value = u.User_Code
                            }).ToList();

            B1Customers = (from c in _b1CardService.GetCustomers()
                           select new SelectListItem
                           {
                               Text = c.CardName,
                               Value = c.CardCode
                           }).ToList();

            B1Products = (from p in _b1ProductService.Get()
                          select new SelectListItem
                          {
                              Text = p.ItemCode,
                              Value = p.ItemCode
                          }).ToList();

            //SalesPersons = (from u in _userService.GetUsers("department", "sales")
            //                select new SelectListItem
            //                {
            //                    Text = u.FullName,
            //                    Value = u.Id
            //                }).ToList();

            RMAPersons = (from u in _userService.GetUsers("department", "rma")
                          select new SelectListItem
                          {
                              Text = u.FullName,
                              Value = u.Id
                          }).ToList();

            Technicians = (from u in _userService.GetUsers("department", "engineering")
                          select new SelectListItem
                          {
                              Text = u.FullName,
                              Value = u.Id
                          }).ToList();

            RMACorrectiveActions = (from n in Enum.GetNames(typeof(RMACorrectiveAction)).ToList()
                             select new SelectListItem
                             {
                                 Text = n,
                                 Value = n
                             }).ToList();
        }
        
    }
}