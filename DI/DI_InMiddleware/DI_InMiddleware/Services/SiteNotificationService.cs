using DI_InMiddleware.Interface;
using Microsoft.Extensions.Logging;

namespace DI_InMiddleware.Services
{
    public class SiteNotificationService : INotificationService
    {

        private readonly ILogger<SmsNotificationService> _logger;
        public SiteNotificationService(ILogger<SmsNotificationService> logger)
        {
            _logger = logger;
        }
        public void Send(string Message, long UserId)
        {
            //
            _logger.LogInformation($"Site {Message} sended for user :{UserId}");
        }
    }
}
