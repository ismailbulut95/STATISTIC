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
    public partial class basicRand : DevExpress.XtraEditors.XtraUserControl
    {
        public basicRand()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            sayi.Items.Clear();
            dogal.Items.Clear();
            int x, max, min, uretilen;
            x = Convert.ToInt32(value.Text);
            max = Convert.ToInt32(maxGelen.Text);
            min = Convert.ToInt32(minGelen.Text);
            Random rand = new Random();
            int[] sayilar = new int[x];

            try
            {
                if (x != 0)
                {
                    if ((max - min) + 1 <= x)
                    {
                        for (int i = 0; i < x; i++)
                        {
                        
                            uretilen = rand.Next(min, max);
                            sayilar[i] = uretilen;
                            dogal.Items.Add(uretilen.ToString());
                            
                        }
                        Array.Sort(sayilar);

                        foreach (int eklenecek in sayilar)
                        sayi.Items.Add(eklenecek.ToString());



                    }
                    else if ((max - min) + 1 > x)
                    {
                        
                        Random tekrarsızRastgele = new Random();
                        int i = 0;
                        while (i <= x - 1)
                        {
                            int sayi2 = tekrarsızRastgele.Next(min, max);
                            if (sayilar.Contains(sayi2))
                                continue;
                            sayilar[i] = sayi2;
                            i++;
                            dogal.Items.Add(sayi2.ToString());
                        }
                        Array.Sort(sayilar);
                        foreach (int sayi2 in sayilar)
                            sayi.Items.Add(sayi2.ToString());
                    }

                }
                else
                    MessageBox.Show("Lütfen 0 dan Farklı Bir Sayı Giriniz!");

            }
            catch {

                MessageBox.Show("Max Değerleri İçerisinde 0 Değeri Kullanılamaz!");
            }
        }
    }
}
