using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card : ICard
    {
        private int _number;
        private int _multiplier;

        public Card(int num = 0, int mul = 0)
        {
            _number = num;
            _multiplier = mul;
        }

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (Number > 0 && 8 > Number)
                {
                    _number = Number;
                }
                else
                {
                    _number = 1;
                }
            }
        }

        public int Multiplier
        {
            get
            {
                return _multiplier;
            }
            set
            {
                if (Multiplier > 0 && 4 > Multiplier)
                {
                    _multiplier = Multiplier;
                }
            }
        }

        public int Value
        {
            get
            {
                return (_multiplier * _number);
            }
        }
    }
}
