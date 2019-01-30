using System.Collections.Generic;
using System.Linq;
using EC.Web.Areas.Shared.Data.ViewModels;
using EC.Web.Areas.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace EC.Web.Controllers.B1
{
    [Route("api/[controller]")]
    [ApiController]
    public class B1CardsController : ControllerBase
    {
        private readonly IB1CardService _cardService;
        public B1CardsController(IB1CardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        [Route("GetCustomers")]
        public ActionResult<List<B1CustomerViewModel>> GetCustomers()
        {
            var data = new List<B1CustomerViewModel>();
            data = _cardService.GetCustomers();
            return data;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public ActionResult<B1CustomerViewModel> GetCustomer(string cardCode)
        {
            var data = _cardService.GetCustomers().FirstOrDefault(x => x.CardCode == cardCode);
            return data;
        }
    }
}