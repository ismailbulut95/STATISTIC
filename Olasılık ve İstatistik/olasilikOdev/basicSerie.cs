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
    public partial class basicSerie : DevExpress.XtraEditors.XtraUserControl
    {
        public basicSerie()
        {
            InitializeComponent();
        }

        public int[] sayilar;
        public int hedef = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sayilar = new int[Convert.ToInt32(number.Text)];
            hedef = Convert.ToInt32(number.Text);
            simpleButton1.Enabled = false;
            number.Enabled = false;
            sayilab.Visible = true;
            value.Visible = true;
            ekle.Visible = true;
            sayac = 0;
 
        }

        public int sayac;


        void islemler() {


        }
        private void ekle_Click(object sender, EventArgs e)
        {

            sayilar[sayac] = Convert.ToInt32(value.Text);
            value.Text = "";
            value.Focus();
            sayac++;

            if (sayac == hedef) {

                sayilab.Visible = false;
                value.Visible = false;
                ekle.Visible = false;

                Array.Sort(sayilar);
                foreach (int sayi in sayilar)
                    dogal.Items.Add(sayi);
                    

            }
            
                
              
          
            

        }

        private void value_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void basicSerie_Load(object sender, EventArgs e)
        {
            sayilab.Visible = false;
            value.Visible = false;
            ekle.Visible = false;
        }
    }
}
