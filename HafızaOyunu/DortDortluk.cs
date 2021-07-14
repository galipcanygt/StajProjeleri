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
    public partial class DortDortluk : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
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
        public DortDortluk()
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

            label17.Text = Gereken.süre.ToString();
            label18.Text = "Kalan Süreniz";
            
            //Label - 1
            label1.BackColor = Color.CornflowerBlue;
            label1.AutoSize = false;
            label1.Dock = DockStyle.Fill;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            //label1.Text = "c";

            // Label - 2 
            //label2.Text = "c";
            label2.BackColor = Color.CornflowerBlue;
            label2.AutoSize = false;
            label2.Dock = DockStyle.Fill;
            label2.TextAlign = ContentAlignment.MiddleCenter;


            // Label - 3
            //label3.Text = "c";
            label3.BackColor = Color.CornflowerBlue;
            label3.AutoSize = false;
            label3.Dock = DockStyle.Fill;
            label3.TextAlign = ContentAlignment.MiddleCenter;

            //Laberl - 4
            //label4.Text = "c";
            label4.BackColor = Color.CornflowerBlue;
            label4.AutoSize = false;
            label4.Dock = DockStyle.Fill;
            label4.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 5 
            //label5.Text = "c";
            label5.BackColor = Color.CornflowerBlue;
            label5.AutoSize = false;
            label5.Dock = DockStyle.Fill;
            label5.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 6
            //label6.Text = "c";
            label6.BackColor = Color.CornflowerBlue;
            label6.AutoSize = false;
            label6.Dock = DockStyle.Fill;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            
            //Label - 7
            //label7.Text = "c";
            label7.BackColor = Color.CornflowerBlue;
            label7.AutoSize = false;
            label7.Dock = DockStyle.Fill;
            label7.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 8
            //label8.Text = "c";
            label8.BackColor = Color.CornflowerBlue;
            label8.AutoSize = false;
            label8.Dock = DockStyle.Fill;
            label8.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 9
            //label9.Text = "c";
            label9.BackColor = Color.CornflowerBlue;
            label9.AutoSize = false;
            label9.Dock = DockStyle.Fill;
            label9.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 10
            //label10.Text = "c";
            label10.BackColor = Color.CornflowerBlue;
            label10.AutoSize = false;
            label10.Dock = DockStyle.Fill;
            label10.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 11
            //label11.Text = "c";
            label11.BackColor = Color.CornflowerBlue;
            label11.AutoSize = false;
            label11.Dock = DockStyle.Fill;
            label11.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 12
            //label12.Text = "c";
            label12.BackColor = Color.CornflowerBlue;
            label12.AutoSize = false;
            label12.Dock = DockStyle.Fill;
            label12.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 13
            //label13.Text = "c";
            label13.BackColor = Color.CornflowerBlue;
            label13.AutoSize = false;
            label13.Dock = DockStyle.Fill;
            label13.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 14
            //label14.Text = "c";
            label14.BackColor = Color.CornflowerBlue;
            label14.AutoSize = false;
            label14.Dock = DockStyle.Fill;
            label14.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 15
            //label15.Text = "c";
            label15.BackColor = Color.CornflowerBlue;
            label15.AutoSize = false;
            label15.Dock = DockStyle.Fill;
            label15.TextAlign = ContentAlignment.MiddleCenter;

            //Label - 16
            //label16.Text = "c";
            label16.BackColor = Color.CornflowerBlue;
            label16.AutoSize = false;
            label16.Dock = DockStyle.Fill;
            label16.TextAlign = ContentAlignment.MiddleCenter;

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
                    timer1.Interval = 1025;
                }
                else if (Gereken.zorluk == 3)
                {
                    timer1.Interval = 800;
                }
                else if (Gereken.zorluk==2)
                {
                    timer1.Interval = 500;

                }
                else if (Gereken.zorluk==1)
                {
                    timer1.Interval = 250;

                }

                CheckForWinner();

                if (ilktik.Text==ikincitik.Text)
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
            Gereken.score = Gereken.süre * 8 / Gereken.zorluk ;
            MessageBox.Show("Oyunu kazandınız. Skorunuz: " +Gereken.score, "Tebrikler!!");
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
            Gereken.süre=Gereken.süre-1;
            label17.Text = Gereken.süre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gereken.süre = 200;
            DortDortluk fr = new DortDortluk();
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

        private void timer4_Tick(object sender, EventArgs e)
        {

        }
    }
}
