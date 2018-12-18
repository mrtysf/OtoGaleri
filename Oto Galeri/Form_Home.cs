using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
            yanpanel.Height = btnAnaSayfa.Height;
            anasayfakontrol1.BringToFront();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            yanpanel.Height = btnAnaSayfa.Height;
            yanpanel.Top = btnAnaSayfa.Top;
            anasayfakontrol1.BringToFront();
        }

        private void btnOtomobil_Click(object sender, EventArgs e)
        {
            yanpanel.Height = btnOtomobil.Height;
            yanpanel.Top = btnOtomobil.Top;
            otomobilkontrol1.BringToFront();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            yanpanel.Height = btnMusteri.Height;
            yanpanel.Top = btnMusteri.Top;
            musterikontrol1.BringToFront();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            yanpanel.Height = btnSatis.Height;
            yanpanel.Top = btnSatis.Top;
            satiskontrol1.BringToFront();
        }

        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            yanpanel.Height = btnKayitlar.Height;
            yanpanel.Top = btnKayitlar.Top;
            kayitlarKontrol1.BringToFront();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
