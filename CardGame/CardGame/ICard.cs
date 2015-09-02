using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface ICard
    {
        int Number { get; set; }
        int Multiplier { get; set; }
        int Value { get; }
    }
}
