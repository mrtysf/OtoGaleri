using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Oto_Galeri.Model;
using System.Data.SqlClient;

namespace Oto_Galeri
{
    public partial class Otomobilkontrol : UserControl
    {
        public Otomobilkontrol()
        {
            InitializeComponent();
            
           
        }
        

        private void Otomobilkontrol_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 7; i++)
            {
                BunifuImageButton bunifuImageButton1 = new BunifuImageButton();
                bunifuImageButton1.Image = Image.FromFile("C:\\Users\\Murat\\Desktop\\"+i+".jpg");
                bunifuImageButton1.BackColor = System.Drawing.Color.White;
                bunifuImageButton1.Width = 150;
                bunifuImageButton1.Height = 100;
                bunifuImageButton1.Visible = true;
                bunifuImageButton1.Location = new Point(panel2.Controls.Count * 160,0);
                panel2.Controls.Add(bunifuImageButton1);
            }

            var db = new GaleriDB();
            //AracRenk renk = new AracRenk();


            //select
            var renkler = db.AracRenk.ToList();
            foreach (var item in renkler)
            {
                Renkcmbbx.Items.Add(item.Renk);
            }

            var markalar = db.Marka.ToList();
            foreach (var item in markalar)
            {
                Markacmbbx.Items.Add(item.Marka1);
            }

            var modeller = db.Model.ToList();
            foreach (var item in modeller)
            {
                Modelcmbbx.Items.Add(item.Model1);
            }

            var kategoriler = db.AracKategori.ToList();
            foreach (var item in kategoriler)
            {
                Aracturucmbbx.Items.Add(item.Ad);
            }
            



            //string Sql = "select * from dbo.AracRenk";
            //SqlConnection conn = new SqlConnection(connString);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(Sql, conn);
            //SqlDataReader DR = cmd.ExecuteReader();

            //while (DR.Read())
            //{
            //    combobox1.Items.Add(DR[0]);

            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Plakatxtbx.Text == "" || Aciklamatxtbx.Text == "")
            {
                MessageBox.Show("Lütfen alanları eksiksiz doldurunuz");
            }
            else
            {
                var db = new GaleriDB() ;
                //AracOzellikler yeniOzellik = new AracOzellikler();
                //yeniOzellik.ModelYil = DateTime.Parse(Yilcmbbx.Text);               

                Arac yeniArac = new Arac();
                yeniArac.Plaka = Plakatxtbx.Text;
                yeniArac.Aciklama = Aciklamatxtbx.Text;
                yeniArac.RenkId = Renkcmbbx.SelectedIndex + 1;
                yeniArac.MarkaId = Markacmbbx.SelectedIndex + 1;
                yeniArac.ModelId = Modelcmbbx.SelectedIndex + 1;
                db.Arac.Add(yeniArac);
                var ctrl = db.SaveChanges();
                if (ctrl == 1)
                {
                    MessageBox.Show("Araç kaydedildi.");
                    Plakatxtbx.ResetText();
                    Aciklamatxtbx.ResetText();
                    Renkcmbbx.ResetText();
                    Aracturucmbbx.ResetText();
                    Markacmbbx.ResetText();
                    Modelcmbbx.ResetText();
                    Yilcmbbx.ResetText();
                    Yakitturucmbbx.ResetText();
                    Kmtxtbx.ResetText();
                    Vitescmbbx.ResetText();
                    Motorhacmicmbbx.ResetText();
                    Beygirgucutxtbx.ResetText();


                }
            }


        }
            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void Modelcmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Modelcmbbx.Text == "X5" || Modelcmbbx.Text == "X6" || Modelcmbbx.Text == "X7")
            //{
            //    Markacmbbx.Items.Clear();
            //    Markacmbbx.Items.Add("BMW");


            //}
           
        }

        private void Aracturucmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Markacmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Markacmbbx.Text == "BMW")
            {
                Modelcmbbx.Items.Clear();
                String[] Bmw = { "X5", "X6", "X7" };
                Modelcmbbx.Items.AddRange(Bmw);
            }
            else if (Markacmbbx.Text == "AUDI")
            {
                Modelcmbbx.Items.Clear();
                String[] Audi = { "A5", "A6", "A7" };
                Modelcmbbx.Items.AddRange(Audi);
            }
            else if (Markacmbbx.Text == "MERCEDES")
            {
                Modelcmbbx.Items.Clear();
                String[] Mercedes = { "E", "AMG", "CLA" };
                Modelcmbbx.Items.AddRange(Mercedes);
            }
            else if (Markacmbbx.Text == "VOLVO")
            {
                Modelcmbbx.Items.Clear();
                String[] Volvo = { "S60", "S70", "S90" };
                Modelcmbbx.Items.AddRange(Volvo);
            }
            else if (Markacmbbx.Text == "VOLKSWAGEN")
            {
                Modelcmbbx.Items.Clear();
                String[] Volkswagen = { "PASSAT", "JETTA", "CC" };
                Modelcmbbx.Items.AddRange(Volkswagen);
            }
            else if (Markacmbbx.Text == "CHEVROLET")
            {
                Modelcmbbx.Items.Clear();
                String[] Chevrolet = { "CRUZE" };
                Modelcmbbx.Items.AddRange(Chevrolet);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
