using Microsoft.AspNetCore.Mvc.Filters;

namespace RazorPageProject.Models.Filters
{
    public class MyPageFilter : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            // پیاده سازی کدهای موردنظر
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            
        }
    }
}
