using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private List<ICard> _deck = new List<ICard>();

        //public Deck(ICard card)
        //{
        //    for (int i = 1; i < 9; i++)
        //    {
        //        for (int u = 1; u < 5; u++)
        //        {
        //            //ICard myCard = new Card(i, u);
        //            //_deck.Add(myCard);
        //        }
        //    }
        //}

        public void AddCard(ICard Card)
        {
            _deck.Add(Card);
        }

        public void DealCardsToPlayer(IPlayer playerToBeGivenCard, int numberOfCards)
        {
            Random rnd = new Random();  // for making random numbers
            int randomNumber = 0;

            for (int i = 0; i < numberOfCards; i++)
            {
                if (_deck.Count > 0)
                {
                    randomNumber = rnd.Next(0, _deck.Count);   // random number between 0 and deck.count
                    playerToBeGivenCard.AddCard(_deck[randomNumber]);
                    _deck.Remove(_deck[randomNumber]);
                    
                    //playerToBeGivenCard.AddCard(_deck[0]);
                    //_deck.Remove(_deck[0]);
                }
                else
                {
                    System.Console.WriteLine("Deck is empty, you damn noob!");
                }
            }
        }

    }
}
