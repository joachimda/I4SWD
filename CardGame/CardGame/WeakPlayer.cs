using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class WeakPlayer : IPlayer
    {
        private List<ICard> _hand = new List<ICard>();
        private string _name;

        public WeakPlayer(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = Name;
            }
        }

        public virtual void AddCard(ICard card)
        {
            _hand.Add(card);

            while (_hand.Count > 3)
            {
                _hand.RemoveAt(0);
            }
        }

        public int ShowHand()
        {
            int score = 0;

            foreach (ICard card in _hand)
            {
                score += (card.Multiplier * card.Number);
            }

            return score;
        }
    }
}
