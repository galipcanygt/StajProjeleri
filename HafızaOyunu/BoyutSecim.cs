using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu
{
    public partial class BoyutSecim : Form
    {
        public BoyutSecim()
        {
            InitializeComponent();
            label1.Text = "Oynamak İstediğiniz Boyutu Seçiniz";
            button1.Text = "Geri Dön";
            button2.Text = "Başla";
            radioButton1.Text = "4x4";
            radioButton2.Text = "6x6";
            radioButton3.Text = "8x8";
        }

        private void BoyutSecim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("4x4 boyutunda hafıza oyununuz başlıyorr");
                DortDortluk fr = new DortDortluk();
                fr.Show();
                Hide();
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("6x6 boyutunda hafıza oyununuz başlıyorr");
                AltiAltilik fr = new AltiAltilik();
                fr.Show();
                Hide();
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("8x8 boyutunda hafıza oyununuz başlıyorr");
                SekizSekizlik fr = new SekizSekizlik();
                fr.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("4x4 boyutunda hafıza oyununuz başlıyorr");
                DortDortluk fr = new DortDortluk();
                fr.Show();
                Hide();
            }
        }
    }
}
