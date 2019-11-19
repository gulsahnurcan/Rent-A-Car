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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ArabaListe();
            KiraListe();
        }
        ProjeContext db = new ProjeContext();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            a.Plaka = txt_plaka.Text;
            a.Marka = txt_marka.Text;
            a.Model = txt_model.Text;
            a.AracTipi = (string)cmb_aractipi.SelectedItem;
            a.Vites = (string)cmb_vites.SelectedItem;
            a.YakitTipi = (string)cmb_yakittipi.SelectedItem;
            a.Fiyat = Convert.ToDouble(txt_fiyat.Text);
            a.AddDate = DateTime.Now;
            a.AktifMi = false;
            
            db.TBLAraba.Add(a);
            db.SaveChanges();

            BilgiTemizle();
            ArabaListe();
        }

        public void BilgiTemizle()
        {
            txt_plaka.Text = default(string);
            txt_marka.Text = default(string);
            txt_model.Text = default(string);
            cmb_aractipi.SelectedIndex = -1;
            cmb_vites.SelectedIndex = -1;
            cmb_yakittipi.SelectedIndex = -1;
            txt_fiyat.Text = default(string);
        }

        public void ArabaListe()
        {
            listView1.Items.Clear();
            foreach (Araba item in db.TBLAraba.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Plaka);
                lvi.SubItems.Add(item.Marka);
                lvi.SubItems.Add(item.Model);
                lvi.SubItems.Add(item.AracTipi);
                lvi.SubItems.Add(item.Vites);
                lvi.SubItems.Add(item.YakitTipi);
                lvi.SubItems.Add(item.Fiyat.ToString());
                lvi.SubItems.Add(item.AddDate.ToString());
                lvi.Tag = item.ID;//listviewde tıklanan satırın ID sini almasını sağlıyoruz!!
                listView1.Items.Add(lvi);
            }
        }
        public void KiraListe()
        {
            listView2.Items.Clear();
            List<ArabaMusteri> kirada = db.TBLArabaMusteri.Where(x => x.AktifMi == true).ToList();
            foreach (ArabaMusteri item in kirada)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.ID.ToString();
                lv.SubItems.Add(item.ArabaId.ToString());
                lv.SubItems.Add(item.MusteriId.ToString());
                lv.SubItems.Add(item.AlisTarihi.ToString());
                lv.SubItems.Add(item.TeslimTarihi.ToString());
                lv.SubItems.Add(item.KiralanmaSuresi.ToString());
                lv.SubItems.Add(item.Tutar.ToString());

                lv.Tag = item.ID;
                listView2.Items.Add(lv);
            }
        }

        Araba guncel;
        int id;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].Tag);

            guncel = db.TBLAraba.Find(id);
            
            txt_guncelplaka.Text = guncel.Plaka;
            txt_guncelmarka.Text = guncel.Marka;
            txt_guncelmodel.Text = guncel.Model;

            if(guncel.AktifMi==false)
            {
                lbl_aracdurumu.Text = "Araç Aktif.";
            }
            else
            {
                lbl_aracdurumu.Text = "Araç Kirada.";
            }
        }
        
        private void btn_teslim_Click(object sender, EventArgs e)
        {
            if (guncel.AktifMi == true)
            {
                guncel.AktifMi = false;
                guncel.UpdateDate = DateTime.Now;
                db.SaveChanges();
                MessageBox.Show("Araç Teslim Alındı.");
                
            }
            else
            {
                MessageBox.Show("Araç Zaten Teslim Edilmiş.");
            }
           
            lbl_aracdurumu.Text = default(string);
            txt_guncelplaka.Text = default(string);
            txt_guncelmarka.Text = default(string);
            txt_guncelmodel.Text = default(string);
            txt_model.Text = default(string);
        }
        
        private void btn_aracsil_Click(object sender, EventArgs e)
        {
            guncel = db.TBLAraba.Find(id); 
            txt_plaka.Text = guncel.Plaka;
            txt_marka.Text = guncel.Marka;
            txt_model.Text = guncel.Model;
            cmb_aractipi.SelectedItem = guncel.AracTipi;
            cmb_vites.SelectedItem = guncel.Vites;
            cmb_yakittipi.SelectedItem = guncel.YakitTipi;
            txt_fiyat.Text = Convert.ToString(guncel.Fiyat);
        }

        Araba updated;
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            updated = db.TBLAraba.Find(id);
            updated.Plaka = txt_plaka.Text;
            updated.Marka = txt_marka.Text;
            updated.Model = txt_model.Text;
            updated.AracTipi= (string)cmb_aractipi.SelectedItem;
            updated.Vites = (string)cmb_vites.SelectedItem;
            updated.YakitTipi = (string)cmb_yakittipi.SelectedItem;
            updated.Fiyat =Convert.ToDouble(txt_fiyat.Text);
            updated.UpdateDate = DateTime.Now;
            
            db.Entry(db.TBLAraba.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            MessageBox.Show("Araç Güncellendi.");

            BilgiTemizle();
            ArabaListe();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Araba deleted = db.TBLAraba.Find(id);
            db.TBLAraba.Remove(deleted);//db nin Products tablosu var bizim nesnemiz olan products değil.
            deleted.DeletedDate = DateTime.Now;
            db.SaveChanges();//her savechanges dediğimizde bütün veri tabanını kaydediyor
            MessageBox.Show("Araç Silindi.");

            BilgiTemizle();
            ArabaListe();
        }

        int idkira;
        ArabaMusteri teslim;
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            idkira = Convert.ToInt32(listView2.SelectedItems[0].Tag);

            teslim = db.TBLArabaMusteri.Find(idkira);

            txt_splaka.Text = teslim.Araba.Plaka;
            txt_smarka.Text = teslim.Araba.Marka;
            txt_smodel.Text = teslim.Araba.Model;

            if (teslim.AktifMi == true)
            {
                lbl_sdurumu.Text = "Devam.";
            }
            else
            {
                lbl_sdurumu.Text = "İptal.";
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if (teslim.AktifMi == true)
            {
                teslim.TeslimTarihi = DateTime.Now;
                teslim.AktifMi = false;
                db.SaveChanges();
                MessageBox.Show("Sözleşme İptal Edildi.");
            }
            else
            {
                MessageBox.Show("Aracın sözleşmesi zaten bitmiş.");
            }

            lbl_sdurumu.Text = default(string);
            txt_splaka.Text = default(string);
            txt_smarka.Text = default(string);
            txt_smodel.Text = default(string);
            KiraListe();

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            BilgiTemizle();
        }
    }
}
