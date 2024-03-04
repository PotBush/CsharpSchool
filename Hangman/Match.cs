using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Match
    {
        private string _word;
        private List<char> _wordThrow;
        private static string _SourcePath = @"/Source/";
        private int _turn = 0;

        private Player _player;
        public string SourcePath
        { 
            get { return _SourcePath; } 
        }
        public String Word
        {
            get { return _word; }
        }

        public String WordThrow
        {
            get { return _wordThrow.ToString(); }
        }

        public Match(string[] words)
        {
            Random rnd = new Random();
            _word = words[rnd.Next(0,words.Length)];

            _word.ToLower();
            _wordThrow = new List<char>();
            for (int i = 0; i < Word.Length; i++)
            {
                if (_word[i] ==  'a' || _word[i] == 'e' || _word[i] == 'i' || _word[i] == 'o' || _word[i] == 'u')
                {
                    _wordThrow[i] = '+';
                }else
                {
                    _wordThrow[i] = '-';
                }
            }
        }

        public string Turn(char character)
        {
            _turn++;
            bool guessed = false;

            for(int i = 0; i < _word.Length;i++)
            {
                if (character == _word[i])
                {
                    _wordThrow[i] = character;
                    guessed = true;
                }
            }

            if (!guessed) 
            {
                
            }
            return _wordThrow.ToString();
        }

    }
}
