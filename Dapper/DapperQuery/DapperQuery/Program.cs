using System;

namespace DapperQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();

            //OnetoMany(repository);

            //var orders = repository.GetInvoice();
            //repository.QuerMultiple();
            //repository.Queries();

            var orders = repository.RunSP();

            Console.ReadLine();
        }

        private static void OnetoMany(Repository repository)
        {
            var orders = repository.GetOrders();

            foreach (var item in orders)
            {
                Console.WriteLine($"Order :{item.Id}   On Date {item.Date}");
                foreach (var detail in item.OrderDetails)
                {
                    Console.WriteLine($"Id :{detail.Id}  {detail.ProductName}");
                }
            }
        }
    }
}
