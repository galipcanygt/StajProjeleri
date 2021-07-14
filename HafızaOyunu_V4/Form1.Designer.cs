
namespace HafızaOyunu_V2
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
            this.BoyutLabel = new System.Windows.Forms.Label();
            this.DörtRadio = new System.Windows.Forms.RadioButton();
            this.AltiRadio = new System.Windows.Forms.RadioButton();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoyutLabel
            // 
            this.BoyutLabel.AutoSize = true;
            this.BoyutLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoyutLabel.Location = new System.Drawing.Point(1059, 203);
            this.BoyutLabel.Name = "BoyutLabel";
            this.BoyutLabel.Size = new System.Drawing.Size(82, 17);
            this.BoyutLabel.TabIndex = 1;
            this.BoyutLabel.Text = "Boyut Seçiniz";
            // 
            // DörtRadio
            // 
            this.DörtRadio.AutoSize = true;
            this.DörtRadio.Location = new System.Drawing.Point(1059, 243);
            this.DörtRadio.Name = "DörtRadio";
            this.DörtRadio.Size = new System.Drawing.Size(51, 21);
            this.DörtRadio.TabIndex = 2;
            this.DörtRadio.TabStop = true;
            this.DörtRadio.Text = "4x4";
            this.DörtRadio.UseVisualStyleBackColor = true;
            // 
            // AltiRadio
            // 
            this.AltiRadio.AutoSize = true;
            this.AltiRadio.Location = new System.Drawing.Point(1059, 273);
            this.AltiRadio.Name = "AltiRadio";
            this.AltiRadio.Size = new System.Drawing.Size(51, 21);
            this.AltiRadio.TabIndex = 3;
            this.AltiRadio.TabStop = true;
            this.AltiRadio.Text = "6x6";
            this.AltiRadio.UseVisualStyleBackColor = true;
            // 
            // BtnBasla
            // 
            this.BtnBasla.AutoSize = true;
            this.BtnBasla.Location = new System.Drawing.Point(1059, 333);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(75, 28);
            this.BtnBasla.TabIndex = 4;
            this.BtnBasla.Text = "Başla";
            this.BtnBasla.UseVisualStyleBackColor = true;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 883);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.AltiRadio);
            this.Controls.Add(this.DörtRadio);
            this.Controls.Add(this.BoyutLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BoyutLabel;
        private System.Windows.Forms.RadioButton DörtRadio;
        private System.Windows.Forms.RadioButton AltiRadio;
        private System.Windows.Forms.Button BtnBasla;
    }
}

