using DI_InRegistrationInterface;
using System;

namespace DI_InRegistrationService
{
    public class SendNotif : ISendMessage
    {
        public void Send(string Email, string Name)
        {
            //----
            //---
            Console.WriteLine($"Notif be {Name} ba addrese {Email}  ersal shod.");
        }

    }
}
