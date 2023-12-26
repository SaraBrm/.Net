using System.ComponentModel;

namespace MVCViewComponent.Models.ViewModels
{
    public class UserDetailViewModel
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("ایمیل")]
        public string Email { get; set; }
        [DisplayName("نام")]
        public string Name { get; set; }
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
        [DisplayName("شماره همراه")]
        public string PhoneNumber { get; set; }
        [DisplayName("آدرس")]
        public string Address { get; set; }
        [DisplayName("شغل")]
        public string Job { get; set; }
    }
}
