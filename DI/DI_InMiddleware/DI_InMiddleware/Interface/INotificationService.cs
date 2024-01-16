namespace DI_InMiddleware.Interface
{
    public interface INotificationService
    {
        void Send(string Message, long UserId);
    }
}
