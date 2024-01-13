using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace RazorPage.Models.Filters
{
    public class MyPageFilter :Attribute, IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }
    }
}
