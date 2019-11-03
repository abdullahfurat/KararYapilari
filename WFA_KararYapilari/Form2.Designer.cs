namespace WFA_KararYapilari
{
    partial class Form2
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
            this.btnSatisIslemi = new System.Windows.Forms.Button();
            this.btnMarketKontrolu = new System.Windows.Forms.Button();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnGirisKontrolu = new System.Windows.Forms.Button();
            this.txtIkinciDeger = new System.Windows.Forms.TextBox();
            this.txtBirinciDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSatisIslemi
            // 
            this.btnSatisIslemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisIslemi.Location = new System.Drawing.Point(12, 283);
            this.btnSatisIslemi.Name = "btnSatisIslemi";
            this.btnSatisIslemi.Size = new System.Drawing.Size(449, 55);
            this.btnSatisIslemi.TabIndex = 17;
            this.btnSatisIslemi.Text = "SATIŞ İŞLEMİ";
            this.btnSatisIslemi.UseVisualStyleBackColor = true;
            this.btnSatisIslemi.Click += new System.EventHandler(this.btnSatisIslemi_Click);
            // 
            // btnMarketKontrolu
            // 
            this.btnMarketKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarketKontrolu.Location = new System.Drawing.Point(12, 222);
            this.btnMarketKontrolu.Name = "btnMarketKontrolu";
            this.btnMarketKontrolu.Size = new System.Drawing.Size(449, 55);
            this.btnMarketKontrolu.TabIndex = 16;
            this.btnMarketKontrolu.Text = "MARKET KONTROLÜ";
            this.btnMarketKontrolu.UseVisualStyleBackColor = true;
            this.btnMarketKontrolu.Click += new System.EventHandler(this.btnMarketKontrolu_Click);
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotKontrolu.Location = new System.Drawing.Point(12, 161);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(449, 55);
            this.btnNotKontrolu.TabIndex = 15;
            this.btnNotKontrolu.Text = "NOT KONTROLÜ";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.btnNotKontrolu_Click);
            // 
            // btnGirisKontrolu
            // 
            this.btnGirisKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisKontrolu.Location = new System.Drawing.Point(12, 100);
            this.btnGirisKontrolu.Name = "btnGirisKontrolu";
            this.btnGirisKontrolu.Size = new System.Drawing.Size(449, 55);
            this.btnGirisKontrolu.TabIndex = 14;
            this.btnGirisKontrolu.Text = "GİRİŞ BİLGİ KONTROLÜ";
            this.btnGirisKontrolu.UseVisualStyleBackColor = true;
            this.btnGirisKontrolu.Click += new System.EventHandler(this.btnGirisKontrolu_Click);
            // 
            // txtIkinciDeger
            // 
            this.txtIkinciDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIkinciDeger.Location = new System.Drawing.Point(12, 56);
            this.txtIkinciDeger.Name = "txtIkinciDeger";
            this.txtIkinciDeger.Size = new System.Drawing.Size(448, 38);
            this.txtIkinciDeger.TabIndex = 13;
            // 
            // txtBirinciDeger
            // 
            this.txtBirinciDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirinciDeger.Location = new System.Drawing.Point(12, 12);
            this.txtBirinciDeger.Name = "txtBirinciDeger";
            this.txtBirinciDeger.Size = new System.Drawing.Size(448, 38);
            this.txtBirinciDeger.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 350);
            this.Controls.Add(this.btnSatisIslemi);
            this.Controls.Add(this.btnMarketKontrolu);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnGirisKontrolu);
            this.Controls.Add(this.txtIkinciDeger);
            this.Controls.Add(this.txtBirinciDeger);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatisIslemi;
        private System.Windows.Forms.Button btnMarketKontrolu;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnGirisKontrolu;
        private System.Windows.Forms.TextBox txtIkinciDeger;
        private System.Windows.Forms.TextBox txtBirinciDeger;
    }
}