using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrittori_visore
{
    public partial class Form1 : Form
    {
        visualizzatore v;
        scrittore luca;
        scrittore marco;
        scrittore matteo;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v = new visualizzatore(grassetto, corsivo, sottolineato, colorDialog1, richTextBox1);
            luca = new scrittore("luca", v);
            marco = new scrittore("marco", v);
            matteo = new scrittore("matteo", v);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (comboBox1.Text == "luca")
                {
                   
                    luca.Scivi(textBox1.Text);
                }
                if (comboBox1.Text == "marco")
                {
                    
                    marco.Scivi(textBox1.Text);
                }
                if (comboBox1.Text == "matteo")
                {
                    
                    matteo.Scivi(textBox1.Text);
                }
            }
        }

        private void grassetto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
