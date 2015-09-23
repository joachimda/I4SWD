namespace CompressionStockings
{
    public interface ICompressionEventHandler
    {
        void NotifiCompressionComplete(int state);
        void NotifiCompressionStarted(int state);
    }
}