using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace scrittori_visore
{
    public class visualizzatore
    {
        
        bool  grassetto;
        bool corsivo;
        bool sottolineato;
        
        RichTextBox casella;
        Color colori;
        
       

        public visualizzatore(RichTextBox Casella )
        {
            setCassella(Casella);
            setColore(Color.Black);
            setCorsivo(false);
            setGrassetto(false);
            setSottolineato(false);
            
           

        }

        public void setGrassetto(bool Grassetto)
        {
            grassetto = Grassetto;
        }
        public void setCorsivo(bool Corsivo)
        {
            corsivo = Corsivo;
        }
        public void setSottolineato(bool Sottolineato)
        {
            sottolineato = Sottolineato;
        }
        public void setColore(Color Colore)
        {
            colori = Colore;
        }
        public void setCassella(RichTextBox Casella)
        {
           casella = Casella;
        }
        
        public void scrittura(string testo , string utente)
        {
            Font font;
            FontStyle f;
            //riferimento al testo selezionato
            font = casella.SelectionFont;
            if (font != null)
            {
                f = font.Style;
                //controllo stili selezionati
                if (grassetto==true)
                    f ^= FontStyle.Bold;
                if (corsivo==true)
                    f ^= FontStyle.Italic;
                if (sottolineato==true)
                    f ^= FontStyle.Underline;
                //setta lo stile del font
                casella.SelectionFont = new Font(font, f);
            }
            //setta il colore
            casella.SelectionColor = colori;
            //aggiunge il testo applicando stile e colore
            casella.AppendText(utente+": "+testo + "\n");
        }
        private void scelta_colore_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

