namespace CompressionStockings
{
    public class LedRed : INotificationDevice
    {
        public void On()
        {
            System.Console.WriteLine("Red LED is on.");
        }

        public void Off()
        {
            System.Console.WriteLine("Red LED is off.");
        }
    }
}