using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Services;
using System.Collections.Generic;

namespace RazorPage.Pages.Admin.Products
{
    public class IndexModel : PageModel
    {
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();

        private readonly IProductService _productService;
        public IndexModel(IProductService service)
        {
            _productService = service;
        }

        public void OnGet()
        {
            Products = _productService.List();
        }
    }
}
