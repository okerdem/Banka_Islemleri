
namespace Banka_Alistirma
{
    partial class KayitOl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxKHNO = new System.Windows.Forms.MaskedTextBox();
            this.textBoxKTCNO = new System.Windows.Forms.TextBox();
            this.textBoxKADS = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.labelKSifre = new System.Windows.Forms.Label();
            this.textBoxKSifre = new System.Windows.Forms.TextBox();
            this.maskedTextBoxKTELNO = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tel No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesap No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad :";
            // 
            // maskedTextBoxKHNO
            // 
            this.maskedTextBoxKHNO.Location = new System.Drawing.Point(167, 106);
            this.maskedTextBoxKHNO.Mask = "000000";
            this.maskedTextBoxKHNO.Name = "maskedTextBoxKHNO";
            this.maskedTextBoxKHNO.ReadOnly = true;
            this.maskedTextBoxKHNO.Size = new System.Drawing.Size(134, 26);
            this.maskedTextBoxKHNO.TabIndex = 8;
            this.maskedTextBoxKHNO.ValidatingType = typeof(int);
            // 
            // textBoxKTCNO
            // 
            this.textBoxKTCNO.Location = new System.Drawing.Point(167, 170);
            this.textBoxKTCNO.Name = "textBoxKTCNO";
            this.textBoxKTCNO.Size = new System.Drawing.Size(134, 26);
            this.textBoxKTCNO.TabIndex = 3;
            // 
            // textBoxKADS
            // 
            this.textBoxKADS.Location = new System.Drawing.Point(167, 74);
            this.textBoxKADS.Name = "textBoxKADS";
            this.textBoxKADS.Size = new System.Drawing.Size(134, 26);
            this.textBoxKADS.TabIndex = 1;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(195, 269);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(76, 34);
            this.buttonKaydet.TabIndex = 5;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // labelKSifre
            // 
            this.labelKSifre.AutoSize = true;
            this.labelKSifre.Location = new System.Drawing.Point(101, 208);
            this.labelKSifre.Name = "labelKSifre";
            this.labelKSifre.Size = new System.Drawing.Size(50, 20);
            this.labelKSifre.TabIndex = 13;
            this.labelKSifre.Text = "Şifre :";
            // 
            // textBoxKSifre
            // 
            this.textBoxKSifre.Location = new System.Drawing.Point(167, 202);
            this.textBoxKSifre.Name = "textBoxKSifre";
            this.textBoxKSifre.Size = new System.Drawing.Size(134, 26);
            this.textBoxKSifre.TabIndex = 4;
            // 
            // maskedTextBoxKTELNO
            // 
            this.maskedTextBoxKTELNO.Location = new System.Drawing.Point(167, 138);
            this.maskedTextBoxKTELNO.Mask = "(999) 000-0000";
            this.maskedTextBoxKTELNO.Name = "maskedTextBoxKTELNO";
            this.maskedTextBoxKTELNO.Size = new System.Drawing.Size(134, 26);
            this.maskedTextBoxKTELNO.TabIndex = 2;
            // 
            // KayitOl
            // 
            this.AcceptButton = this.buttonKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 347);
            this.Controls.Add(this.maskedTextBoxKTELNO);
            this.Controls.Add(this.textBoxKSifre);
            this.Controls.Add(this.labelKSifre);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxKADS);
            this.Controls.Add(this.textBoxKTCNO);
            this.Controls.Add(this.maskedTextBoxKHNO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitOl";
            this.Load += new System.EventHandler(this.KayitOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKHNO;
        private System.Windows.Forms.TextBox textBoxKTCNO;
        private System.Windows.Forms.TextBox textBoxKADS;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label labelKSifre;
        private System.Windows.Forms.TextBox textBoxKSifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKTELNO;
    }
}