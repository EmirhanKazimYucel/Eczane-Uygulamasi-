namespace EczaneDBApp
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxEczaneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonHasta = new System.Windows.Forms.RadioButton();
            this.radioButtonEczaci = new System.Windows.Forms.RadioButton();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHastaGoster = new System.Windows.Forms.Button();
            this.buttonEczaciGoster = new System.Windows.Forms.Button();
            this.buttonEczaneNoAta = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(102, 94);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdi.TabIndex = 1;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(101, 135);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoyadi.TabIndex = 2;
            // 
            // textBoxEczaneNo
            // 
            this.textBoxEczaneNo.Location = new System.Drawing.Point(868, 88);
            this.textBoxEczaneNo.Name = "textBoxEczaneNo";
            this.textBoxEczaneNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxEczaneNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seçili Eczacıyı Eczaneye Ata:";
            // 
            // radioButtonHasta
            // 
            this.radioButtonHasta.AutoSize = true;
            this.radioButtonHasta.Location = new System.Drawing.Point(285, 95);
            this.radioButtonHasta.Name = "radioButtonHasta";
            this.radioButtonHasta.Size = new System.Drawing.Size(64, 20);
            this.radioButtonHasta.TabIndex = 7;
            this.radioButtonHasta.TabStop = true;
            this.radioButtonHasta.Text = "Hasta";
            this.radioButtonHasta.UseVisualStyleBackColor = true;
            // 
            // radioButtonEczaci
            // 
            this.radioButtonEczaci.AutoSize = true;
            this.radioButtonEczaci.Location = new System.Drawing.Point(285, 136);
            this.radioButtonEczaci.Name = "radioButtonEczaci";
            this.radioButtonEczaci.Size = new System.Drawing.Size(68, 20);
            this.radioButtonEczaci.TabIndex = 8;
            this.radioButtonEczaci.TabStop = true;
            this.radioButtonEczaci.Text = "Eczacı";
            this.radioButtonEczaci.UseVisualStyleBackColor = true;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(102, 195);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(100, 23);
            this.buttonEkle.TabIndex = 9;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tüm Kişileri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHastaGoster
            // 
            this.buttonHastaGoster.Location = new System.Drawing.Point(429, 262);
            this.buttonHastaGoster.Name = "buttonHastaGoster";
            this.buttonHastaGoster.Size = new System.Drawing.Size(166, 39);
            this.buttonHastaGoster.TabIndex = 11;
            this.buttonHastaGoster.Text = "Hastaları Göster";
            this.buttonHastaGoster.UseVisualStyleBackColor = true;
            this.buttonHastaGoster.Click += new System.EventHandler(this.buttonHastaGoster_Click);
            // 
            // buttonEczaciGoster
            // 
            this.buttonEczaciGoster.Location = new System.Drawing.Point(710, 262);
            this.buttonEczaciGoster.Name = "buttonEczaciGoster";
            this.buttonEczaciGoster.Size = new System.Drawing.Size(166, 39);
            this.buttonEczaciGoster.TabIndex = 12;
            this.buttonEczaciGoster.Text = "Eczacıları Göster";
            this.buttonEczaciGoster.UseVisualStyleBackColor = true;
            this.buttonEczaciGoster.Click += new System.EventHandler(this.buttonEczaciGoster_Click);
            // 
            // buttonEczaneNoAta
            // 
            this.buttonEczaneNoAta.Location = new System.Drawing.Point(868, 116);
            this.buttonEczaneNoAta.Name = "buttonEczaneNoAta";
            this.buttonEczaneNoAta.Size = new System.Drawing.Size(100, 23);
            this.buttonEczaneNoAta.TabIndex = 13;
            this.buttonEczaneNoAta.Text = "Ata";
            this.buttonEczaneNoAta.UseVisualStyleBackColor = true;
            this.buttonEczaneNoAta.Click += new System.EventHandler(this.buttonEczaneNoAta_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(226, 195);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(99, 23);
            this.buttonSil.TabIndex = 14;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(348, 195);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(99, 23);
            this.buttonGuncelle.TabIndex = 15;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(865, 192);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(100, 22);
            this.textBoxAra.TabIndex = 16;
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(865, 220);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(100, 23);
            this.buttonAra.TabIndex = 17;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seçili Kişiyi İsime Göre Ara:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(397, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kişi İşlemleri";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEczaneNoAta);
            this.Controls.Add(this.buttonEczaciGoster);
            this.Controls.Add(this.buttonHastaGoster);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.radioButtonEczaci);
            this.Controls.Add(this.radioButtonHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEczaneNo);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxEczaneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonHasta;
        private System.Windows.Forms.RadioButton radioButtonEczaci;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHastaGoster;
        private System.Windows.Forms.Button buttonEczaciGoster;
        private System.Windows.Forms.Button buttonEczaneNoAta;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}