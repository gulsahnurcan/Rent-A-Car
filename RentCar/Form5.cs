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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_arac_Click(object sender, EventArgs e)
        {
            Form2 aracform = new Form2();
            aracform.Show();
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            Form6 kk = new Form6();
            kk.Show();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            Form7 mk = new Form7();
            mk.Show();
        }
    }
}
