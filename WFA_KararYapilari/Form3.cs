using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void Form3_Load(object sender, EventArgs e)
        {
            lblRastgeleKarakterler.Text = rnd.Next(10000000, 100000000).ToString();
            // Kullanıcı label'da üretilen sayıyı textbox'a girecek, eğer kullanıcı üretilen sayıyı doğru girerse hoşgeldiniz vs. mesaj verdiriniz.
            // Kullanıcı yanlış bir data girişi yaparsa, TextBox temizlenecek, yeni bir sayı üretilecek ve kalan hakkımızdan 1 adet düşürülecek.
            // 5 Hakkımızıda yanlış değerlendirirsek, TextBox temizlenip aktiflik özelliği kapatlılacak
            // Butonun aktiflik özelliği kapatılacak ve kullanıcının işlem yapması engellenecek.
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            lblRastgeleKarakterler.Text = rnd.Next(10000000, 100000000).ToString();
        }
    }
}
