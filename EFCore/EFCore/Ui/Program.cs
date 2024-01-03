using DLA;
using Entities.BackingFields;
using Entities.GeneratedValues;
using Entities.Inheritance;
using System;
using System.Linq;

namespace Ui
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context = new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //User user = new User()
            //{
            //    FirstName="sara",
            //    LastName="brm"
            //};
            //context.Users.Add(user);
            //context.SaveChanges();


            //Student student = new Student()
            //{
            //    EnrollmentDate = DateTime.Now,
            //    FirstName = "sara",
            //    LastName = "brm"
            //};
            //context.Students.Add(student);
            //Teacher teacher = new Teacher()
            //{
            //    LastName = "bahmani",
            //    EnrollmentDate = DateTime.Now,
            //    FirstName="roz",
            //    HireDate= DateTime.Now.AddYears(-6),
            //};

            //var student = context.Students.FirstOrDefault();
            //var studentList=context.Students.ToList();

            //var teacher = context.Teachers.FirstOrDefault();
            //var teacherList = context.Teachers.ToList();

            //Blog blog = new Blog();
            //blog.SetUrl("https://www.Google.com/");
            //context.Add(blog);
            //context.SaveChanges();


            Order order= new Order()
            {
                OrderStatus=OrderStatus.Delivered,
            };
            context.Orders.Add(order);
            context.SaveChanges();
 
            User user = new User()
            {
                Email= "sb@gmail.com",
                Home=new Address
                {
                    City= "test",
                    Street="test",
                    Alley= "test",
                    Plaque="2"
                },
                Workplace= new Address
                {
                    City = "test",
                    Street = "test",
                    Alley = "test",
                    Plaque = "3"
                }               
            };
            context.Users.Add(user);
            context.SaveChanges();
            var _user=context.Users.FirstOrDefault();

            Console.WriteLine("Hello World!");
        }
    }
}
