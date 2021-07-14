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
    public partial class AltiAltilik : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k", "c", "a", "t", "i", "r", "x", "p", "q", "H", "m",
            "b", "b", "v", "v", "w", "w", "z", "z", "c", "a", "t", "i", "r", "x", "p", "q", "H", "m"
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


        public AltiAltilik()
        {
            InitializeComponent();
            AssignIconsToSquares();
            timer2.Start();
            timer3.Start();
            button1.Text = "Baştan Başla";
            button2.Text = "Ana Menü";
            label37.Text = Gereken.süre.ToString();
            tableLayoutPanel1.BackColor = Color.CornflowerBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.AutoSize = false;

            //Label - 1
            label1.BackColor = Color.CornflowerBlue;
            label1.AutoSize = false;
            label1.Dock = DockStyle.Fill;

            //Label - 2
            label2.BackColor = Color.CornflowerBlue;
            label2.AutoSize = false;
            label2.Dock = DockStyle.Fill;

            //Label - 3
            label3.BackColor = Color.CornflowerBlue;
            label3.AutoSize = false;
            label3.Dock = DockStyle.Fill;

            //Label - 4
            label4.BackColor = Color.CornflowerBlue;
            label4.AutoSize = false;
            label4.Dock = DockStyle.Fill;

            //Label - 5
            label5.BackColor = Color.CornflowerBlue;
            label5.AutoSize = false;
            label5.Dock = DockStyle.Fill;

            //Label - 6
            label6.BackColor = Color.CornflowerBlue;
            label6.AutoSize = false;
            label6.Dock = DockStyle.Fill;

            //Label - 7
            label7.BackColor = Color.CornflowerBlue;
            label7.AutoSize = false;
            label7.Dock = DockStyle.Fill;

            //Label - 8
            label8.BackColor = Color.CornflowerBlue;
            label8.AutoSize = false;
            label8.Dock = DockStyle.Fill;

            //Label - 9
            label9.BackColor = Color.CornflowerBlue;
            label9.AutoSize = false;
            label9.Dock = DockStyle.Fill;

            //Label - 10
            label10.BackColor = Color.CornflowerBlue;
            label10.AutoSize = false;
            label10.Dock = DockStyle.Fill;

            //Label - 11
            label11.BackColor = Color.CornflowerBlue;
            label11.AutoSize = false;
            label11.Dock = DockStyle.Fill;

            //Label - 12
            label12.BackColor = Color.CornflowerBlue;
            label12.AutoSize = false;
            label12.Dock = DockStyle.Fill;

            //Label - 13
            label13.BackColor = Color.CornflowerBlue;
            label13.AutoSize = false;
            label13.Dock = DockStyle.Fill;

            //Label - 14
            label14.BackColor = Color.CornflowerBlue;
            label14.AutoSize = false;
            label14.Dock = DockStyle.Fill;

            //Label - 15
            label15.BackColor = Color.CornflowerBlue;
            label15.AutoSize = false;
            label15.Dock = DockStyle.Fill;

            //Label - 16
            label16.BackColor = Color.CornflowerBlue;
            label16.AutoSize = false;
            label16.Dock = DockStyle.Fill;

            //Label - 17
            label17.BackColor = Color.CornflowerBlue;
            label17.AutoSize = false;
            label17.Dock = DockStyle.Fill;

            //Label - 18
            label18.BackColor = Color.CornflowerBlue;
            label18.AutoSize = false;
            label18.Dock = DockStyle.Fill;

            //Label - 19
            label19.BackColor = Color.CornflowerBlue;
            label19.AutoSize = false;
            label19.Dock = DockStyle.Fill;

            //Label - 20
            label20.BackColor = Color.CornflowerBlue;
            label20.AutoSize = false;
            label20.Dock = DockStyle.Fill;

            //Label - 21
            label21.BackColor = Color.CornflowerBlue;
            label21.AutoSize = false;
            label21.Dock = DockStyle.Fill;

            //Label - 22
            label22.BackColor = Color.CornflowerBlue;
            label22.AutoSize = false;
            label22.Dock = DockStyle.Fill;

            //Label - 23
            label23.BackColor = Color.CornflowerBlue;
            label23.AutoSize = false;
            label23.Dock = DockStyle.Fill;

            //Label - 24
            label24.BackColor = Color.CornflowerBlue;
            label24.AutoSize = false;
            label24.Dock = DockStyle.Fill;

            //Label - 25
            label25.BackColor = Color.CornflowerBlue;
            label25.AutoSize = false;
            label25.Dock = DockStyle.Fill;

            //Label - 26
            label26.BackColor = Color.CornflowerBlue;
            label26.AutoSize = false;
            label26.Dock = DockStyle.Fill;

            //Label - 27
            label27.BackColor = Color.CornflowerBlue;
            label27.AutoSize = false;
            label27.Dock = DockStyle.Fill;

            //Label - 28
            label28.BackColor = Color.CornflowerBlue;
            label28.AutoSize = false;
            label28.Dock = DockStyle.Fill;

            //Label - 29
            label29.BackColor = Color.CornflowerBlue;
            label29.AutoSize = false;
            label29.Dock = DockStyle.Fill;

            //Label - 30
            label30.BackColor = Color.CornflowerBlue;
            label30.AutoSize = false;
            label30.Dock = DockStyle.Fill;

            //Label - 31
            label31.BackColor = Color.CornflowerBlue;
            label31.AutoSize = false;
            label31.Dock = DockStyle.Fill;

            //Label - 32
            label32.BackColor = Color.CornflowerBlue;
            label32.AutoSize = false;
            label32.Dock = DockStyle.Fill;

            //Label - 33
            label33.BackColor = Color.CornflowerBlue;
            label33.AutoSize = false;
            label33.Dock = DockStyle.Fill;

            //Label - 34
            label34.BackColor = Color.CornflowerBlue;
            label34.AutoSize = false;
            label34.Dock = DockStyle.Fill;

            //Label - 35
            label35.BackColor = Color.CornflowerBlue;
            label35.AutoSize = false;
            label35.Dock = DockStyle.Fill;

            //Label - 36
            label36.BackColor = Color.CornflowerBlue;
            label36.AutoSize = false;
            label36.Dock = DockStyle.Fill;


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            ilktik.ForeColor = ilktik.BackColor;
            ikincitik.ForeColor = ikincitik.BackColor;

            ilktik = null;
            ikincitik = null;
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
            Gereken.score = Gereken.süre * 36 / Gereken.zorluk;
            MessageBox.Show("Oyunu kazandınız. Skorunuz: " + Gereken.score, "Tebrikler!!");
            yenidenoyna fr = new yenidenoyna();
            fr.Show();
            Hide();
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
            label37.Text = Gereken.süre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gereken.süre = 200;
            AltiAltilik fr = new AltiAltilik();
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

