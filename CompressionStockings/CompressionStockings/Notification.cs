using System.Collections.Generic;

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

        public void NotifyCompressing()
        {
            _greenLedDevice.On();
            _vibratorDevice.On();
        }

        public void StopNotifying()
        {
            _greenLedDevice.Off();
            _vibratorDevice.Off();
        }      
    }
}