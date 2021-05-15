using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace olasilikOdev
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void rastgeleOrnekleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
            mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
            basicRand basicRand = new basicRand();
            mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
            basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            basicRand.BringToFront(); // formu panel içinde en öne getirdik
          
            

        
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
                sysBasicRand basicRand = new sysBasicRand();
                mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
                basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
                basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
                basicRand.BringToFront(); // formu panel içinde en öne getirdik
         
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
            basicSerie basicRand = new basicSerie();
            mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
            basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            basicRand.BringToFront(); // formu panel içinde en öne getirdik
        
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
            freqSerie basicRand = new freqSerie();
            mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
            basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            basicRand.BringToFront(); // formu panel içinde en öne getirdik
           
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
            freqTable basicRand = new freqTable();
            mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
            basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            basicRand.BringToFront(); // formu panel içinde en öne getirdik
            
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
            merkeziEgilim basicRand = new merkeziEgilim();
            mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
            basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            basicRand.BringToFront(); // formu panel içinde en öne getirdik
           
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
            permKom basicRand = new permKom();
            mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
            basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            basicRand.BringToFront(); // formu panel içinde en öne getirdik
         
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            mainPanel.Controls.Clear(); // Panel'in içini temizliyoruz..
            dagilim basicRand = new dagilim();
            mainPanel.Controls.Add(basicRand); // panel1 içerisinde formu ekledik
            basicRand.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            basicRand.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            basicRand.BringToFront(); // formu panel içinde en öne getirdik
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
