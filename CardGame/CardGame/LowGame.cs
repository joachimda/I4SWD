using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class LowGame : Game
    {
        public override void AnnounceWinner()
        {
            int lowscore = 5 * (5 * 8);
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

        public LowGame(Deck deckToBePlayedWith) : base(deckToBePlayedWith)
        {
            _deck = deckToBePlayedWith;
        }
    }
}
