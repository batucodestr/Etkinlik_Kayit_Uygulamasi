namespace _3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi
{
    public partial class Form1 : Form
    {
        private double normalToplam;
        private double odenecekToplam;
        private bool hesaplandi;
        private bool indirimUygulandi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDurum.Text = "Bilgileri Girip Ücreti Hesaplayınız.";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (!BilgileriKontrolEt())
            {
                return;
            }

            double kisiBasiUcret = 0;

            if (rbKonferans.Checked) kisiBasiUcret = 400;
            if (rbAtolye.Checked) kisiBasiUcret = 300;
            if (rbKonser.Checked) kisiBasiUcret = 250;

            int kisi_sayisi = Convert.ToInt32(nudKisiSayisi.Value);
            normalToplam = kisiBasiUcret * kisi_sayisi;

            if (chkYemek.Checked) normalToplam += 150 * kisi_sayisi;
            if (chkServis.Checked) normalToplam += 75 * kisi_sayisi;

            odenecekToplam = normalToplam;
            hesaplandi = true;
            indirimUygulandi = false;

            txtToplam.Text = odenecekToplam.ToString("N2") + " TL";
            lblIndirim.Text = "İndirim uygulanmadı";
            lblDurum.Text = "Ücret hesaplandı. Ctrl+I ile indirim penceresini açabilirsiniz.";
            lblDurum.ForeColor = Color.FromArgb(21, 128, 61);

        }

        private void btnİndirim_Click(object sender, EventArgs e)
        {
            if (hesaplandi == false)
            {
                MessageBox.Show("Lütfen önce ücreti hesaplayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 indirim = new Form2(normalToplam);
            indirim.ShowDialog();

            if (indirim.indirimUygulandi)
            {
                odenecekToplam = indirim.indirimliFiyat;
                indirimUygulandi = true;
                txtToplam.Text = odenecekToplam.ToString("N2") + " TL";
                lblIndirim.Text = indirim.indirimAciklamasi;
                lblDurum.Text = "İndirim uygulandı. F2 ile kayıt özetini açabilirsiniz.";
                lblDurum.ForeColor = Color.FromArgb(21, 128, 61);
            }
        }

        private bool BilgileriKontrolEt()
        {
            if (string.IsNullOrWhiteSpace(txtKatilimci.Text))
            {
                MessageBox.Show("Lütfen katılımcı adını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKatilimci.Focus();
                return false;
            }
            if (!rbAtolye.Checked && !rbKonser.Checked && !rbKonferans.Checked)
            {
                MessageBox.Show("Lütfen etkinlik türünü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rbKonferans.Focus();
                return false;
            }
            return true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnHesapla.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                btnİndirim.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnOzet.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCikis.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOzet_Click(object sender, EventArgs e)
        {
            if (!hesaplandi)
            {
                MessageBox.Show("Lütfen önce ücreti hesaplayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string etkinlik = EtkinlikTuruGetir();
            string ekHizmetler = EkHizmetleriGetir();

            Form3 ozetFormu = new Form3(
                txtKatilimci.Text.Trim(),
                etkinlik,
                Convert.ToInt32(nudKisiSayisi.Value),
                ekHizmetler,
                normalToplam,
                odenecekToplam,
                indirimUygulandi ? lblIndirim.Text : "İndirim yok");

            ozetFormu.ShowDialog();
        }

        private string EtkinlikTuruGetir()
        {
            if (rbKonferans.Checked) return "Konferans";
            if (rbAtolye.Checked) return "Atölye";
            return "Konser";
        }

        private string EkHizmetleriGetir()
        {
            List<string> hizmetler = new List<string>();
            if (chkYemek.Checked) hizmetler.Add("Yemek");
            if (chkServis.Checked) hizmetler.Add("Servis");

            if (hizmetler.Count == 0) return "Ek hizmet yok";
            return string.Join(", ", hizmetler);
        }
    }
}
