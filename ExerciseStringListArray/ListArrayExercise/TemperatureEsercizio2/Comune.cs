using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureEsercizio2
{
    public class Comune
    {
        private string _name;
        private List<Temperatura> _temperature;

        public string Name
        { 
            get { return _name; } 
        }

        public Comune(string name, List<Temperatura> temperature)
        {
            _name = name;
            _temperature = temperature;
        }

        public void AddTemperatura(Temperatura nuovaTemperatura)
        {
            _temperature.Add(nuovaTemperatura);
        }

        /// <summary>
        /// restituisce la temperatura massima del comune
        /// </summary>
        /// <returns></returns>
        public double? GetTemperaturaMax() 
        {
            if(_temperature.Count>0)
            {
                double temperaturaMax = _temperature[0].TemperaturaMediaCelsius;
                foreach(Temperatura t in _temperature)
                {
                    if(temperaturaMax<t.TemperaturaMediaCelsius)
                    {
                        temperaturaMax = t.TemperaturaMediaCelsius;
                    }
                }
                return temperaturaMax;
            }
            return null;
        }

        /// <summary>
        /// restituisce la temperatura media dato l'anno
        /// </summary>
        /// <param name="anno"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double? GetTemperaturaAnnoX(int anno) 
        {
            if (anno < 0 || anno < 3000) throw new ArgumentOutOfRangeException("anno non valido");
            foreach (Temperatura t in _temperature)
            {
                if (anno == t.Anno)
                {
                    return t.TemperaturaMediaCelsius;
                }
            }
            return null;
        }

        /// <summary>
        /// verifica se la temperatura anno di un anno estata regisrtata nel comune 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool VerificaTemperatura(Temperatura t)
        {
            bool presenza;
            foreach (Temperatura temperature in _temperature)
            {
                if (t.TemperaturaMediaCelsius == t.TemperaturaMediaCelsius)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
