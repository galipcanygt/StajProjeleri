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
    public partial class yenidenoyna : Form
    {
        public yenidenoyna()
        {
            InitializeComponent();
        }

        private void yenidenoyna_Load(object sender, EventArgs e)
        {
            label1.Text = "Yeniden Oynamak İster misiniz?";
            button2.Text = "Hayır";
            button1.Text = "Evet";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gereken.süre = 120;
            Form1 fr = new Form1();
            fr.Show();
            Hide();
        }
    }
}
