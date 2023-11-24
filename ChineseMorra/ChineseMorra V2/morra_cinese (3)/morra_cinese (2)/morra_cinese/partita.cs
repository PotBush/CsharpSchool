using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morra_Cinese
{
    internal class Partita
    {
        public enum Casiround 
        {
            vittoriautente=1,
            vittoriabot=2,
            pareggio=0
        }
        private Giocatore _bot;
        private Giocatore _Player;

        public Partita()
        {
            _bot = new Giocatore();
            _Player = new Giocatore();
        }
        public Giocatore Bot
        {
            get { return _bot; }
        }
        public Giocatore Player
        {
            get { return _Player; }
        }
        public void Reset()
        {
            _bot.resetScelta();
            _Player.resetScelta();
            _bot.resetVittoria();
            _Player.resetVittoria();
        }
        public Casiround Round(int sceltautente)
        {
            _bot.SceltaRandom();
            _Player.Scelta=(Giocatore.Tipologiascelta)sceltautente;
            Casiround esito = ControllaChiHaVinto();
            if (esito==Casiround.vittoriabot)
            {
                _bot.aggiungiVittoria();
            }
            if (esito == Casiround.vittoriautente)
            {
                _Player.aggiungiVittoria();
            }

            return esito;
        }
        
        private Casiround ControllaChiHaVinto ()
        {
            if (_Player.Scelta==Giocatore.Tipologiascelta.Sasso&&_bot.Scelta==Giocatore.Tipologiascelta.Carta)
            {
                return Casiround.vittoriabot;
            }
            if (_Player.Scelta == Giocatore.Tipologiascelta.Forbice && _bot.Scelta == Giocatore.Tipologiascelta.Sasso)
            {
                return Casiround.vittoriabot;
            }
            if (_Player.Scelta == Giocatore.Tipologiascelta.Carta && _bot.Scelta == Giocatore.Tipologiascelta.Forbice)
            {
                return Casiround.vittoriabot;
            }
            if (_bot.Scelta == Giocatore.Tipologiascelta.Sasso && _Player.Scelta == Giocatore.Tipologiascelta.Carta)
            {
                return Casiround.vittoriautente;
            }
            if (_bot.Scelta == Giocatore.Tipologiascelta.Forbice && _Player.Scelta == Giocatore.Tipologiascelta.Sasso)
            {
                return Casiround.vittoriautente;
            }
            if (_bot.Scelta == Giocatore.Tipologiascelta.Carta && _Player.Scelta == Giocatore.Tipologiascelta.Forbice)
            {
                return Casiround.vittoriautente;
            }
            return Casiround.pareggio;

        }
    }
}
