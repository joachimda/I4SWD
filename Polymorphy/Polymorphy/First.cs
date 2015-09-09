using System;

namespace Polymorphy
{
    public class First
    {
        public virtual void Print()
        {
            Console.WriteLine("Hello from first!");
        }
    }

    public class Second : First
    {
        public override void Print()
        {
            Console.WriteLine("Hello from second!");
        }
    }

    public class Thrid : Second
    {
        sealed public override void Print()
        {
            Console.WriteLine("Hello from thrid!");
        }
    }

    public class Fourth : Thrid
    {
        
    }
}