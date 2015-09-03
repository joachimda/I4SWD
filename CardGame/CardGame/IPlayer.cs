using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface IPlayer
    {
        string Name { get; set; }
        void AddCard(ICard card);
        void ShowHand();
        int Score { get; }
    }
}
