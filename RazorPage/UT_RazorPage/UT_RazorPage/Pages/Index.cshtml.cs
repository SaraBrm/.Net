using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UT_RazorPage.Models;

namespace UT_RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        [BindProperty]
        public ViewModelSum viewModelSum { get; set; } = new ViewModelSum();
        public IActionResult OnGet()
        {

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Sum sum = new Sum();
            viewModelSum.Result = sum.Execute(viewModelSum.Value1, viewModelSum.Value2);
            return Page();
        }
    }
}
