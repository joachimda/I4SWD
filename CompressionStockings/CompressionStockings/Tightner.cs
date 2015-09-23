namespace CompressionStockings
{
    public class Tightner : ITightner
    {
        const int _numberOfClicks = 40;

        public void Tighten()
        {
            System.Console.WriteLine("Tightning...");
            for (int i = 0; i < _numberOfClicks; i++)
            {
                System.Console.Write("tik.. ");
                System.Threading.Thread.Sleep(100);
            }
        }

        public void Loosen()
        {
            System.Console.WriteLine("Loosening...");
            for (int i = 0; i < _numberOfClicks; i++)
            {
                System.Console.Write("tok.. ");
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}