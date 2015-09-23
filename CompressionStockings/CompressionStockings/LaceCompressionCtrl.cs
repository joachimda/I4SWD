namespace CompressionStockings
{
    public class LaceCompressionCtrl : ICompressionCtrl
    {
        private ITightner _tightner;
        private ICompressionEventHandler _compressionEventHandler;

        public LaceCompressionCtrl(ITightner tightner)
        {
            _tightner = tightner;
            IsPumped = false;
        }

        public void Compress()
        {
            if (IsPumped)
            {
                System.Console.WriteLine("Already tight, jackass.");
                return;
            }

            _compressionEventHandler.NotifiCompressionStarted(1);
            _tightner.Tighten();
            _compressionEventHandler.NotifiCompressionComplete(1);

            IsPumped = true;
        }

        public void Decompress()
        {
            if (!IsPumped)
            {
                System.Console.WriteLine("Already loose, jackass.");
                return;
            }

            _compressionEventHandler.NotifiCompressionStarted(2);
            _tightner.Loosen();
            _compressionEventHandler.NotifiCompressionComplete(2);

            IsPumped = false;
        }

        public void AddNotificationCenter(ICompressionEventHandler compressionEventHandler)
        {
            _compressionEventHandler = compressionEventHandler;
        }

        public bool IsPumped { get; set; }
    }
}