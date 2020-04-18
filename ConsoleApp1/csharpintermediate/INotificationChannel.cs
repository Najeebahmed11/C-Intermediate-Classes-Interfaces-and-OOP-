namespace csharpintermediate
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}