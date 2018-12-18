namespace Oto_Galeri
{
    partial class Musterikontrol
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musterikontrol));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tcnotxtbx = new System.Windows.Forms.TextBox();
            this.Adtxtbx = new System.Windows.Forms.TextBox();
            this.Soyadtxtbx = new System.Windows.Forms.TextBox();
            this.Ceptxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dogumtxtbx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Anneadtxtbx = new System.Windows.Forms.TextBox();
            this.Babaadtxtbx = new System.Windows.Forms.TextBox();
            this.Cep2txtbx = new System.Windows.Forms.TextBox();
            this.Adrestxtbx = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.Emailtxtbx = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Yuklebttn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(56, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tcnotxtbx
            // 
            this.Tcnotxtbx.Location = new System.Drawing.Point(300, 57);
            this.Tcnotxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tcnotxtbx.Multiline = true;
            this.Tcnotxtbx.Name = "Tcnotxtbx";
            this.Tcnotxtbx.Size = new System.Drawing.Size(211, 31);
            this.Tcnotxtbx.TabIndex = 7;
            this.Tcnotxtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Adtxtbx
            // 
            this.Adtxtbx.Location = new System.Drawing.Point(300, 127);
            this.Adtxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Adtxtbx.Multiline = true;
            this.Adtxtbx.Name = "Adtxtbx";
            this.Adtxtbx.Size = new System.Drawing.Size(211, 31);
            this.Adtxtbx.TabIndex = 8;
            this.Adtxtbx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Soyadtxtbx
            // 
            this.Soyadtxtbx.Location = new System.Drawing.Point(300, 199);
            this.Soyadtxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Soyadtxtbx.Multiline = true;
            this.Soyadtxtbx.Name = "Soyadtxtbx";
            this.Soyadtxtbx.Size = new System.Drawing.Size(211, 32);
            this.Soyadtxtbx.TabIndex = 9;
            // 
            // Ceptxtbx
            // 
            this.Ceptxtbx.Location = new System.Drawing.Point(300, 272);
            this.Ceptxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ceptxtbx.Multiline = true;
            this.Ceptxtbx.Name = "Ceptxtbx";
            this.Ceptxtbx.Size = new System.Drawing.Size(211, 31);
            this.Ceptxtbx.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(295, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "T.C No *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(295, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(295, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(295, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cep Telefonu";
            // 
            // Dogumtxtbx
            // 
            this.Dogumtxtbx.AutoSize = true;
            this.Dogumtxtbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dogumtxtbx.Location = new System.Drawing.Point(553, 245);
            this.Dogumtxtbx.Name = "Dogumtxtbx";
            this.Dogumtxtbx.Size = new System.Drawing.Size(136, 23);
            this.Dogumtxtbx.TabIndex = 22;
            this.Dogumtxtbx.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(553, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Anne Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(553, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Baba Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(553, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cep Telefonu(diğer)";
            // 
            // Anneadtxtbx
            // 
            this.Anneadtxtbx.Location = new System.Drawing.Point(557, 199);
            this.Anneadtxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Anneadtxtbx.Multiline = true;
            this.Anneadtxtbx.Name = "Anneadtxtbx";
            this.Anneadtxtbx.Size = new System.Drawing.Size(211, 32);
            this.Anneadtxtbx.TabIndex = 17;
            // 
            // Babaadtxtbx
            // 
            this.Babaadtxtbx.Location = new System.Drawing.Point(557, 127);
            this.Babaadtxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Babaadtxtbx.Multiline = true;
            this.Babaadtxtbx.Name = "Babaadtxtbx";
            this.Babaadtxtbx.Size = new System.Drawing.Size(211, 31);
            this.Babaadtxtbx.TabIndex = 16;
            // 
            // Cep2txtbx
            // 
            this.Cep2txtbx.Location = new System.Drawing.Point(557, 57);
            this.Cep2txtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cep2txtbx.Multiline = true;
            this.Cep2txtbx.Name = "Cep2txtbx";
            this.Cep2txtbx.Size = new System.Drawing.Size(211, 31);
            this.Cep2txtbx.TabIndex = 15;
            // 
            // Adrestxtbx
            // 
            this.Adrestxtbx.AutoSize = true;
            this.Adrestxtbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adrestxtbx.Location = new System.Drawing.Point(807, 100);
            this.Adrestxtbx.Name = "Adrestxtbx";
            this.Adrestxtbx.Size = new System.Drawing.Size(66, 23);
            this.Adrestxtbx.TabIndex = 28;
            this.Adrestxtbx.Text = "Adres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(807, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "E-mail";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(811, 127);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(211, 176);
            this.textBox11.TabIndex = 24;
            // 
            // Emailtxtbx
            // 
            this.Emailtxtbx.Location = new System.Drawing.Point(811, 57);
            this.Emailtxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Emailtxtbx.Multiline = true;
            this.Emailtxtbx.Name = "Emailtxtbx";
            this.Emailtxtbx.Size = new System.Drawing.Size(211, 31);
            this.Emailtxtbx.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(557, 270);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 32);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Kaydet";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.Location = new System.Drawing.Point(905, 330);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(117, 42);
            this.bunifuThinButton21.TabIndex = 43;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Yuklebttn
            // 
            this.Yuklebttn.ActiveBorderThickness = 1;
            this.Yuklebttn.ActiveCornerRadius = 20;
            this.Yuklebttn.ActiveFillColor = System.Drawing.Color.Teal;
            this.Yuklebttn.ActiveForecolor = System.Drawing.Color.White;
            this.Yuklebttn.ActiveLineColor = System.Drawing.Color.Teal;
            this.Yuklebttn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Yuklebttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Yuklebttn.BackgroundImage")));
            this.Yuklebttn.ButtonText = "Yükle";
            this.Yuklebttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yuklebttn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yuklebttn.ForeColor = System.Drawing.Color.Teal;
            this.Yuklebttn.IdleBorderThickness = 1;
            this.Yuklebttn.IdleCornerRadius = 20;
            this.Yuklebttn.IdleFillColor = System.Drawing.Color.White;
            this.Yuklebttn.IdleForecolor = System.Drawing.Color.Teal;
            this.Yuklebttn.IdleLineColor = System.Drawing.Color.Teal;
            this.Yuklebttn.Location = new System.Drawing.Point(103, 278);
            this.Yuklebttn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Yuklebttn.Name = "Yuklebttn";
            this.Yuklebttn.Size = new System.Drawing.Size(105, 42);
            this.Yuklebttn.TabIndex = 44;
            this.Yuklebttn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Yuklebttn.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Musterikontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Yuklebttn);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Adrestxtbx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.Emailtxtbx);
            this.Controls.Add(this.Dogumtxtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Anneadtxtbx);
            this.Controls.Add(this.Babaadtxtbx);
            this.Controls.Add(this.Cep2txtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ceptxtbx);
            this.Controls.Add(this.Soyadtxtbx);
            this.Controls.Add(this.Adtxtbx);
            this.Controls.Add(this.Tcnotxtbx);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Musterikontrol";
            this.Size = new System.Drawing.Size(1097, 398);
            this.Load += new System.EventHandler(this.Musterikontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Tcnotxtbx;
        private System.Windows.Forms.TextBox Adtxtbx;
        private System.Windows.Forms.TextBox Soyadtxtbx;
        private System.Windows.Forms.TextBox Ceptxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Dogumtxtbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Anneadtxtbx;
        private System.Windows.Forms.TextBox Babaadtxtbx;
        private System.Windows.Forms.TextBox Cep2txtbx;
        private System.Windows.Forms.Label Adrestxtbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox Emailtxtbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 Yuklebttn;
    }
}
