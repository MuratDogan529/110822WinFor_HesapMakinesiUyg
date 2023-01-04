using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110822WinFor_HesapMakinesiUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Dünyaya Hoş Geldin UZaylı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Text = "Hesap Makinesi";
           int sayi1=Convert.ToInt32(textBox1.Text);
           int sayi2=Convert.ToInt32(textBox2.Text);
           int toplam = sayi1 + sayi2;
            MessageBox.Show(string.Format("Sayıların Toplamı:{0}", toplam));


        }
    }
}
