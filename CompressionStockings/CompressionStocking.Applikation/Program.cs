using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompressionStockings;

namespace CompressionStocking.Applikation
{
    class Program
    {
        static void Main(string[] args)
        {
            IPump myPump = new Pump();
            ICompressionCtrl myCompressionCtrl = new AirCompressionCtrl(myPump);

            INotificationDevice myGreenLed = new LedGreen();
            INotificationDevice myReDevice = new LedRed();
            INotificationDevice myVibrator = new Vibrator();
            INotification myNotification = new Notification(myGreenLed, myReDevice, myVibrator);

            IButtonHandler myStockingCtrl = new StockingCtrl(myCompressionCtrl, myNotification);
            ICompressionEventHandler myEventHandler = new StockingCtrl(myCompressionCtrl, myNotification);
            myCompressionCtrl.AddNotificationCenter(myEventHandler);

            ConsoleKeyInfo consoleKeyInfo;

            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character

                if (consoleKeyInfo.Key == ConsoleKey.A)
                {
                    myStockingCtrl.StartButtonPushed();
                }

                if (consoleKeyInfo.Key == ConsoleKey.Z)
                {
                    myStockingCtrl.StopButtonPushed();
                }

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
