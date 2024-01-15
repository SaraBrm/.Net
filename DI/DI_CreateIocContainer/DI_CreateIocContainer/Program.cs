using System;

namespace DI_CreateIocContainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Resolver resolver = new Resolver();
            resolver.Register<IPayment, Pasargad>();
            resolver.Register<Buy, Buy>();

            var buy = resolver.Resolve<Buy>();

            buy.Pay();
            Console.ReadLine();
        }
    }
}
