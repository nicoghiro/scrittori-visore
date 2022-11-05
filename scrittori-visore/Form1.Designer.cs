namespace scrittori_visore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grassetto = new System.Windows.Forms.CheckBox();
            this.sottolineato = new System.Windows.Forms.CheckBox();
            this.corsivo = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(307, 114);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(476, 163);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // grassetto
            // 
            this.grassetto.AutoSize = true;
            this.grassetto.Location = new System.Drawing.Point(307, 329);
            this.grassetto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grassetto.Name = "grassetto";
            this.grassetto.Size = new System.Drawing.Size(87, 20);
            this.grassetto.TabIndex = 1;
            this.grassetto.Text = "Grassetto";
            this.grassetto.UseVisualStyleBackColor = true;
            this.grassetto.CheckedChanged += new System.EventHandler(this.grassetto_CheckedChanged);
            // 
            // sottolineato
            // 
            this.sottolineato.AutoSize = true;
            this.sottolineato.Location = new System.Drawing.Point(431, 329);
            this.sottolineato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sottolineato.Name = "sottolineato";
            this.sottolineato.Size = new System.Drawing.Size(100, 20);
            this.sottolineato.TabIndex = 2;
            this.sottolineato.Text = "Sottolineato";
            this.sottolineato.UseVisualStyleBackColor = true;
            // 
            // corsivo
            // 
            this.corsivo.AutoSize = true;
            this.corsivo.Location = new System.Drawing.Point(563, 329);
            this.corsivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.corsivo.Name = "corsivo";
            this.corsivo.Size = new System.Drawing.Size(75, 20);
            this.corsivo.TabIndex = 3;
            this.corsivo.Text = "Corsivo";
            this.corsivo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Scelta_colore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 382);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Scrivi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "marco",
            "matteo",
            "luca"});
            this.comboBox1.Location = new System.Drawing.Point(164, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.corsivo);
            this.Controls.Add(this.sottolineato);
            this.Controls.Add(this.grassetto);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox grassetto;
        private System.Windows.Forms.CheckBox sottolineato;
        private System.Windows.Forms.CheckBox corsivo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

