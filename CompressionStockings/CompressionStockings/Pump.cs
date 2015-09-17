namespace CompressionStockings
{
    public class Pump : IPump
    {
        public void Forward()
        {
            System.Console.WriteLine("Pump running forward.");
        }

        public void Reverse()
        {
            System.Console.WriteLine("Pump running in reverse.");
        }

        public void Stop()
        {
            System.Console.WriteLine("Pump stopping...");
        }
    }
}