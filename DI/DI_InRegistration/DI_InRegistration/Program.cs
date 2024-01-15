using DI_InRegistrationInterface;
using DI_InRegistrationService;
using System;

namespace DI_InRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ISendMessage sendMessage = new SendNotif();

            RegisterUserService register = new RegisterUserService(sendMessage);
            //register.message = sendMessage;

            register.Execute("sr@gmail.com", "sara");

            Console.ReadLine();
        }
    }
}
