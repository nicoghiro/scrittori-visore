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
        string testo;
        CheckBox grassetto;
        CheckBox corsivo;
        CheckBox sottolineato;
        ColorDialog colore;
        RichTextBox casella;
        string utente;
       

        public visualizzatore(string Testo, CheckBox Grassetto, CheckBox Corsivo, CheckBox Sottolineato,ColorDialog Colore,RichTextBox Casella , string Utente)
        {
            setCassella(Casella);
            setColore(Colore);
            setCorsivo(Corsivo);
            setGrassetto(Grassetto);
            setSottolineato(Sottolineato);
            setUtente(Utente); 
           

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
        public void setUtente(string Utente)
        {
            utente = Utente;
        }
        public void scrittura()
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
            casella.AppendText(utente+testo + "\n");
        }
    }
    }

