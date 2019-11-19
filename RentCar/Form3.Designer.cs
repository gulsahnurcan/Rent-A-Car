namespace RentCar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kullanicigiris = new System.Windows.Forms.Button();
            this.txt_kullanicisifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_musteriyenikayit = new System.Windows.Forms.Button();
            this.btn_musterigiris = new System.Windows.Forms.Button();
            this.txt_musterisifre = new System.Windows.Forms.TextBox();
            this.txt_musteritc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kullanicigiris);
            this.groupBox1.Controls.Add(this.txt_kullanicisifre);
            this.groupBox1.Controls.Add(this.txt_kullaniciad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Paneli";
            // 
            // btn_kullanicigiris
            // 
            this.btn_kullanicigiris.Location = new System.Drawing.Point(96, 89);
            this.btn_kullanicigiris.Name = "btn_kullanicigiris";
            this.btn_kullanicigiris.Size = new System.Drawing.Size(100, 23);
            this.btn_kullanicigiris.TabIndex = 4;
            this.btn_kullanicigiris.Text = "Giriş";
            this.btn_kullanicigiris.UseVisualStyleBackColor = true;
            this.btn_kullanicigiris.Click += new System.EventHandler(this.btn_kullanicigiris_Click);
            // 
            // txt_kullanicisifre
            // 
            this.txt_kullanicisifre.Location = new System.Drawing.Point(96, 62);
            this.txt_kullanicisifre.Name = "txt_kullanicisifre";
            this.txt_kullanicisifre.Size = new System.Drawing.Size(100, 20);
            this.txt_kullanicisifre.TabIndex = 3;
            // 
            // txt_kullaniciad
            // 
            this.txt_kullaniciad.Location = new System.Drawing.Point(96, 32);
            this.txt_kullaniciad.Name = "txt_kullaniciad";
            this.txt_kullaniciad.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_musteriyenikayit);
            this.groupBox2.Controls.Add(this.btn_musterigiris);
            this.groupBox2.Controls.Add(this.txt_musterisifre);
            this.groupBox2.Controls.Add(this.txt_musteritc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Paneli";
            // 
            // btn_musteriyenikayit
            // 
            this.btn_musteriyenikayit.Location = new System.Drawing.Point(95, 119);
            this.btn_musteriyenikayit.Name = "btn_musteriyenikayit";
            this.btn_musteriyenikayit.Size = new System.Drawing.Size(100, 23);
            this.btn_musteriyenikayit.TabIndex = 8;
            this.btn_musteriyenikayit.Text = "Yeni Kayıt";
            this.btn_musteriyenikayit.UseVisualStyleBackColor = true;
            this.btn_musteriyenikayit.Click += new System.EventHandler(this.btn_musteriyenikayit_Click);
            // 
            // btn_musterigiris
            // 
            this.btn_musterigiris.Location = new System.Drawing.Point(95, 89);
            this.btn_musterigiris.Name = "btn_musterigiris";
            this.btn_musterigiris.Size = new System.Drawing.Size(100, 23);
            this.btn_musterigiris.TabIndex = 5;
            this.btn_musterigiris.Text = "Giriş";
            this.btn_musterigiris.UseVisualStyleBackColor = true;
            this.btn_musterigiris.Click += new System.EventHandler(this.btn_musterigiris_Click);
            // 
            // txt_musterisifre
            // 
            this.txt_musterisifre.Location = new System.Drawing.Point(95, 62);
            this.txt_musterisifre.Name = "txt_musterisifre";
            this.txt_musterisifre.Size = new System.Drawing.Size(100, 20);
            this.txt_musterisifre.TabIndex = 7;
            // 
            // txt_musteritc
            // 
            this.txt_musteritc.Location = new System.Drawing.Point(95, 32);
            this.txt_musteritc.Name = "txt_musteritc";
            this.txt_musteritc.Size = new System.Drawing.Size(100, 20);
            this.txt_musteritc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri Tc";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 181);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kullanicigiris;
        private System.Windows.Forms.TextBox txt_kullanicisifre;
        private System.Windows.Forms.TextBox txt_kullaniciad;
        private System.Windows.Forms.Button btn_musteriyenikayit;
        private System.Windows.Forms.Button btn_musterigiris;
        private System.Windows.Forms.TextBox txt_musterisifre;
        private System.Windows.Forms.TextBox txt_musteritc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}