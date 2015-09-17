namespace CompressionStockings
{
    public interface INotification
    {
        void NotifyCompressing();
        void StopNotifying();
        void AddDevice(INotificationDevice notificationDevice);
    }
}