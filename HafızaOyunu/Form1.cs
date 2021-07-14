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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "HAFIZA OYUNUNA HOŞGELDİNİZ";
            label2.Text = "Lütfen Oynamak İstediğiniz Zorluğu Seçin  ";
            radioButton1.Text ="Yavaş";
            radioButton2.Text ="Normal";
            radioButton3.Text ="Hızlı";
            button1.Text = "İlerle";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gereken ayar = new Gereken();
            if (radioButton1.Checked)
            {
                Gereken.zorluk = 3;
                //MessageBox.Show("Radiobutton1 çalıştı");
            }
            else if (radioButton2.Checked)
            {
                Gereken.zorluk = 2;
                //MessageBox.Show("Radiobutton2 çalıştı");
            }
            else if (radioButton3.Checked)
            {
                Gereken.zorluk = 1;
                //MessageBox.Show("Radiobutton3 çalıştı");
            }
            else
            {
                Gereken.zorluk = 4;
            }
            BoyutSecim fr = new BoyutSecim();
            fr.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
