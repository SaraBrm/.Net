using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Filters.Models.Filters
{
    public class AddHeaderFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("MyHeaderOnFillter", "this is a test add header");
        }
    }
}
 