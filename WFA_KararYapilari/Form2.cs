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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
         * MANTIKSAL OPERATORLER
         * Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
         * && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret eder... Kosullardan biri dahi saglanmazsa blogunuz harekete gecmez...)
         * || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi durumuna isaret eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz kodlar harekete gecer...) Kısayol => ALTGR + Tire
         * 
         * Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. Kosullari kontrole en soldan baslar, herhangi bir uygunsuzluk durumunda diger kosullara asla bakmaz!.. Asagidaki operatorlerde ise, kosullar uysun ya da uymasin hepsi kontrol edilir...
         * 
         * & => VE
         * | => VEYA
         */
        }

        private void btnGirisKontrolu_Click(object sender, EventArgs e)
        {
            // username, password
            string mesaj = "";
            //if (txtBirinciDeger.Text == "admin")
            //{
            //    if (txtIkinciDeger.Text == "123")
            //    {
            //        mesaj = "Tebrikler, hayatta bişeyler başarmak güzeldir!";
            //    }
            //    else
            //    {
            //        mesaj = "Kullanıcı adınız doğru, şifreniz yanlış";
            //    }
            //}
            //else
            //{
            //    mesaj = "Kullanıcı Adınız Yanlış!";
            //}

            if ((txtBirinciDeger.Text == "admin") && (txtIkinciDeger.Text == "123"))
            {
                mesaj = "Tebrikler";
            }
            else
            {
                mesaj = "Kullanıcı bilgileriniz hatalı!";
            }
            MessageBox.Show(mesaj);
        }

        private void btnNotKontrolu_Click(object sender, EventArgs e)
        {
            #region Örnek
            //Girilen not 
            // 0 - 30   "FF" 
            // 31 - 50  "DD" 
            // 51 - 70  "CC" 
            // 71 - 84  "BB" 
            // 85 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..

            //int not = 0;
            //bool sonuc = false;
            //try
            //{
            //    not = int.Parse(txtBirinciDeger.Text);
            //    sonuc = true;
            //}
            //catch
            //{
            //    sonuc = false;
            //}

            //if (sonuc)
            //{

            //}
            //else
            //{

            //} 
            #endregion

            int not = 0;
            bool sonuc = int.TryParse(txtBirinciDeger.Text, out not);

            if (!sonuc)
            {
                MessageBox.Show("Lütfen geçerli bir not giriniz");
                return;  // return anahtar kelimesi, işlemi sonlandırır. bağlı bulunduğu alanı terketmesini sağlar 
            }

            string mesaj = "Harf notunuz : {0}";
            if (not >= 0 && not <= 30) {        mesaj = string.Format(mesaj, "EE"); }
            else if (not > 30 && not <= 50) {   mesaj = string.Format(mesaj, "DD"); }
            else if (not > 50 && not <= 70) {   mesaj = string.Format(mesaj, "CC"); }
            else if (not > 70 && not <= 84) {   mesaj = string.Format(mesaj, "BB"); }
            else if (not >= 85 && not <= 100) { mesaj = string.Format(mesaj, "AA"); }
            else { mesaj = "Lütfen geçerli bir not giriniz!"; }
             
            if (not >= 0 && not <= 100)
            {
                if (not <= 30)       { mesaj = string.Format(mesaj, "EE");}
                else if (not <= 50)  { mesaj = string.Format(mesaj, "DD");}
                else if (not <= 70)  { mesaj = string.Format(mesaj, "CC");}
                else if (not <= 84)  { mesaj = string.Format(mesaj, "BB");}
                else if (not <= 100) { mesaj = string.Format(mesaj, "AA");}
            }
            else { mesaj = "Lütfen geçerli bir not giriniz!"; }
            MessageBox.Show(mesaj);

            // Kod blokları devam ediyor!!

            // Console.WriteLine("{0}.{1}@hotmail.com",isim,soyisim);

        }

        private void btnMarketKontrolu_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
        }

        private void btnSatisIslemi_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...
        }
    }
}
