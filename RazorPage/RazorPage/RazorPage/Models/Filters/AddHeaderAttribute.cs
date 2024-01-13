using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace RazorPage.Models.Filters
{
    public class AddHeaderAttribute : Attribute, IResultFilter
    {
        private readonly string _name;
        private readonly string _value;

        public AddHeaderAttribute(string name, string value)
        {
            _name = name;
            _value = value;
        }
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(_name, new string[] { _value });
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            //...
        }
    }
}
