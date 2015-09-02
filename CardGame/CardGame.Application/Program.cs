using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ICard myCard = new Card();
                Deck myDeck = new Deck(myCard);
                IGame myGame = new Game(myDeck);

                IPlayer Dennis = new WeakPlayer("Dennis");
                IPlayer Joachim = new WeakPlayer("Joachim");
                IPlayer Bjørn = new Player("Bjørn");
                IPlayer Maria = new WeakPlayer("Maria");
                IPlayer Tobias = new WeakPlayer("Tobias");
                IPlayer Jacob = new WeakPlayer("Jacob");

                myGame.AddPlayer(Dennis);
                myGame.AddPlayer(Joachim);
                myGame.AddPlayer(Bjørn);
                myGame.AddPlayer(Maria);
                myGame.AddPlayer(Tobias);
                myGame.AddPlayer(Jacob);

                myGame.DealCards();

                myGame.AnnounceWinner();

                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
