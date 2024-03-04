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
        public MainWindow()
        {
            InitializeComponent();
            _match = new Match(ReadToFile());
        }
           
        public string[] ReadToFile()
        {
            List<string> words = new List<string>();
            try
            {
                using(StreamReader sr= new StreamReader(_match.SourcePath + "parole.txt"))
                {
                    string word;
                    while ((word=sr.ReadLine())!=null)
                    {
                        words.Add(word);
                    }
                }
                return words.ToArray();
            }
            catch (Exception e)
            {
                lblError.Content = $"The file of Words could not be read:{e.Message}";
            }
        }
    }
}
