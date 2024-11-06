using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageProject.Services;

namespace RazorPageProject.Pages.Admin.Product
{
    [Authorize]
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ProductDTO Product { get; set; }

        private readonly IProductService _productService;

        public CreateModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            var result = _productService.Add(Product);
        }
    }
}
