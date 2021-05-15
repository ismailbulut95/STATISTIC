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
    public partial class permKom : DevExpress.XtraEditors.XtraUserControl
    {
        public permKom()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            komb.Text = combin(Convert.ToInt32(nVal.Text), Convert.ToInt32(rVal.Text)).ToString(); ;


            int n, r, per, fakt, fakt1;
            
            n = Convert.ToInt32(nVal.Text);
            r = Convert.ToInt32(rVal.Text);

            fakt = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }
            int number;
            number = n - r;
            fakt1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            per = fakt / fakt1;
            perr.Text = per.ToString();

        }

        static int combin(int a, int b)
        {
            int f1, f2, f3, y;
            f1 = fact(a);
            f2 = fact(b);
            f3 = fact(a - b);
            y = f1 / (f2 * f3);
            return y;
        }

        static int fact(int x)
        {
            int fx = 1, i;
            for (i = 1; i <= x; i++)
                fx = fx * i;
            return fx;
        }
    }
}
