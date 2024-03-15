using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureEsercizio2
{
    public interface ISTAT
    {
        private List<Comune> _dati;

        public List<Comune> Dati { get { return _dati; } }

        public void ImpostaDatiDalFile(string percorsoFile)
        {
            _dati = new List<Comune>();
        }

        public 
    }
}
