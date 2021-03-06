using System;
using System.Drawing;
using System.Windows.Forms;

namespace HafızaOyunu_V2
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

        };   //4x4
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
        };   //6x6
        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };   //4x4
        int[] altiliyedili = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17 };//6x6
        int kökdinozor = 0, gehgehdino, gecici, sirası;
        int bulunan = 0, ilkindeks, ikincitik = 0;
        PictureBox ilkkutu;

        private void ResimleriKariştir()
        {
            Random say = new Random();
            for (int i = 0; i < gehgehdino; i++)
            {
                int sayi = say.Next(gehgehdino);
                if (gehgehdino == 16)
                {
                    gecici = indeksler[i];
                    indeksler[i] = indeksler[sayi];
                    indeksler[sayi] = gecici;
                }
                else
                {
                    gecici = altiliyedili[i];
                    altiliyedili[i] = altiliyedili[sayi];
                    altiliyedili[sayi] = gecici;
                }

            }
        }

        private void BoyutAyarı()
        {
            if (DörtRadio.Checked)
            {
                kökdinozor = 4;
            }
            else if (AltıRadio.Checked)
            {
                kökdinozor = 6;
            }
            else
            {
                MessageBox.Show("Boyut Seçiniz!!");
            }
            gehgehdino = kökdinozor * kökdinozor;
        }

        private void PictureboxYapıcı()
        {
            PictureBox[] picture = new PictureBox[gehgehdino];
            int sütun = 10, satır = 10, sayac = 0;
            for (int pi = 0; pi < gehgehdino; pi++)
            {
                picture[pi] = new PictureBox();
                picture[pi].Image = Image.FromFile("C:\\Users\\galip\\OneDrive\\Resimler\\iii.png");
                picture[pi].Name = "resim" + pi.ToString();
                picture[pi].SetBounds(satır, sütun, 110, 110);//location ve size belirleme
                this.Controls.Add(picture[pi]); // forma eklemesini yapar
                picture[pi].SizeMode = PictureBoxSizeMode.StretchImage;  // resimleri kutucuğa doldurur
                picture[pi].Click += picturebox_Click;
                satır += 115;
                sayac++;
                if (sayac % kökdinozor == 0)
                {
                    satır = 10;
                    sütun += 115;
                }
            }
        }

        private void EslesmeAlgoritması(PictureBox kutualti, int indeksNo, int kutuNo)
        {
            if (ikincitik == 0)  // aynı anda birden çok resme basmaması için.
            {
                if (ilkkutu == null)    //ilk seçim burda.
                {
                    ilkkutu = kutualti;
                    ilkindeks = indeksNo;
                    sirası = kutuNo;
                    kutualti.Enabled = false;
                }
                else        // ikinci tıklanan burda
                {
                    ikincitik++;
                    System.Threading.Thread.Sleep(200);// bu olay resimlerin birkaç milisaniye sonra kapanmasını sağlar hemen kapatmaz
                                                       //if (sirası != kutuNo)
                                                       //{
                    if (ilkindeks == indeksNo) // bu kısım resimlerin aynı olup olmadıklarını kontrol etmek için
                    {
                        bulunan++;
                        ilkkutu.Visible = false;
                        kutualti.Visible = false;
                        if (bulunan == gehgehdino / 2)      //bu kısım oyunu kazandığını kontrol etmek için
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
                        kutualti = ilkkutu;
                        kutualti.Enabled = true;
                        ilkkutu = null;
                        ikincitik = 0;

                    }
                    //}
                    //else            // bu kısım resmin ikinci kez seçilmesini önlemek için
                    //{
                    //    ilkkutu = kutualti;
                    //    ilkindeks = indeksNo;
                    //    ikincitik = 0;
                    //}
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            BoyutAyarı();
            PictureboxYapıcı();
            ResimleriKariştir();
            if (kökdinozor != 0)
            {
                BtnBasla.Visible = false;
                BoyutLabel.Visible = false;
                DörtRadio.Visible = false;
                AltıRadio.Visible = false;
            }
        }
        private void picturebox_Click(object sender, EventArgs e)
        {
            PictureBox kutualti = (PictureBox)sender;
            int kutuNo = int.Parse(kutualti.Name.Substring(5)); // resimmin hangi pictureboxta olduğunu anlamak için
            int indeksNo;
            if (gehgehdino == 36)     // burdaki if hangi dizinin kullanılıcağını söyler
            {
                indeksNo = altiliyedili[kutuNo];
                kutualti.Image = resimler[indeksNo];
            }
            else
            {
                indeksNo = indeksler[kutuNo];
                kutualti.Image = resim[indeksNo];
            }
            kutualti.Refresh();
            EslesmeAlgoritması(kutualti, indeksNo, kutuNo);

        }
    }
}
