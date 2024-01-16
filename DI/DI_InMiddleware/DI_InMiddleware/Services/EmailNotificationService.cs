using DI_InMiddleware.Interface;
using Microsoft.Extensions.Logging;

namespace DI_InMiddleware.Services
{
    public class EmailNotificationService : INotificationService
    {

        private readonly ILogger<EmailNotificationService> _logger;
        public EmailNotificationService(ILogger<EmailNotificationService> logger)
        {
            _logger = logger;
        }
        public void Send(string Message, long UserId)
        {
            //
            _logger.LogInformation($"Email {Message} sended for user :{UserId}");
        }
    }
}
