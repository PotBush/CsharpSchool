using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Match _match;
        private char _ch;
        public MainWindow()
        {
            InitializeComponent();
            _match = new Match(ReadToFile());
            lblWordGuess.Content = _match.WordGuess;
        }
        
        
        public string[] ReadToFile()
        {
            List<string> words = new List<string>();

            try
            {
                using(StreamReader sr= new StreamReader(@"../../../Source/words.txt"))
                {
                    string word;
                    while ((word=sr.ReadLine())!=null)
                    {
                        words.Add(word);
                    }
                }
                return words.ToArray();
            }
            catch (Exception ex)
            {
                lblError.Content = $"The file of Words could not be read:{ex.Message}";
                throw ex;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(_match.Turn(_ch) == MatchStatus.wordGuessed)
            {
                
            }
            
            

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblError.Visibility = Visibility.Collapsed;
            try
            {
                _ch = Convert.ToChar(txbChar.Text);
            }
            catch (Exception ex)
            {
                txbChar.Text = "";
                lblError.Visibility= Visibility.Visible;
                lblError.Content = $"insert a character";
            }
        }
    }
}
