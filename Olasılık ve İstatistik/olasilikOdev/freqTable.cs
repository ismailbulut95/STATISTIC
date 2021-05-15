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
    public partial class freqTable : DevExpress.XtraEditors.XtraUserControl
    {
        public freqTable()
        {
            InitializeComponent();
        }

        private void freqTable_Load(object sender, EventArgs e)
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
                /* foreach (int sayi in sayilar)
                     dogal.Items.Add(sayi);*/

                int min, max ,r;

                min = sayilar.Min();
                max = sayilar.Max();

                r = max - min;
                rLab.Text = r.ToString();

                double h, k;

                k = Math.Sqrt(Convert.ToDouble(number.Text));
                k = Math.Ceiling(k);

                h = r / k;
                hLab.Text = h.ToString();
                h = Math.Ceiling(h);

                double altSinifSiniriSayi,ustSinifSiniriSayi,limitUstDeger,limitAltDeger = sayilar.Min();

                double[] sinifAltLimit = new double[Convert.ToInt32(k)];
                sinifAltLimit[0] = limitAltDeger;
                limitAlt.Items.Add(limitAltDeger);

                for (int i = 1; i <= k - 1; i++)
                {
                    limitAltDeger += Convert.ToInt32(h);
                    limitAlt.Items.Add(limitAltDeger);
                    sinifAltLimit[i] = limitAltDeger;
                }

                double[] sinifUstLimit = new double[Convert.ToInt32(k)];
                sinifUstLimit[0] = sinifAltLimit[1] - 1;
                limitUstDeger = sinifUstLimit[0];
                 limitUst.Items.Add(sinifUstLimit[0]);
                for (int i = 1; i <= k - 1; i++)
                {
                    limitUstDeger += Convert.ToInt32(h);
                    limitUst.Items.Add(limitUstDeger);
                    sinifUstLimit[i] = limitUstDeger;
                }
                /*       */
                double[] altSinifSiniri = new double[Convert.ToInt32(k)];
                altSinifSiniri[0] = sinifAltLimit[0] - 0.5;
                altSinifSiniriSayi = altSinifSiniri[0];
                
                sinirAlt.Items.Add(altSinifSiniriSayi);
                for (int i = 1; i <= k - 1; i++)
                {
                    altSinifSiniriSayi += Convert.ToInt32(h);
                    sinirAlt.Items.Add(altSinifSiniriSayi);
                    altSinifSiniri[i] = altSinifSiniriSayi;
                }
                double[] ustSinifSiniri = new double[Convert.ToUInt32(k)];
                ustSinifSiniri[0] = sinifUstLimit[0] + 0.5;
                ustSinifSiniriSayi = ustSinifSiniri[0];

                sinirUst.Items.Add(ustSinifSiniriSayi);

                for (int i = 1; i <= k - 1; i++)
                {
                    ustSinifSiniriSayi += Convert.ToInt32(h);
                    sinirUst.Items.Add(ustSinifSiniriSayi);
                    ustSinifSiniri[i] = ustSinifSiniriSayi;
                }

                /* */
                int sayacc;
                int[] sinifFrekansi = new int[Convert.ToInt32(k)];
                for (int i = 0; i <= k - 1; i++)
                {
                    double ilk = altSinifSiniri[i];
                    double son = ustSinifSiniri[i];
                    sayacc = 0;
                    for (int j = 0; j < sayilar.Length; j++)
                    {
                        if (ilk <= sayilar[j] & son >= sayilar[j])
                        {
                            sayacc++;
                        }
                        sinifFrekansi[i] = sayacc;

                    }
                   frekansAlt.Items.Add(sinifFrekansi[i]);
                }

                /*    */

                double[] sinifOrtaNokta = new double[Convert.ToUInt32(k)];
                for (int i = 0; i <= k - 1; i++)
                {
                    sinifOrtaNokta[i] = (Convert.ToDouble(sinifAltLimit[i]) + Convert.ToDouble(sinifUstLimit[i])) / 2;
                    ortaNokta.Items.Add(sinifOrtaNokta[i]);
                }

                /*    */

                double[] eklenikFrekans = new double[Convert.ToInt32(k)];
                eklenikFrekans[0] = sinifFrekansi[0];
                eklenikAlt.Items.Add(eklenikFrekans[0]);
                for (int i = 1; i <= k - 1; i++)
                {
                    eklenikFrekans[i] = eklenikFrekans[i - 1] + sinifFrekansi[i];
                    eklenikAlt.Items.Add(eklenikFrekans[i]);

                }

                /*          */

                double[] oransalFrekans = new double[Convert.ToInt32(k)];
                for (int i = 0; i <= k - 1; i++)
                {
                    oransalFrekans[i] = Convert.ToDouble(sinifFrekansi[i]) / Convert.ToDouble(number.Text);
                    oransalAlt.Items.Add(Math.Round(oransalFrekans[i], 2));
                }

                /*     */

                double[] oransalEklenikFrekans = new double[Convert.ToInt32(k)];
                for (int i = 0; i <= k - 1; i++)
                {
                    oransalEklenikFrekans[i] = Convert.ToDouble(eklenikFrekans[i]) / Convert.ToDouble(number.Text);
                    orsekAlt.Items.Add(Math.Round(oransalEklenikFrekans[i], 2));
                }

            }
           

        }

        public void sinifLimit() {




        }
    }
}
