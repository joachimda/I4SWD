﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class WeakPlayer : IPlayer
    {
        private List<ICard> _hand = new List<ICard>();
        private string _name;

        public WeakPlayer(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = Name;
            }
        }

        public virtual void AddCard(ICard card)
        {
            _hand.Add(card);

            while (_hand.Count > 3)
            {
                _hand.RemoveAt(0);
            }
        }

        public void ShowHand()
        {
            System.Console.WriteLine("Player: {0} has these cards:", _name);

            foreach (ICard card in _hand)
            {
                System.Console.WriteLine("\tCardtype: {0}, Number: {1}", card.Multiplier, card.Number);
            }

            System.Console.WriteLine("With a total score of: {0}\n", Score);
        }

        public int Score
        {
            get
            {
                int score = 0;

                foreach (ICard card in _hand)
                {
                    score += (card.Multiplier * card.Number);
                }

                return score;
            }
        }
    }
}
