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
            //while (true)
            //{
            Deck myDeck = new Deck();
            IGame myGame = new LowGame(myDeck);

            for (int i = 1; i < 9; i++)
            {
                for (int u = 1; u < 6; u++)
                {
                    ICard myCard = new Card(i, u);
                    myDeck.AddCard(myCard);
                }
            }

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

            System.Console.WriteLine("");

            myGame.DealCards();

            Dennis.ShowHand();
            Joachim.ShowHand();
            Bjørn.ShowHand();
            Maria.ShowHand();
            Tobias.ShowHand();
            Jacob.ShowHand();

            myGame.AnnounceWinner();

            //System.Threading.Thread.Sleep(500);
            //}
        }
    }
}
