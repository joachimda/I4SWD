using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class WeakPlayer : Player
    {
        public WeakPlayer(string name): base(name)
        {
            Name = name;
        }

        public override void AddCard(ICard card)
        {
            _hand.Add(card);

            while (_hand.Count > 3)
            {
                _hand.RemoveAt(0);
            }
        }
    }
}
