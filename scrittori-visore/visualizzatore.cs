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
        
        CheckBox grassetto;
        CheckBox corsivo;
        CheckBox sottolineato;
        ColorDialog colore;
        RichTextBox casella;
        
       

        public visualizzatore( CheckBox Grassetto, CheckBox Corsivo, CheckBox Sottolineato,ColorDialog Colore,RichTextBox Casella )
        {
            setCassella(Casella);
            setColore(Colore);
            setCorsivo(Corsivo);
            setGrassetto(Grassetto);
            setSottolineato(Sottolineato);
            
           

        }

        public void setGrassetto(CheckBox Grassetto)
        {
            grassetto = Grassetto;
        }
        public void setCorsivo(CheckBox Corsivo)
        {
            corsivo = Corsivo;
        }
        public void setSottolineato(CheckBox Sottolineato)
        {
            sottolineato = Sottolineato;
        }
        public void setColore(ColorDialog Colore)
        {
            colore = Colore;
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
                if (grassetto.Checked)
                    f ^= FontStyle.Bold;
                if (corsivo.Checked)
                    f ^= FontStyle.Italic;
                if (sottolineato.Checked)
                    f ^= FontStyle.Underline;
                //setta lo stile del font
                casella.SelectionFont = new Font(font, f);
            }
            //setta il colore
            casella.SelectionColor = colore.Color;
            //aggiunge il testo applicando stile e colore
            casella.AppendText(utente+": "+testo + "\n");
        }
        private void scelta_colore_Click(object sender, EventArgs e)
        {
            colore.ShowDialog();
        }
    }
    }

