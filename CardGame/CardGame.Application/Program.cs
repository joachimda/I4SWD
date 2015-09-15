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
            var myDeck = new Deck();
            IGame myGame = new LowGame(myDeck);
            var myPlayers = new List<IPlayer>();

            /* Filling deck with 1 of every card */
            for (var i = 1; i < 9; i++)             /* There are 8 different numbervalues */
            {
                for (var u = 1; u < 6; u++)         /* There are 5 different cardtypes */
                {
                    ICard myCard = new Card(i, u);  /* Making instans of every card */
                    myDeck.AddCard(myCard);         /* Adding card to deck */
                }
            }

            /* Making players, both weak and normal */
            myPlayers.Add(new WeakPlayer("Dennis"));
            myPlayers.Add(new WeakPlayer("Joachim"));
            myPlayers.Add(new Player("Bjørn"));
            //myPlayers.Add(new Player("Maria"));
            //myPlayers.Add(new Player("Tobias"));
            //myPlayers.Add(new WeakPlayer("Jacob"));

            /* Adding players to the game */
            foreach (var myPlayer in myPlayers)
            {
                myGame.AddPlayer(myPlayer);
            }

            /* Making console output pretty */
            System.Console.WriteLine("");

            /* Giving each player some cards */
            myGame.DealCards();

            /* Outputting players hands to console */
            foreach (var myPlayer in myPlayers)
            {
                myPlayer.ShowHand();
            }

            /* Determining who wins and outputting result */
            myGame.AnnounceWinner();

        }
    }
}
