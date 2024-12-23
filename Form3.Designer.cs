namespace EczaneDBApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEczaneAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewEczaneler = new System.Windows.Forms.DataGridView();
            this.buttonEczaneEkle = new System.Windows.Forms.Button();
            this.buttonEczaneSil = new System.Windows.Forms.Button();
            this.buttonEczaneGuncelle = new System.Windows.Forms.Button();
            this.buttonEczaneAra = new System.Windows.Forms.Button();
            this.textBoxilKodu = new System.Windows.Forms.TextBox();
            this.textBoxilceKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEczaneler)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEczaneAdi
            // 
            this.textBoxEczaneAdi.Location = new System.Drawing.Point(148, 98);
            this.textBoxEczaneAdi.Name = "textBoxEczaneAdi";
            this.textBoxEczaneAdi.Size = new System.Drawing.Size(135, 22);
            this.textBoxEczaneAdi.TabIndex = 0;
            // 
            // dataGridViewEczaneler
            // 
            this.dataGridViewEczaneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEczaneler.Location = new System.Drawing.Point(8, 288);
            this.dataGridViewEczaneler.Name = "dataGridViewEczaneler";
            this.dataGridViewEczaneler.RowHeadersWidth = 51;
            this.dataGridViewEczaneler.RowTemplate.Height = 24;
            this.dataGridViewEczaneler.Size = new System.Drawing.Size(780, 150);
            this.dataGridViewEczaneler.TabIndex = 2;
            // 
            // buttonEczaneEkle
            // 
            this.buttonEczaneEkle.Location = new System.Drawing.Point(49, 154);
            this.buttonEczaneEkle.Name = "buttonEczaneEkle";
            this.buttonEczaneEkle.Size = new System.Drawing.Size(100, 37);
            this.buttonEczaneEkle.TabIndex = 3;
            this.buttonEczaneEkle.Text = "Ekle";
            this.buttonEczaneEkle.UseVisualStyleBackColor = true;
            this.buttonEczaneEkle.Click += new System.EventHandler(this.buttonEczaneEkle_Click);
            // 
            // buttonEczaneSil
            // 
            this.buttonEczaneSil.Location = new System.Drawing.Point(307, 154);
            this.buttonEczaneSil.Name = "buttonEczaneSil";
            this.buttonEczaneSil.Size = new System.Drawing.Size(96, 37);
            this.buttonEczaneSil.TabIndex = 4;
            this.buttonEczaneSil.Text = "Sil";
            this.buttonEczaneSil.UseVisualStyleBackColor = true;
            this.buttonEczaneSil.Click += new System.EventHandler(this.buttonEczaneSil_Click);
            // 
            // buttonEczaneGuncelle
            // 
            this.buttonEczaneGuncelle.Location = new System.Drawing.Point(172, 154);
            this.buttonEczaneGuncelle.Name = "buttonEczaneGuncelle";
            this.buttonEczaneGuncelle.Size = new System.Drawing.Size(111, 37);
            this.buttonEczaneGuncelle.TabIndex = 5;
            this.buttonEczaneGuncelle.Text = "Güncelle";
            this.buttonEczaneGuncelle.UseVisualStyleBackColor = true;
            this.buttonEczaneGuncelle.Click += new System.EventHandler(this.buttonEczaneGuncelle_Click);
            // 
            // buttonEczaneAra
            // 
            this.buttonEczaneAra.Location = new System.Drawing.Point(668, 228);
            this.buttonEczaneAra.Name = "buttonEczaneAra";
            this.buttonEczaneAra.Size = new System.Drawing.Size(75, 23);
            this.buttonEczaneAra.TabIndex = 6;
            this.buttonEczaneAra.Text = "Ara";
            this.buttonEczaneAra.UseVisualStyleBackColor = true;
            this.buttonEczaneAra.Click += new System.EventHandler(this.buttonEczaneAra_Click);
            // 
            // textBoxilKodu
            // 
            this.textBoxilKodu.Location = new System.Drawing.Point(405, 98);
            this.textBoxilKodu.Name = "textBoxilKodu";
            this.textBoxilKodu.Size = new System.Drawing.Size(50, 22);
            this.textBoxilKodu.TabIndex = 7;
            // 
            // textBoxilceKodu
            // 
            this.textBoxilceKodu.Location = new System.Drawing.Point(644, 98);
            this.textBoxilceKodu.Name = "textBoxilceKodu";
            this.textBoxilceKodu.Size = new System.Drawing.Size(48, 22);
            this.textBoxilceKodu.TabIndex = 8;
            this.textBoxilceKodu.TextChanged += new System.EventHandler(this.textBoxilceKodu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eczane İsmi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "İl Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "İlçe Kodu:";
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(668, 200);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(120, 22);
            this.textBoxAra.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Eczaneleri Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(283, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Eczane İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Eczaneleri İsmine Göre Ara:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxilceKodu);
            this.Controls.Add(this.textBoxilKodu);
            this.Controls.Add(this.buttonEczaneAra);
            this.Controls.Add(this.buttonEczaneGuncelle);
            this.Controls.Add(this.buttonEczaneSil);
            this.Controls.Add(this.buttonEczaneEkle);
            this.Controls.Add(this.dataGridViewEczaneler);
            this.Controls.Add(this.textBoxEczaneAdi);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEczaneler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEczaneAdi;
        private System.Windows.Forms.DataGridView dataGridViewEczaneler;
        private System.Windows.Forms.Button buttonEczaneEkle;
        private System.Windows.Forms.Button buttonEczaneSil;
        private System.Windows.Forms.Button buttonEczaneGuncelle;
        private System.Windows.Forms.Button buttonEczaneAra;
        private System.Windows.Forms.TextBox textBoxilKodu;
        private System.Windows.Forms.TextBox textBoxilceKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}