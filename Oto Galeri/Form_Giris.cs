using Oto_Galeri.Model;
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
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
           
            //Kullanici ekle 

            /*GaleriDB galeri = new GaleriDB();
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Ad = "Murat";
            kullanici.Sifre = "123";
            kullanici.Soyad = "Yusuf";
            kullanici.Email = "mrtysf94@gmail.com";
            galeri.Kullanicilar.Add(kullanici);
            galeri.SaveChanges();*/






        }
       
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox1.Text == "" && bunifuMaterialTextbox2.Text == "")
            {
                Form_Home otogaleri = new Form_Home();
                otogaleri.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı veya Şifre Hatalı");
            }
        }

        private void Form_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
