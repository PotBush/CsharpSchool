using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public enum MatchStatus
    {
        livesEnded,
        wordGuessed,
        wordNotGuessed
    }
    public class Match
    {
        private string _word;
        private List<char> _wordGuess;
        private int _turn = 0;
        private Player _player;
        
        public String Word
        {
            get { return _word; }
        }

        public String WordGuess
        {
            get { return new String(_wordGuess.ToArray()); }
        }


        public Match(string[] words)
        {
            _player = new Player();
            _word = ExtractWord(words);
            _wordGuess = InitialiseWordGuess();

        }

        private string ExtractWord(string[] words)
        {
            Random rnd = new Random();
            string word = words[rnd.Next(0, words.Length)];

            return word.ToLower();
        }

        private List<char> InitialiseWordGuess()
        {
            List<char> wordGuess = new List<char>();
            for (int i = 0; i < _word.Length; i++)
            {
                if (_word[i] == 'a' || _word[i] == 'e' || _word[i] == 'i' || _word[i] == 'o' || _word[i] == 'u')
                {
                    wordGuess.Add('+');
                }
                else
                {
                    wordGuess.Add('-');
                }
            }
            return wordGuess;
        }

        private bool ThersCharacter(char ch)
        {
            bool guessed = false;

            for (int i = 0; i < _word.Length; i++)
            {
                if (ch == _word[i])
                {
                    _wordGuess[i] = ch;
                    guessed = true;
                }
            }
            return guessed;
        }

        public MatchStatus Turn(char character)
        {
            _turn++;
            bool guessed = ThersCharacter(character);

            if (guessed) 
            {
                return MatchStatus.wordGuessed;
            }else
            {
                if(_player.TakeLife())
                {
                    return MatchStatus.wordNotGuessed;
                }
                else
                {
                    return MatchStatus.livesEnded;
                }
            }
        }

    }
}
