using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_dik_üçgende_alan_ve_çevre_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dik_üçgen hesapla = new Dik_üçgen();

            label5.Text= hesapla.alan_hesapla(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
            label6.Text= hesapla.cevre_hesapla(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();


        }
    }
}
