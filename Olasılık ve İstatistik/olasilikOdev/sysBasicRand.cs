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
    public partial class sysBasicRand : DevExpress.XtraEditors.XtraUserControl
    {
        public sysBasicRand()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dogal.Items.Clear();
            double N, n, k, a = 0;
            Random rastgele = new Random(); 
            N = Convert.ToInt32(bigNValue.Text);
            n = Convert.ToInt32(nValue.Text);
            k = N/n;
            kNorm.Text = k.ToString();
            k=Math.Floor(k);
            kYuv.Text = k.ToString();
            a = rastgele.Next(0, Convert.ToInt32(k));

            asayi.Text = a.ToString();

            if (n != 0)
            {
                dogal.Items.Add(a);
                for (int i = 1; i < n; i++)
                {
                    dogal.Items.Add(a+=k);
                }
            }

            else
               MessageBox.Show("Örneklem 0 Olarak Girilemez! Lütfen Farklı Bir Sayı Giriniz!");
         
        }
    }
}
