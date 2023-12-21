using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckItalianCards
{
    enum TypeSuit
    {
        Bastone,
        Denara,
        Spada,
        Coppe
        
    }

    enum TypeValue
    {
        jack = 8,
        horse,
        king,
    }
    internal class Card
    {
        private TypeSuit _suit;
        private TypeValue _value;

        public TypeSuit Suit
        {
            get { return _suit; }
        }
        public TypeValue Value 
        { 
            get { return _value; } 
        }
        public Card(TypeSuit suit, int value)
        {
            _suit = suit;
            _value = (TypeValue)value;
        }
    }
}
