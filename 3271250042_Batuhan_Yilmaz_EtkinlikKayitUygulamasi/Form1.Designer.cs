namespace _3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBaslik = new Label();
            grpEtkinlik = new GroupBox();
            rbKonser = new RadioButton();
            rbAtolye = new RadioButton();
            rbKonferans = new RadioButton();
            grpBilgiler = new GroupBox();
            nudKisiSayisi = new NumericUpDown();
            lblKisiSayisi = new Label();
            txtKatilimci = new TextBox();
            lblKatilimci = new Label();
            grpHizmetler = new GroupBox();
            chkServis = new CheckBox();
            chkYemek = new CheckBox();
            btnHesapla = new Button();
            btnİndirim = new Button();
            btnOzet = new Button();
            btnCikis = new Button();
            lblIndirim = new Label();
            txtToplam = new TextBox();
            lblToplamBaslik = new Label();
            lblDurum = new Label();
            grpEtkinlik.SuspendLayout();
            grpBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKisiSayisi).BeginInit();
            grpHizmetler.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBaslik.Location = new Point(511, 9);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(344, 37);
            lblBaslik.TabIndex = 13;
            lblBaslik.Text = "Etkinlik Kayıt Uygulaması";
            // 
            // grpEtkinlik
            // 
            grpEtkinlik.Controls.Add(rbKonser);
            grpEtkinlik.Controls.Add(rbAtolye);
            grpEtkinlik.Controls.Add(rbKonferans);
            grpEtkinlik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEtkinlik.Location = new Point(463, 75);
            grpEtkinlik.Name = "grpEtkinlik";
            grpEtkinlik.Size = new Size(392, 150);
            grpEtkinlik.TabIndex = 14;
            grpEtkinlik.TabStop = false;
            grpEtkinlik.Text = "Etkinlik Türü";
            // 
            // rbKonser
            // 
            rbKonser.AutoSize = true;
            rbKonser.Font = new Font("Segoe UI", 10F);
            rbKonser.Location = new Point(26, 107);
            rbKonser.Name = "rbKonser";
            rbKonser.Size = new Size(123, 23);
            rbKonser.TabIndex = 0;
            rbKonser.Text = "Konser (250 TL)";
            // 
            // rbAtolye
            // 
            rbAtolye.AutoSize = true;
            rbAtolye.Font = new Font("Segoe UI", 10F);
            rbAtolye.Location = new Point(26, 73);
            rbAtolye.Name = "rbAtolye";
            rbAtolye.Size = new Size(120, 23);
            rbAtolye.TabIndex = 1;
            rbAtolye.Text = "Atölye (300 TL)";
            // 
            // rbKonferans
            // 
            rbKonferans.AutoSize = true;
            rbKonferans.Font = new Font("Segoe UI", 10F);
            rbKonferans.Location = new Point(26, 39);
            rbKonferans.Name = "rbKonferans";
            rbKonferans.Size = new Size(142, 23);
            rbKonferans.TabIndex = 2;
            rbKonferans.Text = "Konferans (400 TL)";
            // 
            // grpBilgiler
            // 
            grpBilgiler.Controls.Add(nudKisiSayisi);
            grpBilgiler.Controls.Add(lblKisiSayisi);
            grpBilgiler.Controls.Add(txtKatilimci);
            grpBilgiler.Controls.Add(lblKatilimci);
            grpBilgiler.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpBilgiler.Location = new Point(47, 75);
            grpBilgiler.Name = "grpBilgiler";
            grpBilgiler.Size = new Size(392, 150);
            grpBilgiler.TabIndex = 15;
            grpBilgiler.TabStop = false;
            grpBilgiler.Text = "Katılımcı Bilgileri";
            // 
            // nudKisiSayisi
            // 
            nudKisiSayisi.Font = new Font("Segoe UI", 10F);
            nudKisiSayisi.Location = new Point(157, 96);
            nudKisiSayisi.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudKisiSayisi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudKisiSayisi.Name = "nudKisiSayisi";
            nudKisiSayisi.Size = new Size(100, 25);
            nudKisiSayisi.TabIndex = 0;
            nudKisiSayisi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblKisiSayisi
            // 
            lblKisiSayisi.AutoSize = true;
            lblKisiSayisi.Font = new Font("Segoe UI", 10F);
            lblKisiSayisi.Location = new Point(22, 99);
            lblKisiSayisi.Name = "lblKisiSayisi";
            lblKisiSayisi.Size = new Size(68, 19);
            lblKisiSayisi.TabIndex = 1;
            lblKisiSayisi.Text = "Kişi sayısı:";
            // 
            // txtKatilimci
            // 
            txtKatilimci.Font = new Font("Segoe UI", 10F);
            txtKatilimci.Location = new Point(157, 48);
            txtKatilimci.MaxLength = 15;
            txtKatilimci.Name = "txtKatilimci";
            txtKatilimci.Size = new Size(117, 25);
            txtKatilimci.TabIndex = 2;
            // 
            // lblKatilimci
            // 
            lblKatilimci.AutoSize = true;
            lblKatilimci.Font = new Font("Segoe UI", 10F);
            lblKatilimci.Location = new Point(22, 51);
            lblKatilimci.Name = "lblKatilimci";
            lblKatilimci.Size = new Size(84, 19);
            lblKatilimci.TabIndex = 3;
            lblKatilimci.Text = "Katılımcı adı:";
            // 
            // grpHizmetler
            // 
            grpHizmetler.Controls.Add(chkServis);
            grpHizmetler.Controls.Add(chkYemek);
            grpHizmetler.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpHizmetler.Location = new Point(463, 242);
            grpHizmetler.Name = "grpHizmetler";
            grpHizmetler.Size = new Size(392, 120);
            grpHizmetler.TabIndex = 16;
            grpHizmetler.TabStop = false;
            grpHizmetler.Text = "Ek Hizmetler";
            // 
            // chkServis
            // 
            chkServis.AutoSize = true;
            chkServis.Font = new Font("Segoe UI", 10F);
            chkServis.Location = new Point(22, 75);
            chkServis.Name = "chkServis";
            chkServis.Size = new Size(160, 23);
            chkServis.TabIndex = 0;
            chkServis.Text = "Servis (kişi başı 75 TL)";
            // 
            // chkYemek
            // 
            chkYemek.AutoSize = true;
            chkYemek.Font = new Font("Segoe UI", 10F);
            chkYemek.Location = new Point(22, 39);
            chkYemek.Name = "chkYemek";
            chkYemek.Size = new Size(173, 23);
            chkYemek.TabIndex = 1;
            chkYemek.Text = "Yemek (kişi başı 150 TL)";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.LightGray;
            btnHesapla.Cursor = Cursors.Hand;
            btnHesapla.FlatAppearance.BorderSize = 0;
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHesapla.Location = new Point(47, 252);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(145, 52);
            btnHesapla.TabIndex = 17;
            btnHesapla.Text = "Ücreti Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnİndirim
            // 
            btnİndirim.BackColor = SystemColors.ActiveCaption;
            btnİndirim.Cursor = Cursors.Hand;
            btnİndirim.FlatAppearance.BorderSize = 0;
            btnİndirim.FlatStyle = FlatStyle.Flat;
            btnİndirim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnİndirim.ForeColor = SystemColors.ActiveCaptionText;
            btnİndirim.Location = new Point(204, 252);
            btnİndirim.Name = "btnİndirim";
            btnİndirim.Size = new Size(145, 52);
            btnİndirim.TabIndex = 18;
            btnİndirim.Text = "İndirim Hesapla";
            btnİndirim.UseVisualStyleBackColor = false;
            btnİndirim.Click += btnİndirim_Click;
            // 
            // btnOzet
            // 
            btnOzet.BackColor = Color.LemonChiffon;
            btnOzet.Cursor = Cursors.Hand;
            btnOzet.FlatAppearance.BorderSize = 0;
            btnOzet.FlatStyle = FlatStyle.Flat;
            btnOzet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnOzet.Location = new Point(47, 310);
            btnOzet.Name = "btnOzet";
            btnOzet.Size = new Size(145, 52);
            btnOzet.TabIndex = 19;
            btnOzet.Text = "Özeti Göster";
            btnOzet.UseVisualStyleBackColor = false;
            btnOzet.Click += btnOzet_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = SystemColors.AppWorkspace;
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCikis.Location = new Point(204, 310);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(145, 52);
            btnCikis.TabIndex = 25;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.Font = new Font("Segoe UI", 10F);
            lblIndirim.ForeColor = Color.FromArgb(109, 40, 217);
            lblIndirim.Location = new Point(47, 444);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(135, 19);
            lblIndirim.TabIndex = 21;
            lblIndirim.Text = "İndirim uygulanmadı";
            // 
            // txtToplam
            // 
            txtToplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtToplam.Location = new Point(187, 399);
            txtToplam.Name = "txtToplam";
            txtToplam.ReadOnly = true;
            txtToplam.Size = new Size(252, 29);
            txtToplam.TabIndex = 22;
            // 
            // lblToplamBaslik
            // 
            lblToplamBaslik.AutoSize = true;
            lblToplamBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplamBaslik.Location = new Point(47, 402);
            lblToplamBaslik.Name = "lblToplamBaslik";
            lblToplamBaslik.Size = new Size(132, 21);
            lblToplamBaslik.TabIndex = 23;
            lblToplamBaslik.Text = "Ödenecek tutar:";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10F);
            lblDurum.ForeColor = Color.FromArgb(71, 85, 105);
            lblDurum.Location = new Point(12, 9);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(163, 19);
            lblDurum.TabIndex = 24;
            lblDurum.Text = "Bilgileri girip hesaplayınız.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 519);
            Controls.Add(lblDurum);
            Controls.Add(lblIndirim);
            Controls.Add(txtToplam);
            Controls.Add(lblToplamBaslik);
            Controls.Add(btnCikis);
            Controls.Add(btnOzet);
            Controls.Add(btnİndirim);
            Controls.Add(btnHesapla);
            Controls.Add(grpHizmetler);
            Controls.Add(grpEtkinlik);
            Controls.Add(grpBilgiler);
            Controls.Add(lblBaslik);
            Name = "Form1";
            Text = "Etkinlik Kayıt Uygulaması";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            grpEtkinlik.ResumeLayout(false);
            grpEtkinlik.PerformLayout();
            grpBilgiler.ResumeLayout(false);
            grpBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKisiSayisi).EndInit();
            grpHizmetler.ResumeLayout(false);
            grpHizmetler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private GroupBox grpEtkinlik;
        private RadioButton rbKonser;
        private RadioButton rbAtolye;
        private RadioButton rbKonferans;
        private GroupBox grpBilgiler;
        private NumericUpDown nudKisiSayisi;
        private Label lblKisiSayisi;
        private TextBox txtKatilimci;
        private Label lblKatilimci;
        private GroupBox grpHizmetler;
        private CheckBox chkServis;
        private CheckBox chkYemek;
        private Button btnHesapla;
        private Button btnİndirim;
        private Button btnOzet;
        private Button btnCikis;
        private Label lblIndirim;
        private TextBox txtToplam;
        private Label lblToplamBaslik;
        private Label lblDurum;
    }
}
