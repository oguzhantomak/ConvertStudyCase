namespace Operatorler
{
    partial class Form1
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnModAlma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(32, 12);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(109, 41);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(32, 59);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(109, 41);
            this.btnCikart.TabIndex = 0;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.BtnCikart_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(31, 106);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(109, 41);
            this.btnCarpma.TabIndex = 0;
            this.btnCarpma.Text = "Çarp";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.BtnCarpma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(31, 153);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(109, 41);
            this.btnBolme.TabIndex = 0;
            this.btnBolme.Text = "Böl";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.BtnBolme_Click);
            // 
            // btnModAlma
            // 
            this.btnModAlma.Location = new System.Drawing.Point(31, 200);
            this.btnModAlma.Name = "btnModAlma";
            this.btnModAlma.Size = new System.Drawing.Size(109, 41);
            this.btnModAlma.TabIndex = 0;
            this.btnModAlma.Text = "Mod Al";
            this.btnModAlma.UseVisualStyleBackColor = true;
            this.btnModAlma.Click += new System.EventHandler(this.BtnModAlma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 275);
            this.Controls.Add(this.btnModAlma);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnTopla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnModAlma;
    }
}

