using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckItalianCards
{
    internal class Match
    {
        private Deck _deck;
        private Player _playerOne;
        private Player _playerTow;
        private TypeSuit _briscola;

        public Match(string namePlayerOne, string namePlayerTow)
        {
            _deck = new Deck();
            _playerOne = new Player(namePlayerOne);
            _playerTow = new Player(namePlayerTow);

            _playerOne.Hand = DealCards();
            _playerTow.Hand = DealCards();

            _deck.Shift();
            _briscola = _deck.DrawCard();
        }

        public Card[] DealCards()
        {
            Card tempHand = new Card;
            for(int i=0; i<tempHand.Length; i++)
            {
                tempHand[i] = _deck.DrawCard();
            }
            return tempHand;
        }
    }
}