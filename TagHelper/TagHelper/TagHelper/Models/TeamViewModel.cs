using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TagHelper.Models
{
    public class TeamViewModel
    {
        public string Team { get; set; }
        public List<SelectListItem> TeamOptionGroup { get; set; }
        public List<SelectListItem> Teams { get; set; }
        public TeamEnum TeamEnum { get; set; }
        public IEnumerable<string> TeamMultiple { get; set; }
        public List<SelectListItem> TeamMultipleItem { get; set; }

    }


    public enum TeamEnum
    {
        [Display(Name = "پرسپولیس")]
        Perspolis,
        Sepahan,
        Esteghlal,

    }
}
