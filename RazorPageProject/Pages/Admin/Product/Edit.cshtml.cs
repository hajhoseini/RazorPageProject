using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageProject.Services;

namespace RazorPageProject.Pages.Admin.Product
{
    public class EditModel : PageModel
    {
        private readonly IProductService _productService;

        [BindProperty]
        public ProductDTO Product { get; set; }

        public EditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
                return NotFound();

            Product = _productService.Find(id.Value);
            return Page();
        }

        public IActionResult OnPost()
        {
            _productService.Edit(Product);
            return Page();
        }
    }
}
