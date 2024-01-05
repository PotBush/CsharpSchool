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
        private int _countFirstCard;

        public int CountFirstCard
        { 
            get { return _countFirstCard; } 
            private set {
                if (value < 0 || value > 40) throw new ArgumentOutOfRangeException("the value of the Count is invalid");
                _countFirstCard = value; 
            } 
        }

        public Card DrawFirstCard
        {
            get
            {
                
                Card temp = _cards[CountFirstCard];
                _cards[CountFirstCard] = null;
                CountFirstCard++;
                return temp;

            }
        }

        public Card ViewFirstCard
        {
            get
            {
                return _cards[CountFirstCard];
            }
        }
        public Deck() 
        {
            _countFirstCard = 0;
            _cards = GeneratesDeck();
            shuffleCards();
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
        private void shuffleCards()
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                int randomPosition = rnd.Next(_cards.Length);
                Card tmp = _cards[randomPosition];
                _cards[randomPosition] = tmp;
                _cards[i] = tmp;
            }
        }

        public void Shift()
        {
            Card temp = _cards[0];
            for (int i = 0; i < _cards.Length - 1; i++)
            {
                _cards[i] = _cards[i + 1];
            }
            _cards[_cards.Length] = temp;
        }

        public override string ToString()
        {
            string output = "---- List of Cards ----";
            for(int i=0; i < _cards.Length; i++)
            {
                output += $"\n {i + 1}. suit {_cards[i].Suit} value {_cards[i].Value}";
            }
            return output;
        }

    }
}
