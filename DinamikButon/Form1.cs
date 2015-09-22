using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnButonOlustur_Click(object sender, EventArgs e)
        {
            Button btn = new Button(); // butonun oluşturulması
            btn.Location = new Point(10, 100); // butonun koordinatları
            btn.Height = 40; // butonun yüksekliği
            btn.Width = 300; // butonun genişliği
            btn.Text = "Yeni Oluşan Buton"; // butonun texti
            btn.Click += new EventHandler(btn_Click); // butonun eventi
            btn.BackColor = Color.Turquoise; // butonun rengi
            
            Controls.Add((Button)btn); // butonun eklenmesi
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ben yeni oluşan butonum!","Yeni Buton Mesaj");
        }
    }
}
