using System.Collections.Generic;

namespace CompressionStockings
{
    public class Notification : INotification
    {
        List<INotificationDevice> _notificationDevicesList = new List<INotificationDevice>(); 

        public void NotifyCompressing()
        {
            foreach (INotificationDevice device in _notificationDevicesList)
            {
                device.On();
            }
        }

        public void StopNotifying()
        {
            foreach (INotificationDevice device in _notificationDevicesList)
            {
                device.Off();
            }
        }

        public void AddDevice(INotificationDevice notificationDevice)
        {
            _notificationDevicesList.Add(notificationDevice);
        }
    }
}