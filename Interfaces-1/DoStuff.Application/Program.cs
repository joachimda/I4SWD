using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            val = System.Console.ReadLine();

            if (val == "1")
            {
                IDoThings myStuff = new DoHickey();
                myStuff.DoNothing();
                myStuff.DoSomething(5);
                myStuff.DoSomethingElse("Hello");
                System.Console.WriteLine("");
            }
            else if (val == "2")
            {
                IDoThings myDuff = new DoDickey();
                myDuff.DoNothing();
                myDuff.DoSomething(5);
                myDuff.DoSomethingElse("Hello");
                System.Console.WriteLine("");
            }
            else
            {
                System.Console.WriteLine("Fuck off!");
                System.Console.WriteLine("");
            }
        }
    }
}
