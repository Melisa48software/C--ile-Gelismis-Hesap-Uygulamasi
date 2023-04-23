using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200601035_Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void mtbTemizle()
        {
            mtbBaslangic.Clear();
            mtbBitis.Clear();
            mtbBaslangic.Focus();
        }
        void lvTemizle()
        {
            lvTekSayilar.Items.Clear();
            lvCiftSayilar.Items.Clear();
            lvAsalSayilar.Items.Clear();
            lvMukemmelSayilar.Items.Clear();
        }
        public bool AsalSayiKontrol(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool MukemmelSayiKontrol(int sayi)
        {
            int mukemmelSayi = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    mukemmelSayi += i;
                }
            }
            if (mukemmelSayi == sayi)
            {
                return true;
            }
            return false;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lvTemizle();

            int baslangic, bitis;
            double tekToplam = 0, ciftToplam = 0, asalToplam = 0, mukemmelToplam = 0;
            double tekCarpim = 1, ciftCarpim = 1, asalCarpim = 1, mukemmelCarpim = 1;
            bool hatakontrol = false;
            try
            {
                baslangic = Convert.ToInt32(mtbBaslangic.Text);
                bitis = Convert.ToInt32(mtbBitis.Text);
            }
            catch (Exception)
            {
                notifyIcon1.ShowBalloonTip(2000, "İşlem Başarısız", "Hesaplama işlemi tamamlanamadı. Lütfen sayı girişlerini düzeltiniz", ToolTipIcon.Error);
                hatakontrol = true;
            }
            if(hatakontrol== false)
            {
                baslangic = Convert.ToInt32(mtbBaslangic.Text);
                bitis = Convert.ToInt32(mtbBitis.Text);
                for (int i = baslangic; i <= bitis; i++)
                {
                    if (i % 2 == 1)
                    {
                        tekToplam += i;
                        tekCarpim *= i;
                        lvTekSayilar.Items.Add(i.ToString());
                    }
                    else
                    {
                        ciftToplam += i;
                        ciftCarpim *= i;
                        lvCiftSayilar.Items.Add(i.ToString());
                    }

                    if (AsalSayiKontrol(i) == true)
                    {
                        asalToplam += i;
                        asalCarpim *= i;
                        lvAsalSayilar.Items.Add(i.ToString());
                    }

                    if (MukemmelSayiKontrol(i) == true)
                    {
                        mukemmelToplam += i;
                        mukemmelCarpim *= i;
                        lvMukemmelSayilar.Items.Add(i.ToString());
                    }
                }
                lvTekSayilar.Items.Add("Tek sayıların toplamı:" + tekToplam.ToString());
                lvTekSayilar.Items.Add("Tek sayıların çarpımı:" + tekCarpim.ToString());
                lvCiftSayilar.Items.Add("Çift sayıların toplamı:" + ciftToplam.ToString());
                lvCiftSayilar.Items.Add("Çift sayıların çarpımı:" + ciftCarpim.ToString());
                lvAsalSayilar.Items.Add("Asal sayıların toplamı:" + asalToplam.ToString());
                lvAsalSayilar.Items.Add("Asal sayıların çarpımı:" + asalCarpim.ToString());
                lvMukemmelSayilar.Items.Add("Mükemmel sayıların toplamı:" + mukemmelToplam.ToString());
                lvMukemmelSayilar.Items.Add("Mükemmel sayıların çarpımı:" + mukemmelCarpim.ToString());
            }
            mtbTemizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(2000, "Hoşgeldiniz", "Hesaplanacak sayıları girin.", ToolTipIcon.None);
        }

        private void lvTekSayilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
