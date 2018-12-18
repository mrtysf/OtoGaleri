using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oto_Galeri.Model;

namespace Oto_Galeri
{
    public partial class Musterikontrol : UserControl
    {
        
        public Musterikontrol()
        {
            InitializeComponent();
        }
        GaleriDB db;
        private void Musterikontrol_Load(object sender, EventArgs e)
        {
         db = new GaleriDB();  
            

                        

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Musteri yenimusteri = new Musteri();
            yenimusteri.TcNo = Convert.ToDecimal(Tcnotxtbx.Text);
            yenimusteri.Ad = Adtxtbx.Text;
            yenimusteri.Soyad = Soyadtxtbx.Text;
            yenimusteri.Tel = Convert.ToDecimal(Ceptxtbx.Text);
            yenimusteri.Tel2 = Convert.ToDecimal(Cep2txtbx.Text);
            yenimusteri.BabaAdı = Babaadtxtbx.Text;
            yenimusteri.AnneAdı = Anneadtxtbx.Text;
            yenimusteri.DogumTarih = dateTimePicker1.Value;
            yenimusteri.Adres = Adrestxtbx.Text;
            db.Musteri.Add(yenimusteri);
            var ctrl =  db.SaveChanges();
            if(ctrl > 0)
            {
                MessageBox.Show("Müşteri Kaydedildi.");
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Jpeg|*.jpg";
            openFileDialog1.Title = "Lütfen fotoğraf seçiniz";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                
            }
        }

        
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
