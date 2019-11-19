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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //string tc = Form3.veri;
            //List<Musteri> ml = new List<Musteri>();
            //ml = db.TBLMusteri.Where(x => x.Tc == tc).ToList();
            //foreach (Musteri item in ml)
            //{

            //}
            txt_musteritc.Text = Form3.veri;
        }
        ProjeContext db = new ProjeContext();

        private void Form4_Load(object sender, EventArgs e)
        {
            Liste();
        }

        public void Liste ()
        {
            listView1.Items.Clear();
            List<Araba> bos = db.TBLAraba.Where(x => x.AktifMi == false).ToList();

            foreach (Araba item in bos)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Plaka;
                lvi.SubItems.Add(item.Marka);
                lvi.SubItems.Add(item.Model);
                lvi.SubItems.Add(item.AracTipi);
                lvi.SubItems.Add(item.Vites);
                lvi.SubItems.Add(item.YakitTipi);
                lvi.SubItems.Add(item.Fiyat.ToString());
                lvi.Tag = item.ID;  //listviewde tıklanan satırın ID sini almasını sağlıyoruz!!
                listView1.Items.Add(lvi);
            }
        }

        Araba rezerv;
        int id;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].Tag);

            rezerv = db.TBLAraba.Find(id);
            txt_arabaid.Text = Convert.ToString(rezerv.ID);
        }

        ArabaMusteri kira = new ArabaMusteri();
        public void Kiralama()
        {
            kira.ArabaId = rezerv.ID;

            Musteri m = new Musteri();

            m.Tc = Form3.veri;

            //m.Tc = txt_musteritc.Text;
            
            List<Musteri> k = db.TBLMusteri.Where(x => x.Tc == m.Tc).ToList();
            foreach (Musteri item in k)
            {
                kira.MusteriId = item.ID;
            }

            kira.AlisTarihi = Convert.ToDateTime(txt_alistarihi.Text);
            kira.TeslimTarihi = Convert.ToDateTime(txt_teslimtarihi.Text);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Kiralama();
            //MessageBox.Show("Süre: " + kira.KiralanmaSuresi.ToString() + ","+"  Tutar: " + kira.Tutar.ToString());

            if (kira.AlisTarihi.Day < DateTime.Now.Day || kira.AlisTarihi.Month < DateTime.Now.Month ||kira.AlisTarihi.Year < DateTime.Now.Year)
            {
                MessageBox.Show("Geçmiş bir tarih için kiralama yapamazsınız.");
            }
            else if (kira.AlisTarihi > kira.TeslimTarihi)
            {
                MessageBox.Show("Teslim tarihi alış tarihinden küçük olamaz.");
            }
            else
            {
                TimeSpan t = kira.TeslimTarihi - kira.AlisTarihi;

                kira.KiralanmaSuresi = t.Days;
                kira.Tutar = rezerv.Fiyat * t.Days;

                DialogResult dialogResult = MessageBox.Show("Süre: " + kira.KiralanmaSuresi.ToString() + "," + "  Tutar: " + kira.Tutar.ToString() + "  Onaylıyor musunuz?", "Sözleşme Onay", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    rezerv.AktifMi = true;
                    kira.AktifMi = true;
                    db.TBLArabaMusteri.Add(kira);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Oluşturuldu.");

                    Liste();

                    txt_arabaid.Text = default(string);
                    txt_musteritc.Text = default(string);
                    txt_alistarihi.Text = default(string);
                    txt_teslimtarihi.Text = default(string);
                }
                else if (dialogResult == DialogResult.No)
                {
                    txt_arabaid.Text = default(string);
                    txt_musteritc.Text = default(string);
                    txt_alistarihi.Text = default(string);
                    txt_teslimtarihi.Text = default(string);
                }
            }
        }
        


    }
}
