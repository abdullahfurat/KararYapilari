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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            switch(txtGelenDeger1.Text)
            {

                case "admin":
                
                    switch(txtGelenDeger2.Text)
                    {
                        case "123":
                            MessageBox.Show("Kullanıcı adınız ve Şifreniz doğru");
                        break;
                        default:
                            MessageBox.Show("Kullanıcı adınız doğru , Fakat şifreniz yanlış");
                            break;                            
                    }
                    break;
                default:
                    MessageBox.Show("Kullanıcı adınız yanlış , şifrenizi kontrol etmedim.");
                    break;

            }
        }
    }
}
