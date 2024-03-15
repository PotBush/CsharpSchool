using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureEsercizio2
{
    public class Temperatura
    {
        private int _anno;
        private double _temperaturaMediaCelsius;

        public int Anno 
        { 
            get {  return _anno; }
            private set 
            {
                if (value > 0 && value < 3000) throw new ArgumentOutOfRangeException("anno non valido");
                _anno = value; 
            }
        }
        public double TemperaturaMediaCelsius
        { 
            get {  return _temperaturaMediaCelsius; }
            private set
            {
                if (value < -272.3 || value > 100) throw new ArgumentOutOfRangeException("temperatura media non valido");
            }
        }

        public Temperatura(int anno, double temperaturaMedia)
        {
            Anno = anno;
            TemperaturaMediaCelsius = temperaturaMedia;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Temperatura)) return false;
            Temperatura t = obj as Temperatura;
            if (t.Anno == Anno && t.TemperaturaMediaCelsius == TemperaturaMediaCelsius) return true;
            return false;
        }
    }
}
