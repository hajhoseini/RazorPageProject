using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageProject.Services;

namespace RazorPageProject.Pages.Admin.Product
{
    public class IndexModel : PageModel
    {
        public List<ProductDTO> Products { get; set; }

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
            Products = _productService.List();
        }
    }
}
