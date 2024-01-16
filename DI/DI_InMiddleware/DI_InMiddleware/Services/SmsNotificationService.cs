using DI_InMiddleware.Interface;
using Microsoft.Extensions.Logging;

namespace DI_InMiddleware.Services
{
    public class SmsNotificationService : INotificationService
    {

        private readonly ILogger<SmsNotificationService> _logger;
        public SmsNotificationService(ILogger<SmsNotificationService> logger)
        {
            _logger = logger;
        }
        public void Send(string Message, long UserId)
        {
            //
            _logger.LogInformation($"Sms {Message} sended for user :{UserId}");
        }
    }
}
