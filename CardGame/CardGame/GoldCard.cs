using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class GoldCard : ICard
    {
        private int _number;
        private int _multiplier;

        public GoldCard(int num = 0, int mul = 4)
        {
            _number = num;
            _multiplier = 4;
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
                _multiplier = 4;
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
