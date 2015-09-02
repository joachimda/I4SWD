using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game : IGame
    {
        private List<IPlayer> _playersInGame = new List<IPlayer>();
        private int _cardTotal = 8 * 4;
        Deck _deck = null;

        public Game(Deck deckToBePlayedWith)
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
            //int CardsPerPlayer = CardTotal / PlayerCount;

            foreach (IPlayer player in _playersInGame)
            {
                //_deck.DealCardsToPlayer(player, CardsPerPlayer);
                _deck.DealCardsToPlayer(player, 5);
            }
        }

        public void AnnounceWinner()
        {
            int highscore = 0;
            string currentWinner = "No winner";

            foreach (IPlayer player in _playersInGame)
            {
                if (player.ShowHand() > highscore)
                {
                    highscore = player.ShowHand();
                    currentWinner = player.Name;
                }
            }

            System.Console.WriteLine("Winner: {0}, with {1} points.\n", currentWinner, highscore);
        }
    }
}
