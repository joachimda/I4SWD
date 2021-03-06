﻿using System.ComponentModel;

namespace CompressionStockings
{
    public class StockingCtrl : IButtonHandler, ICompressionEventHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;
        private readonly INotification _notification;

        public StockingCtrl(ICompressionCtrl compressionCtrl, INotification notification)
        {
            _compressionCtrl = compressionCtrl;
            _notification = notification;
        }

        public void StartButtonPushed()
        {
            System.Console.WriteLine("");
            _compressionCtrl.Compress();
            System.Console.WriteLine("");
        }

        public void StopButtonPushed()
        {
            System.Console.WriteLine("");
            _compressionCtrl.Decompress();
            System.Console.WriteLine("");
        }

        public void NotifiCompressionComplete(int state)
        {
            _notification.StopNotifying(state);
        }

        public void NotifiCompressionStarted(int state)
        {
            _notification.NotifyCompressing(state);
        }
    }
}