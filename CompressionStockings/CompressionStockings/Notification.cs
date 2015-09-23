using System.Collections.Generic;
using System.Data;

namespace CompressionStockings
{
    public class Notification : INotification
    {
        private readonly INotificationDevice _greenLedDevice;
        private readonly INotificationDevice _redLedDevice;
        private readonly INotificationDevice _vibratorDevice;

        public Notification(INotificationDevice greenLedDevice, INotificationDevice redLedDevice, INotificationDevice vibratorDevice)
        {
            _greenLedDevice = greenLedDevice;
            _redLedDevice = redLedDevice;
            _vibratorDevice = vibratorDevice;
        }

        public void NotifyCompressing(int state)
        {
            switch (state)
            {
                case 1:
                    _greenLedDevice.On();
                    break;
                case 2:
                    _redLedDevice.On();
                    break;
                case 3:
                    System.Console.WriteLine("ERROR in: {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                    break;
            }

            _vibratorDevice.On();
        }

        public void StopNotifying(int state)
        {
            switch (state)
            {
                case 1:
                    _greenLedDevice.Off();
                    break;
                case 2:
                    _redLedDevice.Off();
                    break;
                case 3:
                    System.Console.WriteLine("ERROR in: {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                    break;
            }

            _vibratorDevice.Off();
        }
    }
}