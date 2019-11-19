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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            if(db.TBLMusteri.Any(x=> x.Tc == m.Tc))
            {
                MessageBox.Show("Girdiğiniz Tc kimlik numarası sistemde bulunmaktadır. Tekrar deneyin.");

                Temizle();
            }
            else
            {
                db.TBLMusteri.Add(m);
                db.SaveChanges();

                MessageBox.Show("Kayıt oluşturuldu. Araç Rezervasyon için giriş yapabilirsiniz.");

                Temizle();
            }
            //MusteriListe();
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
        //public void MusteriListe()
        //{
        //    listView1.Items.Clear();
        //    foreach (Musteri item in db.TBLMusteri.ToList())
        //    {
        //        ListViewItem lvi = new ListViewItem();
        //        lvi.Text = item.ID.ToString();
        //        lvi.SubItems.Add(item.Tc.ToString());
        //        lvi.SubItems.Add(item.Ad.ToString());
        //        lvi.SubItems.Add(item.Soyad.ToString());
        //        lvi.SubItems.Add(item.Telefon.ToString());
        //        lvi.SubItems.Add(item.EhliyetNo.ToString());
        //        lvi.SubItems.Add(item.Adres.ToString());
        //        lvi.SubItems.Add(item.Email.ToString());
        //        lvi.SubItems.Add(item.AddDate.ToString());
        //        lvi.Tag = item.ID;//listviewde tıklanan satırın ID sini almasını sağlıyoruz!!
        //        listView1.Items.Add(lvi);
        //    }
        //}
    }
}
