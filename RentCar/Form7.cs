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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            MusteriListe();
        }
        ProjeContext db = new ProjeContext();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Tc = txt_tc.Text;
            m.Ad = txt_ad.Text;
            m.Soyad = txt_soyad.Text;
            m.Telefon = txt_telefon.Text;
            m.EhliyetNo = txt_ehliyetno.Text;
            m.Adres = txt_adres.Text;
            m.Email = txt_email.Text;
            m.Sifre = txt_sifre.Text;
            m.AddDate = DateTime.Now;
            m.AktifMi = false;

            if (db.TBLMusteri.Any(x => x.Tc == m.Tc))
            {
                MessageBox.Show("Girdiğiniz Tc kimlik numarası sistemde bulunmaktadır. Tekrar deneyin.");

                Temizle();
            }
            else
            {
                db.TBLMusteri.Add(m);
                db.SaveChanges();

                MessageBox.Show("Kayıt Oluşturuldu.");

                MusteriListe();
                Temizle();
            }
        }

        public void Temizle()
        {
            txt_tc.Text = default(string);
            txt_ad.Text = default(string);
            txt_soyad.Text = default(string);
            txt_telefon.Text = default(string);
            txt_ehliyetno.Text = default(string);
            txt_adres.Text = default(string);
            txt_email.Text = default(string);
            txt_sifre.Text = default(string);
        }
        
        Musteri updated;
        int id;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].Tag);

            updated = db.TBLMusteri.Find(id);

            txt_tc.Text = updated.Tc;
            txt_ad.Text = updated.Ad;
            txt_soyad.Text = updated.Soyad;
            txt_telefon.Text = updated.Telefon;
            txt_ehliyetno.Text = updated.EhliyetNo;
            txt_adres.Text = updated.Adres;
            txt_email.Text = updated.Email;
            txt_sifre.Text = updated.Sifre;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            updated = db.TBLMusteri.Find(id);
            updated.Tc = txt_tc.Text;
            updated.Ad = txt_ad.Text;
            updated.Soyad = txt_soyad.Text;
            updated.Telefon= txt_telefon.Text;
            updated.EhliyetNo = txt_ehliyetno.Text;
            updated.Adres = txt_adres.Text;
            updated.Email = txt_email.Text;
            updated.Sifre = txt_sifre.Text;

            db.Entry(db.TBLMusteri.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi.");

            Temizle();
            MusteriListe();
        }

        public void MusteriListe()
        {
            listView1.Items.Clear();
            foreach (Musteri item in db.TBLMusteri.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Tc.ToString());
                lvi.SubItems.Add(item.Ad.ToString());
                lvi.SubItems.Add(item.Soyad.ToString());
                lvi.SubItems.Add(item.Telefon.ToString());
                lvi.SubItems.Add(item.EhliyetNo.ToString());
                lvi.SubItems.Add(item.Adres.ToString());
                lvi.SubItems.Add(item.Email.ToString());
                lvi.SubItems.Add(item.Sifre.ToString());

                lvi.Tag = item.ID;
                listView1.Items.Add(lvi);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Musteri deleted = db.TBLMusteri.Find(id);
            db.TBLMusteri.Remove(deleted);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi.");

            Temizle();
            MusteriListe();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
