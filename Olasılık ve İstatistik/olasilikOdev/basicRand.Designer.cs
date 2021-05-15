namespace olasilikOdev
{
    partial class basicRand
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.value = new DevExpress.XtraEditors.TextEdit();
            this.maxGelen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.minGelen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sayi = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dogal = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxGelen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minGelen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 188);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Basit Rastgele Örnekleme";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adet :";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(46, 42);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(40, 20);
            this.value.TabIndex = 1;
            // 
            // maxGelen
            // 
            this.maxGelen.Location = new System.Drawing.Point(46, 99);
            this.maxGelen.Name = "maxGelen";
            this.maxGelen.Size = new System.Drawing.Size(40, 20);
            this.maxGelen.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Max:";
            // 
            // minGelen
            // 
            this.minGelen.Location = new System.Drawing.Point(46, 69);
            this.minGelen.Name = "minGelen";
            this.minGelen.Size = new System.Drawing.Size(40, 20);
            this.minGelen.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Min:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.value);
            this.groupControl2.Controls.Add(this.minGelen);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.maxGelen);
            this.groupControl2.Location = new System.Drawing.Point(5, 26);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(276, 148);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Veri Girişi";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(154, 66);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Üret";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(5, 26);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(89, 117);
            this.sayi.TabIndex = 7;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.sayi);
            this.groupControl3.Location = new System.Drawing.Point(394, 26);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(101, 148);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Sıralı";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dogal);
            this.groupControl4.Location = new System.Drawing.Point(287, 26);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(101, 148);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Doğal";
            // 
            // dogal
            // 
            this.dogal.Location = new System.Drawing.Point(5, 26);
            this.dogal.Name = "dogal";
            this.dogal.Size = new System.Drawing.Size(89, 117);
            this.dogal.TabIndex = 7;
            // 
            // basicRand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "basicRand";
            this.Size = new System.Drawing.Size(512, 193);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.value.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxGelen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minGelen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dogal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit value;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit minGelen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit maxGelen;
        private DevExpress.XtraEditors.ListBoxControl sayi;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ListBoxControl dogal;
    }
}
