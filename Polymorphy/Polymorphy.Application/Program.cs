using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphy.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            First myFirst = new First();
            myFirst.Print();

            Second mySecond = new Second();
            mySecond.Print();

            Thrid myThrid = new Thrid();
            myThrid.Print();

            Fourth myFourth = new Fourth();
            myFourth.Print();
        }
    }
}
