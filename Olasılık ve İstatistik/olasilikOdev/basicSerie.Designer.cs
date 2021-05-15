namespace olasilikOdev
{
    partial class basicSerie
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.number = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.value = new DevExpress.XtraEditors.TextEdit();
            this.sayilab = new DevExpress.XtraEditors.LabelControl();
            this.ekle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 187);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Basit Seri";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dogal);
            this.groupControl4.Location = new System.Drawing.Point(288, 26);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(101, 148);
            this.groupControl4.TabIndex = 9;
            this.groupControl4.Text = "Sıralanan";
            // 
            // dogal
            // 
            this.dogal.Location = new System.Drawing.Point(5, 26);
            this.dogal.Name = "dogal";
            this.dogal.Size = new System.Drawing.Size(89, 117);
            this.dogal.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ekle);
            this.groupControl2.Controls.Add(this.value);
            this.groupControl2.Controls.Add(this.sayilab);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.number);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(6, 26);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(264, 148);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Veri Girişi";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(140, 40);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Verileri Giriş Yap";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(84, 42);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(40, 20);
            this.number.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sayı Adeti :";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(84, 72);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(40, 20);
            this.value.TabIndex = 9;
            this.value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.value_KeyPress);
            // 
            // sayilab
            // 
            this.sayilab.Location = new System.Drawing.Point(51, 75);
            this.sayilab.Name = "sayilab";
            this.sayilab.Size = new System.Drawing.Size(27, 13);
            this.sayilab.TabIndex = 8;
            this.sayilab.Text = "Sayı :";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(140, 70);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(103, 23);
            this.ekle.TabIndex = 10;
            this.ekle.Text = "Ekle";
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // basicSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "basicSerie";
            this.Size = new System.Drawing.Size(436, 195);
            this.Load += new System.EventHandler(this.basicSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dogal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ListBoxControl dogal;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton ekle;
        private DevExpress.XtraEditors.TextEdit value;
        private DevExpress.XtraEditors.LabelControl sayilab;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit number;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
