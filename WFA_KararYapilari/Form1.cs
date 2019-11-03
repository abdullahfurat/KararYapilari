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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
          KARAR YAPILARI
          Uygulamanizin calismasi esnasinda farkli senaryolara gore farkli yonlendirmeler yapmaniz gerekebilir. Ornegin, kullanicidan gelen degerin araligina gore, uygulamadaki mantiksal islerinizin sonuclarina gore yonlendirmeler yapabiliriz. 
          3 temel karar yapısı karsimiza cikar => IF-ELSE ~ SWITCH-CASE ~ TERNARY OPERATORU
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
              1) ==   (Soldaki değerin, sağdaki değere eşit olma durumu)
                1 == 1  => true
                1 == 2  => false

              2) !=   (Soldaki değerin, sağdaki değere eşit olmama durumu)
                1 != 2  => true
                1 != 1  => false

              3) <    (Soldaki değerin, sağdaki değerden, küçük olma durumu)
                2 < 1  => false
                1 < 2  => true

              4) >    (Soldaki değerin, sağdaki değerden, büyük olma durumu)
                2 > 1  => true
                1 > 2  => false

              5) <=   (Soldaki değerin, sağdaki değerden, küçük veya eşit olma durumu)
                1 <= 2 => true (küçük olma durumu)
                1 <= 1 => true (eşit olma durumu)
                3 <= 1 => false

              6) >=   (Soldaki değerin, sağdaki değerden, büyük veya eşit olma durumu)
                2 >= 1 => true (büyük olma durumu)
                2 >= 2 => true (eşit olma durumu)
                1 >= 2 => false

              7) (1 == 1) => true - 
                !(1 == 1) => false

             */

        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            if (txtGelenDeger.Text == "admin")
            {
                MessageBox.Show("Hoşgeldiniz!");
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yanlış!");
            }


            //if (!(txtGelenDeger.Text == "admin"))
            //{
            //    MessageBox.Show("Kullanıcı bilgileri yanlış!"); 
            //}
            //else
            //{
            //    MessageBox.Show("Hoşgeldiniz!");
            //}
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Eger girilen not 0'dan kucukse "O'dan küçük bir not girişi yapamazsınız" 100'den buyukse "100'den büyük bir not girişi yapamazsınız" mesajini gostersin...
            int not = Convert.ToInt32(txtGelenDeger.Text);

            if (not < 0)
            {
                MessageBox.Show("0'dan küçük not girişi yapamazsınız!");
            }
            else if (not > 100)
            {
                MessageBox.Show("100'den büyük not girişi yapamazsınız!");
            }
            else
            {
                MessageBox.Show("Notunuz : " + not);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //txtGirisAlani'ndan girilen sayi cift ise "Sayı Çifttir" tek ise "Sayı Tektir" mesajini kullaniciya gosteriniz...

            int sayi = int.Parse(txtGelenDeger.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("Sayı çifttir");
            }
            else
            {
                MessageBox.Show("Sayı tektir");
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Disaridan girilen kelimenin uzunlugu 8 karaktere esit ya da buyukse kayit onaylandi, degilse daha uzun bir sifre giriniz...

            if (txtGelenDeger.TextLength >= 8)
            {
                MessageBox.Show("Tebrikler, şifreniz onayladı!");
            }
            else
            {
                MessageBox.Show("Lütfen daha uzun bir şifre seçiniz!");
            }
        }
    }
}
