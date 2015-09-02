using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff
{
    public class DoHickey : IDoThings
    {
        void IDoThings.DoNothing()
        {
            System.Console.WriteLine("DoHickey::DoNothing: NULL");
        }

        int IDoThings.DoSomething(int number)
        {
            System.Console.WriteLine("DoHickey::DoSomething: {0}", number);
            return number;
        }

        string IDoThings.DoSomethingElse(string input)
        {
            System.Console.WriteLine("DoHickey::DoSomethingElse: {0}", input);
            return input;
        }
    }

}
