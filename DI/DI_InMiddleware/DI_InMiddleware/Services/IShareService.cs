namespace DI_InMiddleware.Services
{
    public interface IShareService
    {
        string Execute();
    }

    public class TelegramShare : IShareService
    {
        public string Execute()
        {
            return "در تلگرام به اشتراک گذاشته شد";
        }
    } 

    public class InstagramShare : IShareService
    {
        public string Execute()
        {
            return "در اینستا به اشتراک گذاشته شد.";
        }
    }
}
