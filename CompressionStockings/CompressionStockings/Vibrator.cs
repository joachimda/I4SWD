namespace CompressionStockings
{
    public class Vibrator : INotificationDevice
    {
        public void On()
        {
            System.Console.WriteLine("Vibrator is on.");
            
        }

        public void Off()
        {
            System.Console.WriteLine("Vibrator is off.");
        }
    }
}