using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi
{
    public partial class Form3 : Form
    {
        public Form3(
        string katilimci,
        string etkinlik,
        int kisiSayisi,
        string ekHizmetler,
        double normalToplam,
        double odenecekToplam,
        string indirimBilgisi)
        {
            InitializeComponent();

            lblKatilimciDeger.Text = katilimci;
            lblEtkinlikDeger.Text = etkinlik;
            lblKisiDeger.Text = kisiSayisi.ToString();
            lblHizmetDeger.Text = ekHizmetler;
            lblNormalDeger.Text = normalToplam.ToString("N2") + " TL";
            lblIndirimDeger.Text = indirimBilgisi;
            lblOdenecekDeger.Text = odenecekToplam.ToString("N2") + " TL";

            SonucNesnesiOlustur(katilimci, etkinlik, odenecekToplam);
        }

        private void SonucNesnesiOlustur(string katilimci, string etkinlik, double tutar)
        {
            Button sonucButonu = new Button();
            sonucButonu.Text = katilimci + "\n" + etkinlik + "\n" + tutar.ToString("N2") + " TL";
            sonucButonu.Size = new Size(310, 90);
            sonucButonu.Location = new Point(277, 382);
            sonucButonu.BackColor = Color.FromArgb(204, 251, 241);
            sonucButonu.ForeColor = Color.FromArgb(15, 118, 110);
            sonucButonu.FlatStyle = FlatStyle.Flat;
            sonucButonu.FlatAppearance.BorderColor = Color.FromArgb(94, 234, 212);
            sonucButonu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Controls.Add(sonucButonu);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.SuppressKeyPress = true;
            }
        }
    }
}
