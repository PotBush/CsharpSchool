using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckItalianCards
{
    internal class Player
    {
        private string _name;
        private Card[] _hand;
        private int _score;

        public string Name
        {
            get{ return _name; }
        }
        public Card[] Hand
        {
            get{ return Hand; }
            set{
                if(value.Length != 3) throw new ArgumentOutOfRangeException("the value of the hand is invalid");
                _hand = value;
            }
        }
        public int Score
        { 
            get { return _score; }
            private set { 
                if( value < 1) throw new ArgumentOutOfRangeException("the score can't be negative");
                _score = value; }
        }
        public Player(string name)
        {
            _name = name;
            Hand = new Card[3];
            _score = 0;
        }
    }
}