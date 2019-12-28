namespace hastaneOtomasyonu
{
    partial class hastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastaGiris));
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.Image")));
            this.btnAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnaSayfa.Location = new System.Drawing.Point(310, 310);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(110, 82);
            this.btnAnaSayfa.TabIndex = 20;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(139, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre Giriniz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(139, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "T.C. giriniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifre
            // 
            this.sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sifre.Location = new System.Drawing.Point(142, 184);
            this.sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(131, 22);
            this.sifre.TabIndex = 15;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // tc
            // 
            this.tc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tc.Location = new System.Drawing.Point(142, 140);
            this.tc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(131, 22);
            this.tc.TabIndex = 14;
            this.tc.TextChanged += new System.EventHandler(this.tc_TextChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel1.Controls.Add(this.button1);
            this.kryptonPanel1.Controls.Add(this.tc);
            this.kryptonPanel1.Controls.Add(this.btnAnaSayfa);
            this.kryptonPanel1.Controls.Add(this.sifre);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.btnHastaGiris);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(432, 403);
            this.kryptonPanel1.TabIndex = 22;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(432, 68);
            this.kryptonHeader1.TabIndex = 22;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "HASTA GİRİŞ";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Image = global::hastaneOtomasyonu.Properties.Resources.icons8_sign_up_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(194, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 82);
            this.button1.TabIndex = 21;
            this.button1.Text = "Hasta Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHastaGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnHastaGiris.FlatAppearance.BorderSize = 0;
            this.btnHastaGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaGiris.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHastaGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaGiris.Image")));
            this.btnHastaGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaGiris.Location = new System.Drawing.Point(154, 210);
            this.btnHastaGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(110, 82);
            this.btnHastaGiris.TabIndex = 16;
            this.btnHastaGiris.Text = "Giriş";
            this.btnHastaGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHastaGiris.UseVisualStyleBackColor = false;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // hastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA GİRİŞ";
            this.Load += new System.EventHandler(this.hastaGiris_Load);
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
        private System.Windows.Forms.Button button1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
    }
}