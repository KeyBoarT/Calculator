
namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1Button = new System.Windows.Forms.Button();
            this.rakam3Button = new System.Windows.Forms.Button();
            this.rakam2Button = new System.Windows.Forms.Button();
            this.rakam5Button = new System.Windows.Forms.Button();
            this.rakam6Button = new System.Windows.Forms.Button();
            this.rakam4Button = new System.Windows.Forms.Button();
            this.rakam0Button = new System.Windows.Forms.Button();
            this.cevapButton = new System.Windows.Forms.Button();
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.rakam8Button = new System.Windows.Forms.Button();
            this.rakam9Button = new System.Windows.Forms.Button();
            this.rakam7Button = new System.Windows.Forms.Button();
            this.bolButton = new System.Windows.Forms.Button();
            this.carpButton = new System.Windows.Forms.Button();
            this.cikarButton = new System.Windows.Forms.Button();
            this.toplaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.Color.White;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(13, 9);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(318, 65);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ekranLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rakam1Button
            // 
            this.rakam1Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1Button.Location = new System.Drawing.Point(13, 87);
            this.rakam1Button.Name = "rakam1Button";
            this.rakam1Button.Size = new System.Drawing.Size(75, 75);
            this.rakam1Button.TabIndex = 1;
            this.rakam1Button.Text = "1";
            this.rakam1Button.UseVisualStyleBackColor = false;
            this.rakam1Button.Click += new System.EventHandler(this.rakam1Button_Click);
            // 
            // rakam3Button
            // 
            this.rakam3Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3Button.Location = new System.Drawing.Point(175, 87);
            this.rakam3Button.Name = "rakam3Button";
            this.rakam3Button.Size = new System.Drawing.Size(75, 75);
            this.rakam3Button.TabIndex = 3;
            this.rakam3Button.Text = "3";
            this.rakam3Button.UseVisualStyleBackColor = false;
            this.rakam3Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // rakam2Button
            // 
            this.rakam2Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2Button.Location = new System.Drawing.Point(94, 87);
            this.rakam2Button.Name = "rakam2Button";
            this.rakam2Button.Size = new System.Drawing.Size(75, 75);
            this.rakam2Button.TabIndex = 4;
            this.rakam2Button.Text = "2";
            this.rakam2Button.UseVisualStyleBackColor = false;
            this.rakam2Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // rakam5Button
            // 
            this.rakam5Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5Button.Location = new System.Drawing.Point(94, 168);
            this.rakam5Button.Name = "rakam5Button";
            this.rakam5Button.Size = new System.Drawing.Size(75, 75);
            this.rakam5Button.TabIndex = 7;
            this.rakam5Button.Text = "5";
            this.rakam5Button.UseVisualStyleBackColor = false;
            this.rakam5Button.Click += new System.EventHandler(this.rakam5Button_Click);
            // 
            // rakam6Button
            // 
            this.rakam6Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6Button.Location = new System.Drawing.Point(175, 168);
            this.rakam6Button.Name = "rakam6Button";
            this.rakam6Button.Size = new System.Drawing.Size(75, 75);
            this.rakam6Button.TabIndex = 6;
            this.rakam6Button.Text = "6";
            this.rakam6Button.UseVisualStyleBackColor = false;
            this.rakam6Button.Click += new System.EventHandler(this.rakam6Button_Click);
            // 
            // rakam4Button
            // 
            this.rakam4Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4Button.Location = new System.Drawing.Point(13, 168);
            this.rakam4Button.Name = "rakam4Button";
            this.rakam4Button.Size = new System.Drawing.Size(75, 75);
            this.rakam4Button.TabIndex = 5;
            this.rakam4Button.Text = "4";
            this.rakam4Button.UseVisualStyleBackColor = false;
            this.rakam4Button.Click += new System.EventHandler(this.button6_Click);
            // 
            // rakam0Button
            // 
            this.rakam0Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0Button.Location = new System.Drawing.Point(94, 330);
            this.rakam0Button.Name = "rakam0Button";
            this.rakam0Button.Size = new System.Drawing.Size(75, 75);
            this.rakam0Button.TabIndex = 13;
            this.rakam0Button.Text = "0";
            this.rakam0Button.UseVisualStyleBackColor = false;
            this.rakam0Button.Click += new System.EventHandler(this.button7_Click);
            // 
            // cevapButton
            // 
            this.cevapButton.BackColor = System.Drawing.Color.Bisque;
            this.cevapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapButton.Location = new System.Drawing.Point(175, 330);
            this.cevapButton.Name = "cevapButton";
            this.cevapButton.Size = new System.Drawing.Size(75, 75);
            this.cevapButton.TabIndex = 12;
            this.cevapButton.Text = "=";
            this.cevapButton.UseVisualStyleBackColor = false;
            this.cevapButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // sifirlaButton
            // 
            this.sifirlaButton.BackColor = System.Drawing.Color.Red;
            this.sifirlaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirlaButton.ForeColor = System.Drawing.Color.White;
            this.sifirlaButton.Location = new System.Drawing.Point(13, 330);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(75, 75);
            this.sifirlaButton.TabIndex = 11;
            this.sifirlaButton.Text = "C";
            this.sifirlaButton.UseVisualStyleBackColor = false;
            this.sifirlaButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // rakam8Button
            // 
            this.rakam8Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8Button.Location = new System.Drawing.Point(94, 249);
            this.rakam8Button.Name = "rakam8Button";
            this.rakam8Button.Size = new System.Drawing.Size(75, 75);
            this.rakam8Button.TabIndex = 10;
            this.rakam8Button.Text = "8";
            this.rakam8Button.UseVisualStyleBackColor = false;
            this.rakam8Button.Click += new System.EventHandler(this.button10_Click);
            // 
            // rakam9Button
            // 
            this.rakam9Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9Button.Location = new System.Drawing.Point(175, 249);
            this.rakam9Button.Name = "rakam9Button";
            this.rakam9Button.Size = new System.Drawing.Size(75, 75);
            this.rakam9Button.TabIndex = 9;
            this.rakam9Button.Text = "9";
            this.rakam9Button.UseVisualStyleBackColor = false;
            this.rakam9Button.Click += new System.EventHandler(this.button11_Click);
            // 
            // rakam7Button
            // 
            this.rakam7Button.BackColor = System.Drawing.Color.Turquoise;
            this.rakam7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7Button.Location = new System.Drawing.Point(13, 249);
            this.rakam7Button.Name = "rakam7Button";
            this.rakam7Button.Size = new System.Drawing.Size(75, 75);
            this.rakam7Button.TabIndex = 8;
            this.rakam7Button.Text = "7";
            this.rakam7Button.UseVisualStyleBackColor = false;
            this.rakam7Button.Click += new System.EventHandler(this.button12_Click);
            // 
            // bolButton
            // 
            this.bolButton.BackColor = System.Drawing.Color.Pink;
            this.bolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolButton.Location = new System.Drawing.Point(256, 330);
            this.bolButton.Name = "bolButton";
            this.bolButton.Size = new System.Drawing.Size(75, 75);
            this.bolButton.TabIndex = 17;
            this.bolButton.Text = "/";
            this.bolButton.UseVisualStyleBackColor = false;
            this.bolButton.Click += new System.EventHandler(this.bolButton_Click);
            // 
            // carpButton
            // 
            this.carpButton.BackColor = System.Drawing.Color.Pink;
            this.carpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpButton.Location = new System.Drawing.Point(256, 249);
            this.carpButton.Name = "carpButton";
            this.carpButton.Size = new System.Drawing.Size(75, 75);
            this.carpButton.TabIndex = 16;
            this.carpButton.Text = "X";
            this.carpButton.UseVisualStyleBackColor = false;
            this.carpButton.Click += new System.EventHandler(this.carpButton_Click);
            // 
            // cikarButton
            // 
            this.cikarButton.BackColor = System.Drawing.Color.Pink;
            this.cikarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarButton.Location = new System.Drawing.Point(256, 168);
            this.cikarButton.Name = "cikarButton";
            this.cikarButton.Size = new System.Drawing.Size(75, 75);
            this.cikarButton.TabIndex = 15;
            this.cikarButton.Text = "-";
            this.cikarButton.UseVisualStyleBackColor = false;
            this.cikarButton.Click += new System.EventHandler(this.cikarButton_Click);
            // 
            // toplaButton
            // 
            this.toplaButton.BackColor = System.Drawing.Color.Pink;
            this.toplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplaButton.Location = new System.Drawing.Point(256, 87);
            this.toplaButton.Name = "toplaButton";
            this.toplaButton.Size = new System.Drawing.Size(75, 75);
            this.toplaButton.TabIndex = 14;
            this.toplaButton.Text = "+";
            this.toplaButton.UseVisualStyleBackColor = false;
            this.toplaButton.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 415);
            this.Controls.Add(this.bolButton);
            this.Controls.Add(this.carpButton);
            this.Controls.Add(this.cikarButton);
            this.Controls.Add(this.toplaButton);
            this.Controls.Add(this.rakam0Button);
            this.Controls.Add(this.cevapButton);
            this.Controls.Add(this.sifirlaButton);
            this.Controls.Add(this.rakam8Button);
            this.Controls.Add(this.rakam9Button);
            this.Controls.Add(this.rakam7Button);
            this.Controls.Add(this.rakam5Button);
            this.Controls.Add(this.rakam6Button);
            this.Controls.Add(this.rakam4Button);
            this.Controls.Add(this.rakam2Button);
            this.Controls.Add(this.rakam3Button);
            this.Controls.Add(this.rakam1Button);
            this.Controls.Add(this.ekranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1Button;
        private System.Windows.Forms.Button rakam3Button;
        private System.Windows.Forms.Button rakam2Button;
        private System.Windows.Forms.Button rakam5Button;
        private System.Windows.Forms.Button rakam6Button;
        private System.Windows.Forms.Button rakam4Button;
        private System.Windows.Forms.Button rakam0Button;
        private System.Windows.Forms.Button cevapButton;
        private System.Windows.Forms.Button sifirlaButton;
        private System.Windows.Forms.Button rakam8Button;
        private System.Windows.Forms.Button rakam9Button;
        private System.Windows.Forms.Button rakam7Button;
        private System.Windows.Forms.Button bolButton;
        private System.Windows.Forms.Button carpButton;
        private System.Windows.Forms.Button cikarButton;
        private System.Windows.Forms.Button toplaButton;
    }
}

