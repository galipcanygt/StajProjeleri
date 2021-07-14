using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu_V1
{
    public partial class Form1 : Form
    {
        Image[] resim = {
            Properties.Resources.armut,
            Properties.Resources.elma,
            Properties.Resources.karpuz,
            Properties.Resources.kayısı,
            Properties.Resources.kiraz,
            Properties.Resources.kivi,
            Properties.Resources.muz,
            Properties.Resources.çilek
            
        };
        Image[] resimler =
        {
            Properties.Resources.bow,
            Properties.Resources.clock,
            Properties.Resources.crossbow,
            Properties.Resources.diaboots,
            Properties.Resources.diachestplate,
            Properties.Resources.diahelmet,
            Properties.Resources.diahoe,
            Properties.Resources.dialeggins,
            Properties.Resources.diapikaxe,
            Properties.Resources.diashowel,
            Properties.Resources.diasword,
            Properties.Resources.diaxe,
            Properties.Resources.enderpearl,
            Properties.Resources.eyeofender,
            Properties.Resources.fishingrod,
            Properties.Resources.flintandsteel,
            Properties.Resources.goldenapple,
            Properties.Resources.trident           
        };
        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        int[] altiliyedili = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17 };
        int[] siralama = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
        PictureBox ilkkutu;
        int ilkindeks, deneme , bulunan,sirası,ikincitik;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PictureBox picture = new PictureBox();
            //picture.SetBounds(20, 20, 100, 100);//location ve size belirleme
            //this.Controls.Add(picture);
            //picture.Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
            //picture.SizeMode = PictureBoxSizeMode.StretchImage;
            ResimleriKariştir();
            ResimleriKariştir1();
        }

        private void ResimleriKariştir()
        {
            Random say = new Random();
            for (int i = 0; i < 16; i++)
            {
                int sayi = say.Next(16);
                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }
        private void ResimleriKariştir1()
        {
            Random say = new Random();
            for (int i = 0; i < 36; i++)
            {
                int sayi = say.Next(36);
                int gecici = altiliyedili[i];
                altiliyedili[i] = altiliyedili[sayi];
                altiliyedili[sayi] = gecici;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Gereken.boyut = 4;
                int boyut = Gereken.boyut * Gereken.boyut;
                int sütun = 20, satır = 20;
                PictureBox[] picture = new PictureBox[boyut];
                int sayac = 0;
                for (int pi = 0; pi < boyut; pi++)
                {
                    picture[pi] = new PictureBox();
                    picture[pi].Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                    picture[pi].Name = "resim" + pi.ToString();
                    picture[pi].SetBounds(satır, sütun, 120, 120);//location ve size belirleme
                    this.Controls.Add(picture[pi]);
                    picture[pi].SizeMode = PictureBoxSizeMode.StretchImage;
                    picture[pi].Click += picturebox_Click;
                    satır += 140;
                    sayac++;
                    if (sayac % 4 == 0)
                    {
                        satır = 20;
                        sütun += 140;
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                Gereken.boyut = 6;
                int boyut = Gereken.boyut * Gereken.boyut;
                int sütun = 15, satır = 15;
                PictureBox[] picture = new PictureBox[boyut];
                int sayac = 0;
                for (int pi = 0; pi < boyut; pi++)
                {
                    picture[pi] = new PictureBox();
                    picture[pi].Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                    picture[pi].Name = "resim" + pi.ToString();
                    picture[pi].SetBounds(satır, sütun, 120, 120);//location ve size belirleme
                    this.Controls.Add(picture[pi]);
                    picture[pi].SizeMode = PictureBoxSizeMode.StretchImage;
                    picture[pi].Click += picturebox1_Click; 
                    satır += 130;
                    sayac++;
                    if (sayac % 6 == 0)
                    {
                        satır = 15;
                        sütun += 130;
                    }
                }
            }
            else
            {
                MessageBox.Show("Boyut boş bırakılamaz!!!");
            }
            ResimleriKariştir();
            button1.Visible = false;
            label1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }

        private void picturebox1_Click(object sender, EventArgs e)
        {
            PictureBox kutualti = (PictureBox)sender;
            int kutuNo = int.Parse(kutualti.Name.Substring(5));
            int indeksNo = altiliyedili[kutuNo];
            kutualti.Image = resimler[indeksNo];
            kutualti.Refresh();

            if (ikincitik == 0)
            {
                if (ilkkutu == null)
                {
                    ilkkutu = kutualti;
                    ilkindeks = indeksNo;
                    deneme++;
                    sirası = kutuNo;
                }
                else
                {
                    ikincitik++;
                    System.Threading.Thread.Sleep(200);// bu olay aynı olan resimlerin birkaç milisaniye sonra kapanmasını sağlar hemen kapatmaz
                    if (sirası != kutuNo)
                    {
                        if (ilkindeks == indeksNo)
                        {
                            bulunan++;
                            ilkkutu.Visible = false;
                            kutualti.Visible = false;
                            if (bulunan == 18)
                            {
                                MessageBox.Show("Tebrikler.." + deneme + ". denemede buldunuz.");
                                bulunan = 0;
                                deneme = 0;
                                foreach (Control kontrol in Controls)
                                {
                                    kontrol.Visible = true;
                                }
                                ResimleriKariştir();
                                Close();
                            }
                            ikincitik = 0;
                            ilkkutu = null;
                        }
                        else
                        {
                            ilkkutu.Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                            kutualti.Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                            ilkkutu = null;
                            ikincitik = 0;
                        }
                    }
                    else
                    {
                        ilkkutu = kutualti;
                        ilkindeks = indeksNo;
                        ikincitik = 0;
                    }
            }
        }
    }

        private void picturebox_Click(object sender, EventArgs e)
        {
            PictureBox kutu = (PictureBox)sender;
            int kutuNo = int.Parse(kutu.Name.Substring(5));
            int indeksNo = indeksler[kutuNo];
            kutu.Image = resim[indeksNo];
            kutu.Refresh();

            if (ikincitik == 0)
            {
                if (ilkkutu == null)
                {
                    ilkkutu = kutu;
                    ilkindeks = indeksNo;
                    deneme++;
                    sirası = kutuNo;
                }
                else
                {
                    ikincitik++;
                    System.Threading.Thread.Sleep(200);// bu olay aynı olan resimlerin birkaç milisaniye sonra kapanmasını sağlar hemen kapatmaz
                    if (sirası != kutuNo)
                    {
                        if (ilkindeks == indeksNo)
                        {
                            bulunan++;
                            ilkkutu.Visible = false;
                            kutu.Visible = false;
                            if (bulunan == 8)
                            {
                                MessageBox.Show("Tebrikler.." + deneme + ". denemede buldunuz.");
                                bulunan = 0;
                                deneme = 0;
                                foreach (Control kontrol in Controls)
                                {
                                    kontrol.Visible = true;
                                }
                                ResimleriKariştir();
                                Close();
                            }
                            ikincitik = 0;
                            ilkkutu = null;
                        }
                        else
                        {
                            ilkkutu.Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                            kutu.Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                            ilkkutu = null;
                            ikincitik = 0;
                        }
                    }
                    else
                    {
                        ilkkutu = kutu;
                        ilkindeks = indeksNo;
                        ikincitik = 0;
                    }
                }
            }
        }
    }
}
