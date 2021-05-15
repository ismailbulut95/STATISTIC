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
    public partial class freqSerie : DevExpress.XtraEditors.XtraUserControl
    {
        public freqSerie()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            sayilab.Visible = false;
            value.Visible = false;
            ekle.Visible = false;
        }
        public int[] sayilar;
        public int sayac = 0;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sayilar = new int[Convert.ToInt32(number.Text)];
            simpleButton1.Enabled = false;
            number.Enabled = false;
            sayilab.Visible = true;
            value.Visible = true;
            ekle.Visible = true;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            sayilar[sayac] = Convert.ToInt32(value.Text);
            sayac++;
            value.Text = null;
            value.Focus();

            if (sayac == Convert.ToInt32(number.Text))
            {

                sayilab.Visible = false;
                value.Visible = false;
                ekle.Visible = false;

                Array.Sort(sayilar);
                foreach (int sayi in sayilar)
                    dogal.Items.Add(sayi);


                int  j, k,l,sayacc=0;
                for (j = 0; j < Convert.ToInt32(number.Text); j++)
                {
                    for (k = 0; k < Convert.ToInt32(number.Text); k++)
                    {
                        if (sayilar[j] == sayilar[k])
                        {
                            for (l = 0; l < j; l++)
                            {
                                if (sayilar[l] == sayilar[j])
                                    sayacc = -1;
                            }
                            sayacc++;
                        }
                    }
                    if (sayacc != 0)
                        sonuc.Items.Add(sayilar[j] + " sayısı " + sayacc + " kez tekrar edildi.");
                    sayacc = 0;
                }

            }


        }
    }
}
