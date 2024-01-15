using DI_InRegistrationInterface;
using System;

namespace DI_InRegistration
{
    public class RegisterUserService
    {
        ISendMessage message;
        public RegisterUserService(ISendMessage sendMessage)
        {
            message = sendMessage;
        }

        //public ISendMessage message;
        public void Execute(string email, string name)
        {

            //----------------
            //-----------
            Console.WriteLine("Sabtnam anjam shod......!");
            message.Send(email, name);
        }
    }
}
