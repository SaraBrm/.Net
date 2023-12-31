namespace Mock.Services
{
    public interface IMessage
    {
        void Sms(string message, int userId);
        void Email(string message, int userId);
        void Notif(string message, int userId);
    }

    public enum Messagetype
    {
        Sms,
        Email,
        Notif
    }
}
