using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morra_Cinese
{
    internal class Giocatore
    {
        public enum Tipologiascelta
        {
            Sceltanonfatta = -1, Sasso, Carta, Forbice
        }
        private Tipologiascelta _scelta;
        private int _vincite;
        public int Vincite
        {
            get { return _vincite; }
            private set { _vincite = value; }
        }
        public Tipologiascelta Scelta
        {
            get { return _scelta; }
            set
            {
                if ((int)value > 2 || (int)value < 0)
                {
                    throw new ArgumentException("non puoi avere questo valore");
                }
                _scelta = value;
            }
        }

        Random random = new Random();
        public void SceltaRandom()
        { 
            Scelta = (Tipologiascelta)random.Next(0, 3);
        }
        public void resetScelta()
        {
            _scelta = Tipologiascelta.Sceltanonfatta;
        }
        public void resetVittoria()
        {
            _vincite = 0;
        }
        public void aggiungiVittoria()
        {
            _vincite ++;
        }
        public Giocatore() 
        {
            resetScelta();
            resetVittoria();
        }
    }
}
