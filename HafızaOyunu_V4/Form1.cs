using System;
using System.Drawing;
using System.Windows.Forms;

namespace HafızaOyunu_V2
{
    public partial class Form1 : Form
    {
        private Image[] dörtResimleri = {
            Properties.Resources.armut,
            Properties.Resources.elma,
            Properties.Resources.karpuz,
            Properties.Resources.kayısı,
            Properties.Resources.kiraz,
            Properties.Resources.kivi,
            Properties.Resources.muz,
            Properties.Resources.çilek
        };   //4x4

        private Image[] altiResimleri =
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
        };   //6x6

        private int[] dörtdizisi = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };   //4x4
        private int[] altiDizisi = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17 };//6x6
        private int secilecekBoyut = 0, toplamKutu, gecici;
        private int bulunan = 0, ilkindeks, ikincitik = 0;
        private PictureBox ilkkutu;

        private void ResimleriKaristir()
        {
            Random say = new Random();
            for (int i = 0; i < toplamKutu; i++)
            {
                int sayi = say.Next(toplamKutu);
                if (toplamKutu == 16)
                {
                    gecici = dörtdizisi[i];
                    dörtdizisi[i] = dörtdizisi[sayi];
                    dörtdizisi[sayi] = gecici;
                }
                else
                {
                    gecici = altiDizisi[i];
                    altiDizisi[i] = altiDizisi[sayi];
                    altiDizisi[sayi] = gecici;
                }
            }
        }

        private void BoyutAyari()
        {
            if (DörtRadio.Checked)
            {
                secilecekBoyut = 4;
            }
            else if (AltiRadio.Checked)
            {
                secilecekBoyut = 6;
            }
            else
            {
                MessageBox.Show("Boyut Seçiniz!!");
            }
            toplamKutu = secilecekBoyut * secilecekBoyut;
        }

        private void PictureboxYapıcı()
        {
            PictureBox[] picture = new PictureBox[toplamKutu];
            int sütun = 10, satir = 10, sayac = 0;
            for (int pi = 0; pi < toplamKutu; pi++)
            {
                picture[pi] = new PictureBox();
                picture[pi].Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                picture[pi].Name = "resim" + pi.ToString();
                picture[pi].SetBounds(satir, sütun, 110, 110);//location ve size belirleme
                this.Controls.Add(picture[pi]); // forma eklemesini yapar
                picture[pi].SizeMode = PictureBoxSizeMode.StretchImage;  // resimleri kutucuğa doldurur
                picture[pi].Click += picturebox_Click;
                satir += 115;
                sayac++;
                if (sayac % secilecekBoyut == 0)
                {
                    satir = 10;
                    sütun += 115;
                }
            }
        }

        private void EslesmeAlgoritmasi(PictureBox kutualti, int indeksNo)
        {
            if (ikincitik == 0)  // aynı anda birden çok resme basmaması için.
            {
                if (ilkkutu == null)    //ilk seçim burda.
                {
                    ilkkutu = kutualti;
                    ilkindeks = indeksNo;
                    kutualti.Enabled = false;
                }
                else        // ikinci tıklanan burda
                {
                    ikincitik++;
                    System.Threading.Thread.Sleep(200);// bu olay resimlerin birkaç milisaniye sonra kapanmasını sağlar hemen kapatmaz
                    if (ilkindeks == indeksNo) // bu kısım resimlerin aynı olup olmadıklarını kontrol etmek için
                    {
                        bulunan++;
                        ilkkutu.Visible = false;
                        kutualti.Visible = false;
                        if (bulunan == toplamKutu / 2)      //bu kısım oyunu kazandığını kontrol etmek için
                        {
                            MessageBox.Show("Tebrikler..");
                            Close();
                        }
                        ikincitik = 0;
                        ilkkutu = null;
                    }
                    else    //bu kısım resimler aynı değilse başlangıç hallerine döndürmek için
                    {
                        ilkkutu.Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                        kutualti.Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                        ilkkutu.Enabled = true;
                        ilkkutu = null;
                        ikincitik = 0;
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            BoyutAyari();
            PictureboxYapıcı();
            ResimleriKaristir();
            if (secilecekBoyut != 0)
            {
                BtnBasla.Visible = false;
                BoyutLabel.Visible = false;
                DörtRadio.Visible = false;
                AltiRadio.Visible = false;
            }
        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            PictureBox kutualti = (PictureBox)sender;
            int kutuNo = int.Parse(kutualti.Name.Substring(5)); // resimmin hangi pictureboxta olduğunu anlamak için
            int indeksNo;
            if (toplamKutu == 36)     // burdaki if hangi dizinin kullanılıcağını söyler
            {
                indeksNo = altiDizisi[kutuNo];
                kutualti.Image = altiResimleri[indeksNo];
            }
            else
            {
                indeksNo = dörtdizisi[kutuNo];
                kutualti.Image = dörtResimleri[indeksNo];
            }
            kutualti.Refresh();
            EslesmeAlgoritmasi(kutualti, indeksNo);
        }
    }
}