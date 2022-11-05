using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrittori_visore
{
    public class scrittore
    {
        string testo;
        string utente;
        visualizzatore scrivi;
        public string getUtente()
        {
            return utente;
        }
        public scrittore(string Utente,visualizzatore Scrivi)
        {
           setUtente(Utente);
            setVisual(Scrivi);
        }
        private void setUtente(string Testo)
        {
            this.utente = Testo;
        }
        private void setVisual(visualizzatore Visual)
        {
            scrivi = Visual;
        }
        public void settesto(string T)
        {
            testo = T;
        }
        public void Scivi(string Testo)
        {
            if (Testo != null) { 
            scrivi.scrittura(Testo, getUtente());
            }
        }
       
    }
}
