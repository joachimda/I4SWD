using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface IGame
    {
        void AddPlayer(IPlayer playerToBeAdded);
        void DealCards();
        void AnnounceWinner();
    }
}
