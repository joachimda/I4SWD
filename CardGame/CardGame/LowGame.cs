using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class LowGame : IGame
    {
        private List<IPlayer> _playersInGame = new List<IPlayer>();
        private int _cardTotal = 8 * 4;
        Deck _deck = null;

        public LowGame(Deck deckToBePlayedWith)
        {
            _deck = deckToBePlayedWith;
        }

        public int CardTotal
        {
            get
            {
                return _cardTotal;
            }
        }

        public void AddPlayer(IPlayer playerToBeAdded)
        {
            _playersInGame.Add(playerToBeAdded);
            System.Console.WriteLine("Added player: {0}.", playerToBeAdded.Name);
        }

        public void DealCards()
        {
            int PlayerCount = _playersInGame.Count;
            foreach (IPlayer player in _playersInGame)
            {
                _deck.DealCardsToPlayer(player, 5);
            }
        }

        public void AnnounceWinner()
        {
            int lowscore = 5*(5*8);
            string currentWinner = "No winner";

            foreach (IPlayer player in _playersInGame)
            {
                if (player.Score < lowscore)
                {
                    lowscore = player.Score;
                    currentWinner = player.Name;
                }
            }

            System.Console.WriteLine("Winner: {0}, with {1} points.\n", currentWinner, lowscore);
        }
    }
}
