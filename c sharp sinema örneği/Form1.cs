using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_sinema_örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Sinema salon;
        private void button1_Click(object sender, EventArgs e)
        {
            salon = new Sinema(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "salon olusturuldu. Koltuk sayısı" + salon.boskoltukogren();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            salon.biletsat(checkBox1.Checked);
            label3.Text = "Bilet satıldı. Kalan koltuk sayısı:" + salon.boskoltukogren();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salon.biletiptal(checkBox1.Checked);
            label3.Text = "Bilet iptal edildi. Kalan koltuk sayısı:" + salon.boskoltukogren();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Toplam bakiyeniz:" + salon.bakiyeogren();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            label3.Text = "Bos koltuk sayısı:" + salon.boskoltukogren();
        }
    }
}
