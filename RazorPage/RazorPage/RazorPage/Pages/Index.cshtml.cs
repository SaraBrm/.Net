using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPage.Models.Filters;

namespace RazorPage.Pages
{
    [MyPageFilter]
    //[AddHeader("myHeader", "test")]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Name { get; set; }
        public void OnGet(int id, string name)
        {
            Name = name;
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            base.OnPageHandlerExecuted(context);
        }
        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            base.OnPageHandlerSelected(context);
        }
        public void OnGetSendComment()
        {

        }
        public void OnPostSendComment(int id)
        {

        }
        public void OnPostSubscribe(int id)
        {

        }


        public void OnDelete()
        {

        }

        public void OnPut()
        {

        }
    }
}
