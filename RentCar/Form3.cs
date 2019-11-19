using RentCar.ORM.Context;
using RentCar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();

        private void btn_kullanicigiris_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.KullaniciAd = txt_kullaniciad.Text;
            k.KullaniciSİfre = txt_kullanicisifre.Text;
            
            if (db.TBLKullanici.Any(x => x.KullaniciAd == k.KullaniciAd && x.KullaniciSİfre == k.KullaniciSİfre))
            {
                Form5 kf = new Form5();
                kf.Show();
                //Form2 aracform = new Form2();
                //aracform.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

            txt_kullaniciad.Text = default(string);
            txt_kullanicisifre.Text = default(string);
        }

        private void btn_musteriyenikayit_Click(object sender, EventArgs e)
        {
            Form1 musteriform = new Form1();
            musteriform.Show();
        }

        public static string veri;
        private void btn_musterigiris_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Tc = txt_musteritc.Text;
            m.Sifre = txt_musterisifre.Text;
            veri = txt_musteritc.Text;

            if (db.TBLMusteri.Any(x => x.Tc == m.Tc && x.Sifre == m.Sifre))
            {
                Form4 arackiralama = new Form4();
                arackiralama.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

            txt_musteritc.Text = default(string);
            txt_musterisifre.Text = default(string);
        }
    }
}
