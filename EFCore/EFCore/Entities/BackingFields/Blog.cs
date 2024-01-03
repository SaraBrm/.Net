using System.Net.Http;

namespace Entities.BackingFields
{
    public class Blog
    {
        private string _Url;
        public int Id { get; set; }
        public string Url
        {
            get { return _Url; }
        }
        public void SetUrl(string url)
        {
            using (var client =new HttpClient())
            {
                var res=client.GetAsync(url).Result;
                res.EnsureSuccessStatusCode();
            }
            _Url=url;
        }
    }
}
