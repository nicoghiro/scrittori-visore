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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(230, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 133);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // grassetto
            // 
            this.grassetto.AutoSize = true;
            this.grassetto.Location = new System.Drawing.Point(230, 267);
            this.grassetto.Name = "grassetto";
            this.grassetto.Size = new System.Drawing.Size(71, 17);
            this.grassetto.TabIndex = 1;
            this.grassetto.Text = "Grassetto";
            this.grassetto.UseVisualStyleBackColor = true;
            // 
            // sottolineato
            // 
            this.sottolineato.AutoSize = true;
            this.sottolineato.Location = new System.Drawing.Point(323, 267);
            this.sottolineato.Name = "sottolineato";
            this.sottolineato.Size = new System.Drawing.Size(82, 17);
            this.sottolineato.TabIndex = 2;
            this.sottolineato.Text = "Sottolineato";
            this.sottolineato.UseVisualStyleBackColor = true;
            // 
            // corsivo
            // 
            this.corsivo.AutoSize = true;
            this.corsivo.Location = new System.Drawing.Point(422, 267);
            this.corsivo.Name = "corsivo";
            this.corsivo.Size = new System.Drawing.Size(61, 17);
            this.corsivo.TabIndex = 3;
            this.corsivo.Text = "Corsivo";
            this.corsivo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Scelta_colore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Scrivi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.corsivo);
            this.Controls.Add(this.sottolineato);
            this.Controls.Add(this.grassetto);
            this.Controls.Add(this.richTextBox1);
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
    }
}

