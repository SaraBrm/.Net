using MVC.Models.Entities;
using System.Collections.Generic;

namespace MVC.Models.Repositories
{
    public class NewsRepository
    {
        private readonly List<News> _news;
        public NewsRepository()
        {
            _news = new List<News>();

            _news.Add(new News
            {
                Id = 1,
                Text = "this is a text of news.....",
                Title = "title of news...."
            });
        }

        public List<News> GetList()
        {
            return _news;
        }
    }
}
