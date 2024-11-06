using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageProject.Areas.Admin.Pages.Category
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }

        public void OnGet(int id, string name)
        {
            Name = name;
        }
    }
}
