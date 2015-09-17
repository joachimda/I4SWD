namespace CompressionStockings
{
    public interface ICompressionEventHandler
    {
        void NotifiCompressionComplete();
        void NotifiCompressionStarted();
    }
}