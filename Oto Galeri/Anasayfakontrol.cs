using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class Anasayfakontrol : UserControl
    {
        public Anasayfakontrol()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://binekarac.vw.com.tr/tr.html"); 
        }
    }
}
