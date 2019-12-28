namespace hastaneOtomasyonu
{
    partial class maliyeGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maliyeGiris));
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.Image")));
            this.btnAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnaSayfa.Location = new System.Drawing.Point(155, 272);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(94, 65);
            this.btnAnaSayfa.TabIndex = 28;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Şifre Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "T.C. giriniz";
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnHastaGiris.FlatAppearance.BorderSize = 0;
            this.btnHastaGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaGiris.Image")));
            this.btnHastaGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaGiris.Location = new System.Drawing.Point(95, 194);
            this.btnHastaGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(56, 64);
            this.btnHastaGiris.TabIndex = 24;
            this.btnHastaGiris.Text = "Giriş";
            this.btnHastaGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHastaGiris.UseVisualStyleBackColor = false;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(78, 170);
            this.sifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(99, 20);
            this.sifre.TabIndex = 23;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(78, 133);
            this.tc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(99, 20);
            this.tc.TabIndex = 22;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel1.Controls.Add(this.btnAnaSayfa);
            this.kryptonPanel1.Controls.Add(this.tc);
            this.kryptonPanel1.Controls.Add(this.sifre);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.btnHastaGiris);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(258, 346);
            this.kryptonPanel1.TabIndex = 29;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(258, 34);
            this.kryptonHeader1.TabIndex = 29;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "MALİYE GİRİŞ";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // maliyeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(258, 346);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "maliyeGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MALİYE GİRİŞİ";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox tc;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
    }
}