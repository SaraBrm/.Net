using DI_InRegistrationInterface;
using System;

namespace DI_InRegistrationService
{
    public class SendEmail : ISendMessage
    {
        public void Send(string Email, string Name)
        {
            //----
            //---
            Console.WriteLine($"Email be {Name} ba addrese {Email}  ersal shod.");
        }

    }
}
