namespace CompressionStockings
{
    public interface INotification
    {
        void NotifyCompressing(int state);
        void StopNotifying(int state);
    }
}