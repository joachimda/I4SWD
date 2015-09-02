using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff
{
    public class DoDickey : IDoThings
    {
        void IDoThings.DoNothing()
        {
            System.Console.WriteLine("DoDickey::DoNothing: Still NULL");
            return;
        }

        int IDoThings.DoSomething(int number)
        {
            System.Console.WriteLine("DoDickey::DoSomething: {0}", number * 2);
            return number*2;
        }

        string IDoThings.DoSomethingElse(string input)
        {
            System.Console.WriteLine("DoDickey::DoSomethingElse: {0}", input + " a derp");
            return input + " a derp";
        }
    }
}
