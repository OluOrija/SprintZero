using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SprintZero.Data.Services;

namespace SprintZero.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : Controller
    {
        private IShopService _shopService;
        public ShopController(IShopService shopService)
        {
            this._shopService = shopService;
        }

        [HttpGet("[action]")]
        public IActionResult GetProducts()
        {
            try
            {
                var allProducts = _shopService.GetAllProducts();
                return Ok(allProducts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
