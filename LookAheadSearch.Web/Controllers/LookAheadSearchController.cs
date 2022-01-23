using LookAheadSearch.Web.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAheadSearch.Web.Controllers
{
    public class LookAheadSearchController : Controller
    {
        private readonly IProductService productService;

        public LookAheadSearchController(IProductService productService)
        {
            this.productService = productService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(string SearchTerm)
        {

            var result = await productService.SearchByName(SearchTerm);
            return Ok(result.Products);
        }
    }
}
