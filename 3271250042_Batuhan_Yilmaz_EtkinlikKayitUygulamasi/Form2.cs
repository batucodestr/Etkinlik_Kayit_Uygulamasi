using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi
{
    public partial class Form2 : Form
    {
        private readonly double normalFiyat;
        public double indirimliFiyat;
        public bool indirimUygulandi;
        public string indirimAciklamasi = string.Empty;
        public Form2(double toplam)
        {
            InitializeComponent();
            normalFiyat = toplam;
            lblNormalFiyatDeger.Text = normalFiyat.ToString("N2") + " TL";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (cmbIndirim.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "İndirim türünü seçiniz.",
                    "Eksik bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbIndirim.Focus();
                return;
            }

            double oran = 0;

            if (cmbIndirim.SelectedIndex == 0) oran = 0.10;
            if (cmbIndirim.SelectedIndex == 1) oran = 0.20;
            if (cmbIndirim.SelectedIndex == 2) oran = 0;

            indirimliFiyat = normalFiyat * (1 - oran);
            indirimUygulandi = true;
            indirimAciklamasi = cmbIndirim.Text + " - " + (oran * 100).ToString("0") + "%";
            Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUygula.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnIptal.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
