namespace CompressionStockings
{
    public class LedGreen : INotificationDevice
    {
        public void On()
        {
            System.Console.WriteLine("Green LED is on.");
        }

        public void Off()
        {
            System.Console.WriteLine("Green LED is off.");
        }
    }
}