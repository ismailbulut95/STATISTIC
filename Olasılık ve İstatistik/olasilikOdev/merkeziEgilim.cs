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
    public partial class merkeziEgilim : DevExpress.XtraEditors.XtraUserControl
    {
        public merkeziEgilim()
        {
            InitializeComponent();
        }

        public int[] sayilar;
        public int sayac = 0;
        private void merkeziEgilim_Load(object sender, EventArgs e)
        {
            sayilab.Visible = false;
            value.Visible = false;
            ekle.Visible = false;
        }
        public double mod;
        public int toplam = 0;
        private void ekle_Click(object sender, EventArgs e)
        {
            sayilar[sayac] = Convert.ToInt32(value.Text);
            toplam = toplam + Convert.ToInt32(value.Text);
            sayac++;
            value.Text = null;
            value.Focus();

            if (sayac == Convert.ToInt32(number.Text))
            {

                sayilab.Visible = false;
                value.Visible = false;
                ekle.Visible = false;
                

                int adet=Convert.ToInt32(number.Text);
                int sayi;
                double ort = 0;
                int modControl = 0;
                int aklimda = 0;

               
                ort = Convert.ToDouble(toplam) / Convert.ToDouble(adet);
                if (adet % 2 == 0)
                {
                    double medyan1, medyan2, medyan;

                    Array.Sort(sayilar);

                    medyan2 = sayilar[adet / 2];
                    medyan1 = sayilar[(adet / 2) - 1];
                    medyan = (medyan1 + medyan2) / 2;
                    Array.Sort(sayilar);
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        Console.Write(sayilar[i] + " ");
                    }
                    medyanT.Text=medyan.ToString();
                }
                else
                {
                    int medyan;

                    Array.Sort(sayilar);
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        Console.Write(sayilar[i] + " ");
                    }
                    medyan = sayilar[(adet - 1) / 2];
                    medyanT.Text = medyan.ToString();
                }

                for (int i = 0; i < adet; i++)
                {


                    for (int j = 0; j < adet; j++)
                    {
                        if (sayilar[i] == sayilar[j])
                        {
                            modControl++;
                        }
                    }
                    if (modControl > aklimda)
                    {
                        mod = sayilar[i];
                        aklimda = modControl;
                    }
                    modControl = 0;
                }
                modText.Text = mod.ToString();
                aritOrt.Text = ort.ToString();


            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sayilar = new int[Convert.ToInt32(number.Text)];
            simpleButton1.Enabled = false;
            number.Enabled = false;
            sayilab.Visible = true;
            value.Visible = true;
            ekle.Visible = true;
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
