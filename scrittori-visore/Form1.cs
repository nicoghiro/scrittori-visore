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
            v = new visualizzatore( richTextBox1);
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
            if (textBox1.Text != string.Empty)
            {
                if (comboBox1.Text == "luca")
                {

                    luca.setGrassetto(grassetto.Checked);
                }
                if (comboBox1.Text == "marco")
                {

                    marco.setGrassetto(grassetto.Checked);
                }
                if (comboBox1.Text == "matteo")
                {

                   matteo.setGrassetto(grassetto.Checked);
                }
            }

        }

        private void sottolineato_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (comboBox1.Text == "luca")
                {

                    luca.setSottolineato(sottolineato.Checked);
                }
                if (comboBox1.Text == "marco")
                {

                    marco.setSottolineato(sottolineato.Checked);
                }
                if (comboBox1.Text == "matteo")
                {

                    matteo.setSottolineato(sottolineato.Checked);
                }
            }

        }

        private void corsivo_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (comboBox1.Text == "luca")
                {

                    luca.setCorsivo(corsivo.Checked);
                }
                if (comboBox1.Text == "marco")
                {

                    marco.setCorsivo(corsivo.Checked);
                }
                if (comboBox1.Text == "matteo")
                {

                    matteo.setCorsivo(corsivo.Checked);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (comboBox1.Text == "luca")
                {
                    colorDialog1.ShowDialog();
                    luca.setColore(colorDialog1.Color);
                }
                if (comboBox1.Text == "marco")
                {
                    colorDialog1.ShowDialog();
                    marco.setColore(colorDialog1.Color); ;
                }
                if (comboBox1.Text == "matteo")
                {
                    colorDialog1.ShowDialog();
                    marco.setCorsivo(corsivo.Checked);
                }
            }
        }

    }

}
