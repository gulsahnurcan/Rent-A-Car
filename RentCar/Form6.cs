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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            KullaniciListe();
        }
        ProjeContext db = new ProjeContext();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            
            k.Ad = txt_ad.Text;
            k.Soyad = txt_soyad.Text;
            k.KullaniciAd = txt_kullaniciad.Text;
            k.KullaniciSİfre = txt_sifre.Text;
            

            if (db.TBLKullanici.Any(x => x.KullaniciAd == k.KullaniciAd))
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı Kullanılmaktadır. Tekrar deneyin.");

                Temizle();
            }
            else
            {
                db.TBLKullanici.Add(k);
                db.SaveChanges();

                MessageBox.Show("Kayıt Oluşturuldu.");

                KullaniciListe();
                Temizle();
            }
        }
        public void Temizle()
        {
            txt_ad.Text = default(string);
            txt_soyad.Text = default(string);
            txt_kullaniciad.Text = default(string);
            txt_sifre.Text = default(string);
        }
        public void KullaniciListe()
        {
            listView1.Items.Clear();
            foreach (Kullanici item in db.TBLKullanici.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.KullaniciID.ToString();
                lvi.SubItems.Add(item.Ad.ToString());
                lvi.SubItems.Add(item.Soyad.ToString());
                lvi.SubItems.Add(item.KullaniciAd.ToString());
                lvi.SubItems.Add(item.KullaniciSİfre.ToString());

                lvi.Tag = item.KullaniciID;//listviewde tıklanan satırın ID sini almasını sağlıyoruz!!
                listView1.Items.Add(lvi);
            }
        }

        Kullanici updated;
        int id;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            updated = db.TBLKullanici.Find(id);
            txt_ad.Text = updated.Ad;
            txt_soyad.Text = updated.Soyad;
            txt_kullaniciad.Text = updated.KullaniciAd;
            txt_sifre.Text = updated.KullaniciSİfre;
        }
        
        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            updated = db.TBLKullanici.Find(id);
            updated.Ad = txt_ad.Text;
            updated.Soyad = txt_soyad.Text;
            updated.KullaniciAd = txt_kullaniciad.Text;
            updated.KullaniciSİfre = txt_sifre.Text;

            db.Entry(db.TBLKullanici.Find(updated.KullaniciID)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            MessageBox.Show("Kullanici Güncellendi.");

            Temizle();
            KullaniciListe();
        }

        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            Kullanici deleted = db.TBLKullanici.Find(id);
            db.TBLKullanici.Remove(deleted);
            db.SaveChanges();//her savechanges dediğimizde bütün veri tabanını kaydediyor
            MessageBox.Show("Kullanici Silindi.");

            Temizle();
            KullaniciListe();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }

}
