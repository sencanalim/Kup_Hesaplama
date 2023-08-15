using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Küp_Hesabı_Yap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int kup (int slot1)
        {

            int kup = slot1*slot1*slot1;
            return kup;


        }
        // Bir sayının küpünü textboxtan çekip aynı zamanda tek slot kullanarak method ile işlemi yaptırdık.
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.RoyalBlue;
            textBox2.Enabled = false;
            textBox2.Text = kup(Convert.ToInt32(textBox1.Text)).ToString();
            textBox2.BackColor = Color.LightGreen;
            MessageBox.Show(textBox1.Text + " Sayısının Küpü = " + textBox2.Text);

        }
    }
}
