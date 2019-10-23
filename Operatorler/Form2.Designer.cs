namespace Operatorler
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnFarkBoluToplam = new System.Windows.Forms.Button();
            this.btnIslem2 = new System.Windows.Forms.Button();
            this.btnKareArtiKareFark = new System.Windows.Forms.Button();
            this.btnNotHesapla = new System.Windows.Forms.Button();
            this.btnMailOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(13, 13);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(306, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(13, 40);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(306, 20);
            this.txt2.TabIndex = 1;
            // 
            // btnFarkBoluToplam
            // 
            this.btnFarkBoluToplam.Location = new System.Drawing.Point(13, 67);
            this.btnFarkBoluToplam.Name = "btnFarkBoluToplam";
            this.btnFarkBoluToplam.Size = new System.Drawing.Size(306, 41);
            this.btnFarkBoluToplam.TabIndex = 2;
            this.btnFarkBoluToplam.Text = "Fark/Toplam";
            this.btnFarkBoluToplam.UseVisualStyleBackColor = true;
            this.btnFarkBoluToplam.Click += new System.EventHandler(this.BtnFarkBoluToplam_Click);
            // 
            // btnIslem2
            // 
            this.btnIslem2.Location = new System.Drawing.Point(12, 114);
            this.btnIslem2.Name = "btnIslem2";
            this.btnIslem2.Size = new System.Drawing.Size(306, 41);
            this.btnIslem2.TabIndex = 2;
            this.btnIslem2.Text = "İşlem 2";
            this.btnIslem2.UseVisualStyleBackColor = true;
            this.btnIslem2.Click += new System.EventHandler(this.BtnIslem2_Click);
            // 
            // btnKareArtiKareFark
            // 
            this.btnKareArtiKareFark.Location = new System.Drawing.Point(12, 161);
            this.btnKareArtiKareFark.Name = "btnKareArtiKareFark";
            this.btnKareArtiKareFark.Size = new System.Drawing.Size(306, 41);
            this.btnKareArtiKareFark.TabIndex = 2;
            this.btnKareArtiKareFark.Text = "Kare + Kare Fark";
            this.btnKareArtiKareFark.UseVisualStyleBackColor = true;
            this.btnKareArtiKareFark.Click += new System.EventHandler(this.BtnKareArtiKareFark_Click);
            // 
            // btnNotHesapla
            // 
            this.btnNotHesapla.Location = new System.Drawing.Point(12, 208);
            this.btnNotHesapla.Name = "btnNotHesapla";
            this.btnNotHesapla.Size = new System.Drawing.Size(306, 41);
            this.btnNotHesapla.TabIndex = 2;
            this.btnNotHesapla.Text = "Not Hesapla";
            this.btnNotHesapla.UseVisualStyleBackColor = true;
            this.btnNotHesapla.Click += new System.EventHandler(this.BtnNotHesapla_Click);
            // 
            // btnMailOlustur
            // 
            this.btnMailOlustur.Location = new System.Drawing.Point(12, 255);
            this.btnMailOlustur.Name = "btnMailOlustur";
            this.btnMailOlustur.Size = new System.Drawing.Size(306, 41);
            this.btnMailOlustur.TabIndex = 2;
            this.btnMailOlustur.Text = "Mail Oluştur";
            this.btnMailOlustur.UseVisualStyleBackColor = true;
            this.btnMailOlustur.Click += new System.EventHandler(this.BtnMailOlustur_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 322);
            this.Controls.Add(this.btnMailOlustur);
            this.Controls.Add(this.btnNotHesapla);
            this.Controls.Add(this.btnKareArtiKareFark);
            this.Controls.Add(this.btnIslem2);
            this.Controls.Add(this.btnFarkBoluToplam);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnFarkBoluToplam;
        private System.Windows.Forms.Button btnIslem2;
        private System.Windows.Forms.Button btnKareArtiKareFark;
        private System.Windows.Forms.Button btnNotHesapla;
        private System.Windows.Forms.Button btnMailOlustur;
    }
}