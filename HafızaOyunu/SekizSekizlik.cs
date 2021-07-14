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
    public partial class SekizSekizlik : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k", "c", "a", "t", "i", "r", "x", "p", "q", "H", "m", "1", "2", "3", "T", ".", "J", "e", "s", "0", "Z", "?", "O", "I", "U",
            "b", "b", "v", "v", "w", "w", "z", "z", "c", "a", "t", "i", "r", "x", "p", "q", "H", "m", "1", "2", "3", "T", ".", "J", "e", "s", "0", "Z", "?", "O", "I", "U",
        };

        Label ilktik = null;
        Label ikincitik = null;

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.BackColor = Color.CornflowerBlue;
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public SekizSekizlik()
        {
            InitializeComponent();
            AssignIconsToSquares();
            timer2.Start();
            timer3.Start();
            button1.Text = "Baştan Başla";
            button2.Text = "Ana Menü";
            tableLayoutPanel1.BackColor = Color.CornflowerBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.AutoSize = false;
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (ilktik == null)
                {
                    ilktik = clickedLabel;
                    ilktik.ForeColor = Color.Black;
                    return;
                }

                ikincitik = clickedLabel;
                ikincitik.ForeColor = Color.Black;

                if (Gereken.zorluk == 4)
                {
                    timer1.Interval = 1175;
                }
                else if (Gereken.zorluk == 3)
                {
                    timer1.Interval = 900;
                }
                else if (Gereken.zorluk == 2)
                {
                    timer1.Interval = 625;

                }
                else if (Gereken.zorluk == 1)
                {
                    timer1.Interval = 350;

                }

                CheckForWinner();

                if (ilktik.Text == ikincitik.Text)
                {
                    ilktik = null;
                    ikincitik = null;
                    return;
                }

                timer1.Start();
            }
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            timer2.Stop();
            timer3.Stop();
            Gereken.score = Gereken.süre * 512 / Gereken.zorluk;
            MessageBox.Show("Oyunu kazandınız. Skorunuz: " + Gereken.score, "Tebrikler!!");
            yenidenoyna fr = new yenidenoyna();
            fr.Show();
            Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            ilktik.ForeColor = ilktik.BackColor;
            ikincitik.ForeColor = ikincitik.BackColor;

            ilktik = null;
            ikincitik = null;
        }

        private void SekizSekizlik_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            Gereken.score = 0; ;
            MessageBox.Show("Süreniz Bitmiştir!!", "Başaramadın!");
            yenidenoyna fr = new yenidenoyna();
            fr.Show();
            Hide();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Gereken.süre = Gereken.süre - 1;
            label65.Text = Gereken.süre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gereken.süre = 200;
            SekizSekizlik fr = new SekizSekizlik();
            fr.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gereken.süre = 200;
            Form1 fr = new Form1();
            fr.Show();
            Close();
        }
    }
}
