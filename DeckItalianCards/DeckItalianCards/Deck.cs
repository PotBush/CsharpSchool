using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckItalianCards
{
    internal class Deck
    {
        private Card[] _cards;
        public Deck() 
        {
            _cards = GeneratesDeck();
        }

        private Card[] GeneratesDeck()
        {
            Card[] cards = new Card[40];
            for (int i = 0; i < (int)TypeSuit.Coppe;i++)
            {
                for (int j = 0; j < (int)TypeValue.king;j++)
                {
                    cards[i * 10 + j] = new Card((TypeSuit)i, j);
                }
            }
            return cards;
        }

        Random rnd = new Random();
        public Card DrawCard()
        {
            int carta = rnd.Next(0,39);
            return _cards[carta];
        }

        public override string ToString()
        {
            string result = "---- List of Cards ----";
            for(int i=0; i < _cards.Length; i++)
            {
                result += $"{i + 1}. suit {_cards[i].Suit} value {_cards[i].Value} \n";
            }
            return result;
        }

    }
}
