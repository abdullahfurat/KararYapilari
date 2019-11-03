namespace WFA_KararYapilari
{
    partial class Form3
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
            this.lblKalanHakkimiz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtMetinGirisAlani = new System.Windows.Forms.TextBox();
            this.lblRastgeleKarakterler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKalanHakkimiz
            // 
            this.lblKalanHakkimiz.AutoSize = true;
            this.lblKalanHakkimiz.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.lblKalanHakkimiz.ForeColor = System.Drawing.Color.Maroon;
            this.lblKalanHakkimiz.Location = new System.Drawing.Point(383, 249);
            this.lblKalanHakkimiz.Name = "lblKalanHakkimiz";
            this.lblKalanHakkimiz.Size = new System.Drawing.Size(34, 32);
            this.lblKalanHakkimiz.TabIndex = 17;
            this.lblKalanHakkimiz.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kalan Hatalı Giriş Hakkınız:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Location = new System.Drawing.Point(18, 158);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(742, 60);
            this.btnGirisYap.TabIndex = 15;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtMetinGirisAlani
            // 
            this.txtMetinGirisAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetinGirisAlani.Location = new System.Drawing.Point(18, 114);
            this.txtMetinGirisAlani.Name = "txtMetinGirisAlani";
            this.txtMetinGirisAlani.Size = new System.Drawing.Size(742, 38);
            this.txtMetinGirisAlani.TabIndex = 14;
            // 
            // lblRastgeleKarakterler
            // 
            this.lblRastgeleKarakterler.AutoSize = true;
            this.lblRastgeleKarakterler.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.lblRastgeleKarakterler.Location = new System.Drawing.Point(12, 67);
            this.lblRastgeleKarakterler.Name = "lblRastgeleKarakterler";
            this.lblRastgeleKarakterler.Size = new System.Drawing.Size(60, 32);
            this.lblRastgeleKarakterler.TabIndex = 13;
            this.lblRastgeleKarakterler.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lütfen aşağıda görmüş karakterleri ilgili yazı alanına geçiriniz:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 301);
            this.Controls.Add(this.lblKalanHakkimiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtMetinGirisAlani);
            this.Controls.Add(this.lblRastgeleKarakterler);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalanHakkimiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtMetinGirisAlani;
        private System.Windows.Forms.Label lblRastgeleKarakterler;
        private System.Windows.Forms.Label label1;
    }
}