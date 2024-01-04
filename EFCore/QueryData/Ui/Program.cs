using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context = new DataBaseContext();

            //EagerLoading();
            //ExplicitLoading(context);
            //ClientVsServer(context);
            //TrackingVsNoTracking(context); 
            //FromSqlRaw(context);

            //context.database.ensuredeleted();
            //context.database.ensurecreated();


            var usersEnummerable = context.Users.AsEnumerable();
            usersEnummerable = usersEnummerable.Where(p => p.Name.Contains("m"));
            var userList1 = usersEnummerable.ToList();

            var userQueryable = context.Users.AsQueryable();
            userQueryable = userQueryable.Where(p => p.Name.Contains("M"));
            var userlist2 = userQueryable.ToList();

            context.Users.Any(p => p.Name.Contains("m"));

            Console.WriteLine("Hello World!");
        }

        private static void FromSqlRaw(DataBaseContext context)
        {
            var post = context.Posts.FromSqlRaw("SELECT * FROM dbo.Posts").ToList();
        }

        private static void TrackingVsNoTracking(DataBaseContext context)
        {
            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var tags = context.Tags.ToList();

            var post = context.Posts.FirstOrDefault();
            
            post.Body = "E";
            
            context.SaveChanges();

            var tag1 = context.Tags.Where(p => p.Id == 1).FirstOrDefault();

            var tag2 = context.Tags.Find((long)2);
        }

        private static void ClientVsServer(DataBaseContext context)
        {
            var products = context.Products
                .AsEnumerable()
                .Where(p => CalculateTax(p.Price) > 1000)
                .Select(p => new
                {
                    Price = CalculateTax(p.Price),
                }).ToList();
            foreach (var item in products)
            {
                Console.WriteLine(item.Price);
            }
        }

        public static decimal CalculateTax(decimal price)
        {
            return (price *9) / 100;
        }

        private static void ExplicitLoading(DataBaseContext context)
        {
            //var post = context.Posts.Where(p => p.Id == 1).FirstOrDefault();
            //context.Entry(post)
            //    .Collection(p => p.Comments)
            //    .Load();

            //context.Entry(post)
            //    .Reference(p => p.Category)
            //    .Load();

            //var commentCount = context.Entry(post)
            //    .Collection(p => p.Comments)
            //    .Query()
            //    .Where(p => p.IsConfirm == true)
            //    .Count();
        }

        public static void EagerLoading()
        {
            //var postQuery = context.Posts.TagWith("get all post").ToQueryString();
            //Console.WriteLine(postQuery);

            //var posts = context.Posts
            //    .Include(p => p.Comments).ThenInclude(p => p.User)
            //    .Include(p => p.Category)
            //    .Include(p => p.Tags)
            //    .FirstOrDefault();
            //foreach (var item in posts.Comments)
            //{
            //    Console.WriteLine(item.User.Name);
            //}

            //var post = context.Posts.Include(p => p.Comments).ToList();
            //var postSplit = context.Posts
            //    .Include(p => p.Comments).AsSplitQuery().TagWith("AsSplitQuery").ToList();

            //var post1 = context.Posts.Include(p => p.Comments.Where(c => c.IsConfirm == true)).ToList();

        }

    }
}
