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
            /* Making objects assigning ctor's the stuff */
            Deck myDeck = new Deck();
            IGame myGame = new Game(myDeck);

            /* Filling deck with 1 of every card */
            for (int i = 1; i < 9; i++)             /* There are 8 different numbervalues */
            {
                for (int u = 1; u < 6; u++)         /* There are 5 different cardtypes */
                {
                    ICard myCard = new Card(i, u);  /* Making instans of every card */
                    myDeck.AddCard(myCard);         /* Adding card to deck */
                }
            }

            /* Making players, both weak and normal */
            IPlayer Dennis = new Player("Dennis");
            IPlayer Joachim = new WeakPlayer("Joachim");
            IPlayer Bjørn = new Player("Bjørn");
            //IPlayer Maria = new WeakPlayer("Maria");
            //IPlayer Tobias = new WeakPlayer("Tobias");
            //IPlayer Jacob = new Player("Jacob");

            /* Adding players to the game */
            myGame.AddPlayer(Dennis);
            myGame.AddPlayer(Joachim);
            myGame.AddPlayer(Bjørn);
            //myGame.AddPlayer(Maria);
            //myGame.AddPlayer(Tobias);
            //myGame.AddPlayer(Jacob);

            /* Making console output pretty */
            System.Console.WriteLine("");

            /* Giving each player some cards */
            myGame.DealCards();

            /* Outputting players hands to console */
            Dennis.ShowHand();
            Joachim.ShowHand();
            Bjørn.ShowHand();
            //Maria.ShowHand();
            //Tobias.ShowHand();
            //Jacob.ShowHand();

            /* Determining who wins and outputting result */
            myGame.AnnounceWinner();
        }
    }
}
