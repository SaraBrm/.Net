using System.ComponentModel;

namespace MVCViewComponent.Models.ViewModels
{
    public class UserListViewModel
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("ایمیل")]
        public string Email { get; set; }
    }
}
