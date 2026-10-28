# Etkinlik Kayıt Uygulaması

Windows Forms ile geliştirilmiş, etkinlik katılım ücretlerini hızlı ve anlaşılır bir şekilde hesaplamaya yarayan masaüstü uygulaması.

## Özellikler

- Katılımcı adı ve kişi sayısı bilgilerini alma
- Konferans, atölye ve konser seçenekleri
- Yemek ve servis gibi ek hizmetleri ücrete dahil etme
- Kişi sayısına göre toplam ücret hesaplama
- Öğrenci, grup ve erken kayıt indirimlerini uygulama
- Kayıt bilgilerini ve ücret özetini ayrı bir pencerede görüntüleme
- Eksik veya hatalı girişlerde kullanıcıyı bilgilendirme
- Klavye kısayolları ile hızlı kullanım

## Kullanılan Teknolojiler

- **Platform:** .NET 10
- **Arayüz:** Windows Forms
- **Dil:** C#
- **Proje türü:** SDK-style Windows masaüstü uygulaması

## Ücretlendirme

| Etkinlik | Kişi başı ücret |
| --- | ---: |
| Konferans | 400 TL |
| Atölye | 300 TL |
| Konser | 250 TL |

Ek hizmetler:

- Yemek: kişi başı 150 TL
- Servis: kişi başı 75 TL

İndirim seçenekleri:

- Öğrenci indirimi: %10
- Grup indirimi: %20
- İndirim yok: %0

## Klavye Kısayolları

| Kısayol | İşlev |
| --- | --- |
| `Enter` | Ücreti hesaplar |
| `Ctrl + I` | İndirim penceresini açar |
| `F2` | Kayıt özetini görüntüler |
| `Esc` | Uygulamadan çıkış işlemini başlatır |

## Gereksinimler

- Windows 10 veya üzeri
- .NET 10 SDK veya Visual Studio 2026
- Windows Forms geliştirme iş yükü

## Çalıştırma

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/batucodestr/Etkinlik_Kayit_Uygulamasi.git
   cd Etkinlik_Kayit_Uygulamasi
   ```

2. Çözümü Visual Studio ile açın veya aşağıdaki komutları çalıştırın:

   ```bash
   dotnet restore
   dotnet run --project 3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi/3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi.csproj
   ```

> Uygulama Windows Forms kullandığı için Windows üzerinde çalıştırılmalıdır.

## Proje Yapısı

```text
├── 3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi.slnx
├── README.md
└── 3271250042_Batuhan_Yilmaz_EtkinlikKayitUygulamasi/
	├── Form1.cs                 # Ana kayıt ve ücret hesaplama ekranı
	├── Form2.cs                 # İndirim ekranı
	├── Form3.cs                 # Kayıt özeti ekranı
	├── Program.cs               # Uygulama başlangıç noktası
	└── *.Designer.cs / *.resx   # Windows Forms tasarım ve kaynak dosyaları
```

## Lisans

Bu proje eğitim amacıyla geliştirilmiştir.
