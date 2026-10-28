namespace _3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi
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
            lblBaslik = new Label();
            btnIptal = new Button();
            btnUygula = new Button();
            cmbIndirim = new ComboBox();
            lblIndirimTuru = new Label();
            lblNormalFiyatDeger = new Label();
            lblNormalFiyat = new Label();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBaslik.Location = new Point(12, 24);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(230, 32);
            lblBaslik.TabIndex = 8;
            lblBaslik.Text = "İndirim Hesaplama";
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(71, 85, 105);
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIptal.ForeColor = Color.White;
            btnIptal.Location = new Point(205, 190);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(180, 46);
            btnIptal.TabIndex = 9;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnUygula
            // 
            btnUygula.BackColor = Color.FromArgb(124, 58, 237);
            btnUygula.FlatStyle = FlatStyle.Flat;
            btnUygula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUygula.ForeColor = Color.White;
            btnUygula.Location = new Point(12, 190);
            btnUygula.Name = "btnUygula";
            btnUygula.Size = new Size(180, 46);
            btnUygula.TabIndex = 10;
            btnUygula.Text = "İndirimi Uygula";
            btnUygula.UseVisualStyleBackColor = false;
            btnUygula.Click += btnUygula_Click;
            // 
            // cmbIndirim
            // 
            cmbIndirim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIndirim.Font = new Font("Segoe UI", 10F);
            cmbIndirim.FormattingEnabled = true;
            cmbIndirim.Items.AddRange(new object[] { "Öğrenci indirimi", "Kurum indirimi", "İndirim yok" });
            cmbIndirim.Location = new Point(156, 124);
            cmbIndirim.Name = "cmbIndirim";
            cmbIndirim.Size = new Size(229, 25);
            cmbIndirim.TabIndex = 11;
            // 
            // lblIndirimTuru
            // 
            lblIndirimTuru.AutoSize = true;
            lblIndirimTuru.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIndirimTuru.Location = new Point(12, 127);
            lblIndirimTuru.Name = "lblIndirimTuru";
            lblIndirimTuru.Size = new Size(98, 20);
            lblIndirimTuru.TabIndex = 12;
            lblIndirimTuru.Text = "İndirim türü:";
            // 
            // lblNormalFiyatDeger
            // 
            lblNormalFiyatDeger.AutoSize = true;
            lblNormalFiyatDeger.Font = new Font("Segoe UI", 11F);
            lblNormalFiyatDeger.Location = new Point(156, 75);
            lblNormalFiyatDeger.Name = "lblNormalFiyatDeger";
            lblNormalFiyatDeger.Size = new Size(15, 20);
            lblNormalFiyatDeger.TabIndex = 13;
            lblNormalFiyatDeger.Text = "-";
            // 
            // lblNormalFiyat
            // 
            lblNormalFiyat.AutoSize = true;
            lblNormalFiyat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNormalFiyat.Location = new Point(12, 75);
            lblNormalFiyat.Name = "lblNormalFiyat";
            lblNormalFiyat.Size = new Size(102, 20);
            lblNormalFiyat.TabIndex = 14;
            lblNormalFiyat.Text = "Normal fiyat:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 267);
            Controls.Add(btnIptal);
            Controls.Add(btnUygula);
            Controls.Add(cmbIndirim);
            Controls.Add(lblIndirimTuru);
            Controls.Add(lblNormalFiyatDeger);
            Controls.Add(lblNormalFiyat);
            Controls.Add(lblBaslik);
            Name = "Form2";
            Text = "Form2";
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Button btnIptal;
        private Button btnUygula;
        private ComboBox cmbIndirim;
        private Label lblIndirimTuru;
        private Label lblNormalFiyatDeger;
        private Label lblNormalFiyat;
    }
}