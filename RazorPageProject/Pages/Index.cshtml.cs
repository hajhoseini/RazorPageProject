using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageProject.Models.Filters;

namespace RazorPageProject.Pages
{
    [AddHeader("MyHeader","test.net")]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }        
    }
}