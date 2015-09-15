using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game : IGame
    {
        protected List<IPlayer> _playersInGame = new List<IPlayer>();
        protected int _cardTotal = 8 * 4;
        protected Deck _deck;

        public Game(Deck deckToBePlayedWith)
        {
            _deck = deckToBePlayedWith;
        }

        public void AddPlayer(IPlayer playerToBeAdded)
        {
            _playersInGame.Add(playerToBeAdded);
            System.Console.WriteLine("Added player: {0}.", playerToBeAdded.Name);
        }

        public void DealCards()
        {
            foreach (IPlayer player in _playersInGame)
            {
                _deck.DealCardsToPlayer(player, 5);
            }
        }

        public virtual void AnnounceWinner()
        {
            int highscore = 0;
            string currentWinner = "No winner";

            foreach (IPlayer player in _playersInGame)
            {
                if (player.Score > highscore)
                {
                    highscore = player.Score;
                    currentWinner = player.Name;
                }
            }

            System.Console.WriteLine("Winner: {0}, with {1} points.\n", currentWinner, highscore);
        }
    }
}
