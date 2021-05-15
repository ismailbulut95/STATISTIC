using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace olasilikOdev
{
    public partial class dagilim : DevExpress.XtraEditors.XtraUserControl
    {
        public dagilim()
        {
            InitializeComponent();
        }

        public double toplam = 0;
        public double[] sayilar;
        public int sayac = 0;
        

        private void dagilim_Load(object sender, EventArgs e)
        {
            sayilab.Visible = false;
            value.Visible = false;
            ekle.Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sayilar = new double[Convert.ToInt32(number.Text)];
            simpleButton1.Enabled = false;
            number.Enabled = false;
            sayilab.Visible = true;
            value.Visible = true;
            ekle.Visible = true;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            sayilar[sayac] = Convert.ToDouble(value.Text);
            toplam = toplam + Convert.ToDouble(sayilar[sayac]);
            value.Text = null;
            value.Focus();
            sayac++;


            if (sayac == Convert.ToInt32(number.Text))
            {

                sayilab.Visible = false;
                value.Visible = false;
                ekle.Visible = false;

                KatsayiHesaplama();
              

            }
           

               


        }

        private double KatsayiHesaplama()
        {
            double ortalama = 0;
            double adet = Convert.ToDouble(number.Text);

            ortalama = toplam / adet;

            double sonOrtalama = 0;
            double sontoplam = 0;
            double[] farkDizisi = new double[Convert.ToInt32(adet)];
            for (int i = 0; i < farkDizisi.Length; i++)
            {
                double fark = sayilar[i] - ortalama;
                farkDizisi[i] = Math.Pow(fark, 2);
                sontoplam = farkDizisi[i] + sontoplam;
            }
            sonOrtalama = sontoplam / (adet - 1);

            double standartSapma = Math.Sqrt(sonOrtalama);
            double a = (standartSapma / ortalama) * 100;


            double sonuc = a;
            degsk.Text = sonuc.ToString();

            double farkToplam = 0;
            double farkOrtalama = 0;
            double farkk=0;
           
            for (int i = 0; i < farkDizisi.Length; i++)
            {
                farkk= sayilar[i] - ortalama;
               
                if (farkk < 0)
                {
                    farkk = farkk * -1;
                }

                farkDizisi[i] = farkk;

                farkToplam += farkDizisi[i];
            }
          
            farkOrtalama = farkToplam / adet;

            omsLab.Text = farkOrtalama.ToString();

            double q1 = (adet + 1) * 0.25;

            double kucukDeger = Math.Floor(q1);
            double buyukDeger = Math.Ceiling(q1);
            Array.Sort(sayilar);
            
                double sonuc3 = (sayilar[Convert.ToUInt32(kucukDeger - 1)] + ( (sayilar[Convert.ToUInt32(buyukDeger - 1)] - sayilar[Convert.ToUInt32(kucukDeger - 1)])*0.75));

            q1Lab.Text = sonuc3.ToString();

            double q3 = (adet + 1) * 0.75;

            kucukDeger = Math.Floor(q3);
           buyukDeger = Math.Ceiling(q3);

            double sonuc4 = sayilar[Convert.ToUInt32(buyukDeger - 1)] + (0.25 * (sayilar[Convert.ToUInt32(buyukDeger - 1)] - sayilar[Convert.ToUInt32(kucukDeger - 1)]));

            q3Lab.Text=sonuc4.ToString();


            sonOrtalama = 0;
            sontoplam = 0;
            
            for (int i = 0; i < farkDizisi.Length; i++)
            {
                double fark = sayilar[i] - ortalama;
                farkDizisi[i] = Math.Pow(fark, 2);
                sontoplam = farkDizisi[i] + sontoplam;
            }
            sonOrtalama = sontoplam / (adet - 1);

            standartSapma = Math.Sqrt(sonOrtalama);
            stdsapma.Text = standartSapma.ToString();
            varyansLab.Text = (Math.Pow(standartSapma, 2).ToString());
            /*
            for (int i = 0; i < farkDizisi.Length; i++)
            {
                farkDizisi[i] = sayilar[i] - ortalama;
            }

            double sonToplam = 0;
            double[] kareDizisi = new double[Convert.ToInt32(adet)];
            for (int i = 0; i < kareDizisi.Length; i++)
            {
                kareDizisi[i] = Math.Pow(farkDizisi[i], 2);
                sonToplam += kareDizisi[i];
            }
            sonOrtalama = sonToplam / adet;

            varyansLab.Text = sonOrtalama.ToString();*/
            return sonuc;

            
        }

    }
}
