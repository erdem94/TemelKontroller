namespace TemelKontroller
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.butonGiris = new System.Windows.Forms.Button();
            this.MouseGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butonGiris
            // 
            this.butonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonGiris.Location = new System.Drawing.Point(40, 40);
            this.butonGiris.Name = "butonGiris";
            this.butonGiris.Size = new System.Drawing.Size(192, 103);
            this.butonGiris.TabIndex = 0;
            this.butonGiris.Text = "GİRİŞ";
            this.butonGiris.UseVisualStyleBackColor = true;
            this.butonGiris.MouseEnter += new System.EventHandler(this.butonGiris_MouseEnter);
            this.butonGiris.MouseLeave += new System.EventHandler(this.butonGiris_MouseLeave);
            // 
            // MouseGiris
            // 
            this.MouseGiris.Location = new System.Drawing.Point(407, 40);
            this.MouseGiris.Name = "MouseGiris";
            this.MouseGiris.Size = new System.Drawing.Size(182, 103);
            this.MouseGiris.TabIndex = 1;
            this.MouseGiris.Text = "Mouse Olayları";
            this.MouseGiris.UseVisualStyleBackColor = true;
            this.MouseGiris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseGiris_MouseDown);
            this.MouseGiris.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseGiris_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MouseGiris);
            this.Controls.Add(this.butonGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonGiris;
        private System.Windows.Forms.Button MouseGiris;
        private System.Windows.Forms.Label label1;
    }
}

