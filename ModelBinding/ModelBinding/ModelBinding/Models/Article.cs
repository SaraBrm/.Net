namespace ModelBinding.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Detail Detail { get; set; }
    }

    public class Detail
    {
        public string Picture { get; private set; }
    }
}
