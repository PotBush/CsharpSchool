﻿using System;
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
            private set { 
                if((int)value<0 || (int)value > 3) throw new ArgumentException("seme non accettabile");
                _suit = value; 
            }
        }
        public TypeValue Value 
        { 
            get { return _value; }
            private set {
                if (value < (TypeValue)1 || value > (TypeValue)10) throw new ArgumentOutOfRangeException("valore non accettabile");
                _value = value; 
            }
        }
        public Card(TypeSuit suit, int value)
        {
            _suit = suit;
            _value = (TypeValue)value;
        }

        public bool IsFigure()
        {
            if(Value > (TypeValue)7) return true;
            else return false;
        }
        public override string ToString()
        {
            return $"{Value} {Suit}\n";
        }
    }
}
