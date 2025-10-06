# Windows Forms Uygulamaları

Bu proje, C# Windows Forms ile geliştirilmiş çeşitli masaüstü uygulamalarını içeren bir eğitim/demo çözümüdür.

## 📋 İçindekiler

- [Genel Bakış](#genel-bakış)
- [Gereksinimler](#gereksinimler)
- [Kurulum](#kurulum)
- [Projeler](#projeler)
- [Kullanım](#kullanım)
- [Teknolojiler](#teknolojiler)

## 🎯 Genel Bakış

Bu solution, Windows Forms framework'ü kullanılarak geliştirilmiş 9 farklı uygulama içermektedir. Her bir proje, farklı bir özelliği veya konsepti göstermek üzere tasarlanmıştır.

## 💻 Gereksinimler

- **Visual Studio 2017 veya üzeri** (Visual Studio 2022 önerilir)
- **.NET Framework 4.8.1** (çoğu proje için)
- **.NET 9.0** (SystemIOForm için)
- **Windows İşletim Sistemi** (Windows 10/11)

## 🚀 Kurulum

1. Repoyu klonlayın:
```bash
git clone [repository-url]
```

2. `Form.sln` dosyasını Visual Studio ile açın

3. Solution'ı derleyin:
   - Solution Explorer'da solution'a sağ tıklayın
   - "Build Solution" seçeneğini seçin veya `Ctrl+Shift+B` tuşlarına basın

4. İstediğiniz projeyi başlangıç projesi olarak ayarlayın:
   - Solution Explorer'da projeye sağ tıklayın
   - "Set as Startup Project" seçeneğini seçin

## 📦 Projeler

### 1. VeriTransferi
**Açıklama:** Veri aktarımı ve form yönetimi uygulaması

**Özellikler:**
- Form1 ve Form2 arası veri transferi
- Temel veri aktarım mekanizmaları

**Target Framework:** .NET Framework 4.8.1

---

### 2. KullanıcıGirisFormu
**Açıklama:** Kullanıcı giriş ve yönetim sistemi

**Özellikler:**
- Kullanıcı kimlik doğrulama
- Admin paneli (AdminForm)
- Kullanıcı bilgilerini güncelleme
- Bildirim sistemi (NotifyIcon)

**Formlar:**
- Giriş Formu
- Admin Formu (Kullanıcı bilgileri güncelleme)

**Target Framework:** .NET Framework 4.8.1

---

### 3. TCDogrulaServis
**Açıklama:** T.C. Kimlik numarası doğrulama uygulaması

**Özellikler:**
- KPS (Kimlik Paylaşım Sistemi) Public SOAP servisi entegrasyonu
- TC Kimlik No doğrulama
- Ad, Soyad ve Doğum Yılı kontrolü
- Web servis bağlantısı

**Kullanılan Servisler:**
- KPS Public SOAP API

**Target Framework:** .NET Framework 4.8.1

---

### 4. BtnUret
**Açıklama:** Dinamik buton oluşturma uygulaması

**Özellikler:**
- Runtime'da dinamik olarak buton oluşturma
- Buton kontrol örnekleri

**Target Framework:** .NET Framework 4.8.1

---

### 5. ComboBoxInceleme
**Açıklama:** ComboBox kontrolü kullanım örnekleri

**Özellikler:**
- ComboBox temel kullanımı
- Veri bağlama
- Event yönetimi

**Target Framework:** .NET Framework 4.8.1

---

### 6. CheckBoxInceleme
**Açıklama:** CheckBox kontrolü kullanım örnekleri

**Özellikler:**
- CheckBox temel kullanımı
- Çoklu seçim senaryoları
- State yönetimi

**Target Framework:** .NET Framework 4.8.1

---

### 7. GridViewFakeData
**Açıklama:** DataGridView ile sahte veri gösterimi

**Özellikler:**
- DataGridView kullanımı
- Sahte veri üretimi ve gösterimi
- Tablo veri yönetimi

**Target Framework:** .NET Framework 4.8.1

---

### 8. SystemIOForm
**Açıklama:** System.IO namespace kullanım örnekleri

**Özellikler:**
- Dosya okuma/yazma işlemleri
- Dizin yönetimi
- FakeData kütüphanesi kullanımı

**Paketler:**
- FakeData v1.0.0

**Target Framework:** .NET 9.0

---

### 9. ConsoleApp1
**Açıklama:** Konsol tabanlı yardımcı uygulama

**Target Framework:** .NET Framework 4.8.1

---

## 🔧 Kullanım

### TCDogrulaServis Kullanımı

```csharp
// TC Kimlik doğrulama örneği
long tcKimlikNo = 12345678901;
string ad = "Ahmet";
string soyad = "Yılmaz";
int dogumYili = 1990;

// Servis çağrısı
bool sonuc = client.TCKimlikNoDogrula(tcKimlikNo, ad, soyad, dogumYili);
```

### VeriTransferi Kullanımı

```csharp
// Form1'den Form2'ye veri gönderme
Form2 form2 = new Form2();
form2.VeriyiAl(veri);
form2.Show();
```

### Dinamik Buton Oluşturma (BtnUret)

```csharp
// Runtime'da buton oluşturma
Button btn = new Button();
btn.Text = "Yeni Buton";
btn.Location = new Point(x, y);
this.Controls.Add(btn);
```

## 🛠️ Teknolojiler

- **C#** - Programlama dili
- **Windows Forms** - UI Framework
- **.NET Framework 4.8.1** - Runtime (çoğu proje için)
- **.NET 9.0** - Runtime (SystemIOForm için)
- **SOAP Web Services** - TC doğrulama için
- **Visual Studio** - Geliştirme ortamı

## 📝 Notlar

- TCDogrulaServis uygulamasının çalışması için internet bağlantısı gereklidir
- Bazı projeler eğitim amaçlıdır ve production ortamında kullanılmadan önce güvenlik incelemeleri yapılmalıdır
- Her proje bağımsız olarak çalıştırılabilir


## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

**Son Güncelleme:** 2024
**Visual Studio Version:** 17.11.35327.3
