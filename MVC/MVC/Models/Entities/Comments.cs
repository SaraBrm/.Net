namespace MVC.Models.Entities
{
    public class Comments
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public virtual News News { get; set; }
    }
}
