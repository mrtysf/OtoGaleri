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
    public partial class Satiskontrol : UserControl
    {
        public Satiskontrol()
        {
            InitializeComponent();
            //this.Plakacmbbx.SelectedIndexChanged += new System.EventHandler(Plakacmbbx_SelectedIndexChanged);
        }
        
        private void Satiskontrol_Load(object sender, EventArgs e)
        {
            var db = new GaleriDB();

            var plakalar = db.Arac.ToList();
            foreach (var item in plakalar)
            {
                Plakacmbbx.Items.Add(item.Plaka);
                
            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Plakacmbbx.SelectedIndexChanged += Plakacmbbx_SelectedIndexChanged;
        }

        private void Plakacmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(Convert.ToString(Plakacmbbx.SelectedItem));
            //pictureBox1.Size = pictureBox1.Image.Size;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
