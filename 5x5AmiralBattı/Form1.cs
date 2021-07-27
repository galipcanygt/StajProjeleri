using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5x5AmiralBattı
{
    public partial class Form1 : Form
    {
        int düzy;
        int düzx;
        PictureBox timeragiden;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PictureBox picture = (PictureBox)sender;
            timeragiden = picture;
            düzx = int.Parse(picture.Name.Substring(10)) % 5;
            if (düzx != 0)
            {
                düzy = int.Parse(picture.Name.Substring(10)) / 5 + 1;
            }
            else
            {
                düzy = int.Parse(picture.Name.Substring(10)) / 5 ;
                düzx = 5;
            }

            string metin = düzx.ToString() + " - " + düzy.ToString();
            listBox1.Items.Add(metin);
            picture.Image = Image.FromFile("C:\\Users\\galip\\Downloads\\su.jpg");
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            düzx = int.Parse(picture.Name.Substring(10)) % 5;
            if (düzx != 0)
            {
                düzy = int.Parse(picture.Name.Substring(10)) / 5 + 1;
            }
            else
            {
                düzy = int.Parse(picture.Name.Substring(10)) / 5;
                düzx = 5;
            }

            string metin = düzx.ToString() + " - " + düzy.ToString() + " Vurdunuz.";
            listBox1.Items.Add(metin);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeragiden.Image = null;
        }

        
    }
}
