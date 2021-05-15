namespace olasilikOdev
{
    partial class sysBasicRand
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
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dogal = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.asayi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.bigNValue = new DevExpress.XtraEditors.TextEdit();
            this.nValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.kNorm = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.kYuv = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigNValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(604, 179);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Sistematik Rastgele Örnekleme";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dogal);
            this.groupControl4.Location = new System.Drawing.Point(288, 26);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(101, 148);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Oluşan";
            // 
            // dogal
            // 
            this.dogal.Location = new System.Drawing.Point(5, 26);
            this.dogal.Name = "dogal";
            this.dogal.Size = new System.Drawing.Size(89, 117);
            this.dogal.TabIndex = 7;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.kYuv);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.kNorm);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.asayi);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Location = new System.Drawing.Point(395, 26);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(204, 148);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Bilgi";
            // 
            // asayi
            // 
            this.asayi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asayi.Appearance.Options.UseFont = true;
            this.asayi.Location = new System.Drawing.Point(93, 59);
            this.asayi.Name = "asayi";
            this.asayi.Size = new System.Drawing.Size(0, 19);
            this.asayi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Rastgele Üretilen Sayı";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.bigNValue);
            this.groupControl2.Controls.Add(this.nValue);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(6, 26);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(276, 148);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Veri Girişi";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(174, 67);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Üret";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // bigNValue
            // 
            this.bigNValue.Location = new System.Drawing.Point(76, 53);
            this.bigNValue.Name = "bigNValue";
            this.bigNValue.Size = new System.Drawing.Size(40, 20);
            this.bigNValue.TabIndex = 1;
            // 
            // nValue
            // 
            this.nValue.Location = new System.Drawing.Point(76, 80);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(40, 20);
            this.nValue.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "N :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(56, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(13, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "n :";
            // 
            // kNorm
            // 
            this.kNorm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kNorm.Appearance.Options.UseFont = true;
            this.kNorm.Location = new System.Drawing.Point(55, 109);
            this.kNorm.Name = "kNorm";
            this.kNorm.Size = new System.Drawing.Size(0, 13);
            this.kNorm.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 108);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "k=N/n:";
            // 
            // kYuv
            // 
            this.kYuv.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kYuv.Appearance.Options.UseFont = true;
            this.kYuv.Location = new System.Drawing.Point(98, 125);
            this.kYuv.Name = "kYuv";
            this.kYuv.Size = new System.Drawing.Size(0, 13);
            this.kYuv.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(9, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "k Yuvarlanmış:";
            // 
            // sysBasicRand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "sysBasicRand";
            this.Size = new System.Drawing.Size(610, 185);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dogal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigNValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ListBoxControl dogal;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit bigNValue;
        private DevExpress.XtraEditors.TextEdit nValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl asayi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl kYuv;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl kNorm;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
