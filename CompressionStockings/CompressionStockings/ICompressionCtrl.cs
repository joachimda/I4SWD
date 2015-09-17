namespace CompressionStockings
{
    public interface ICompressionCtrl
    {
        void Compress();
        void Decompress();
        void AddNotificationCenter(ICompressionEventHandler compressionEventHandler);
        bool IsPumped { get; set; }
    }
}