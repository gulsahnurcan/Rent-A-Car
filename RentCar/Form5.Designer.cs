namespace RentCar
{
    partial class Form5
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
            this.btn_arac = new System.Windows.Forms.Button();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_arac
            // 
            this.btn_arac.BackColor = System.Drawing.SystemColors.Control;
            this.btn_arac.Location = new System.Drawing.Point(21, 26);
            this.btn_arac.Name = "btn_arac";
            this.btn_arac.Size = new System.Drawing.Size(179, 23);
            this.btn_arac.TabIndex = 0;
            this.btn_arac.Text = "Araç Kaydet/Güncelle/Sil";
            this.btn_arac.UseVisualStyleBackColor = false;
            this.btn_arac.Click += new System.EventHandler(this.btn_arac_Click);
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.BackColor = System.Drawing.SystemColors.Control;
            this.btn_kullanici.Location = new System.Drawing.Point(21, 55);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(179, 23);
            this.btn_kullanici.TabIndex = 1;
            this.btn_kullanici.Text = "Kullanici Kaydet/Güncelle/Sil";
            this.btn_kullanici.UseVisualStyleBackColor = false;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // btn_musteri
            // 
            this.btn_musteri.BackColor = System.Drawing.SystemColors.Control;
            this.btn_musteri.Location = new System.Drawing.Point(21, 84);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(179, 23);
            this.btn_musteri.TabIndex = 2;
            this.btn_musteri.Text = "Müşteri Kaydet/Güncelle/Sil";
            this.btn_musteri.UseVisualStyleBackColor = false;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(222, 136);
            this.Controls.Add(this.btn_musteri);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.btn_arac);
            this.Name = "Form5";
            this.Text = "Kullanici Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_arac;
        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.Button btn_musteri;
    }
}