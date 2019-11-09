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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string mevsim = txtMevsim.Text;

            switch(mevsim)

            {
                case ("Kış"):
                    MessageBox.Show("Aralık, Ocak, Şubat");
                    break;
                case ("İlkbahar"):
                    MessageBox.Show("Mart, Nisan, Mayıs");
                    break;
                case ("Yaz"):
                    MessageBox.Show("Haziran, Temmuz, Ağustos");
                    break;
                case ("Sonbahar"):
                    MessageBox.Show("Eylül, Ekim, Kasım");
                    break;
                    default:
                    MessageBox.Show("Girdiğiniz Mevsim adını kontrol ediniz.");
                    break;




            }
        }
    }
}
