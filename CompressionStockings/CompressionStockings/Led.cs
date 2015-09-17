namespace CompressionStockings
{
    public class Led : INotificationDevice
    {
        public void On()
        {
            System.Console.WriteLine("LED is on.");
        }

        public void Off()
        {
            System.Console.WriteLine("LED is off.");
        }
    }
}