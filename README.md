# 🎓 Öğrenci ve Öğretim Görevlisi Bilgi Sistemi

Bu proje, C# Windows Forms ve MySQL kullanılarak geliştirilmiş bir Öğrenci ve Öğretim Görevlisi Bilgi Sistemi uygulamasıdır. Uygulama, öğrenci ve öğretim görevlilerinin kayıt, giriş, ders işlemleri, not ve devamsızlık takibi gibi işlemleri gerçekleştirmelerini sağlar.

## 🚀 Özellikler

### Öğrenci Modülü

- **Kayıt ve Giriş:** TC Kimlik ve Okul Numarası ile kayıt ve giriş işlemleri.
- **Ders Kayıt:** Öğretim görevlileri tarafından tanımlanan derslere kayıt olma.
- **Not Görüntüleme:** Alınan derslerin vize ve final notlarını görüntüleme.
- **Devamsızlık Takibi:** Ders bazlı devamsızlık bilgilerini görüntüleme.
- **Transkript:** Tüm derslerin notlarını ve genel not ortalamasını (GANO) görüntüleme ve PDF olarak yazdırma.

### Öğretim Görevlisi Modülü

- **Kayıt ve Giriş:** TC Kimlik ve Sicil Numarası ile kayıt ve giriş işlemleri.
- **Ders Tanımlama:** Yeni dersler tanımlama ve kredi bilgilerini belirleme.
- **Yoklama Girişi:** Ders bazlı yoklama bilgilerini girme.
- **Not Girişi:** Öğrencilerin vize ve final notlarını girme.
- **Öğrenci Listesi:** Ders bazlı öğrenci listelerini görüntüleme ve PDF olarak yazdırma.

## 🛠️ Teknolojiler

- **Programlama Dili:** C#
- **Geliştirme Ortamı:** Visual Studio 2022
- **Veritabanı:** MySQL
- **PDF Oluşturma:** iTextSharp kütüphanesi

## 📦 Kurulum ve Kullanım

1. **Veritabanı Kurulumu:**
   - MySQL'i indirip kurun.
   - `ogrenci_sistemi` adlı bir veritabanı oluşturun.
   - Aşağıdaki SQL komutlarını kullanarak tabloları oluşturun:

     ```sql
     -- Öğrenciler Tablosu
     CREATE TABLE ogrenciler (
         id INT AUTO_INCREMENT PRIMARY KEY,
         tc_kimlik VARCHAR(11) NOT NULL,
         okul_no VARCHAR(6) NOT NULL,
         ad VARCHAR(50),
         soyad VARCHAR(50),
         sifre VARCHAR(50)
     );

     -- Öğretim Görevlileri Tablosu
     CREATE TABLE ogretmenler (
         id INT AUTO_INCREMENT PRIMARY KEY,
         tc_kimlik VARCHAR(11) NOT NULL,
         sicil_no VARCHAR(6) NOT NULL,
         ad VARCHAR(50),
         soyad VARCHAR(50),
         sifre VARCHAR(50)
     );

     -- Dersler Tablosu
     CREATE TABLE dersler (
         id INT AUTO_INCREMENT PRIMARY KEY,
         ders_adi VARCHAR(100),
         kredi INT,
         ogretmen_id INT,
         FOREIGN KEY (ogretmen_id) REFERENCES ogretmenler(id)
     );

     -- Ders Kayıtları Tablosu
     CREATE TABLE ders_kayitlari (
         id INT AUTO_INCREMENT PRIMARY KEY,
         ogrenci_id INT,
         ders_id INT,
         FOREIGN KEY (ogrenci_id) REFERENCES ogrenciler(id),
         FOREIGN KEY (ders_id) REFERENCES dersler(id)
     );

     -- Notlar Tablosu
     CREATE TABLE notlar (
         id INT AUTO_INCREMENT PRIMARY KEY,
         ogrenci_id INT,
         ders_id INT,
         vize DOUBLE,
         final DOUBLE,
         FOREIGN KEY (ogrenci_id) REFERENCES ogrenciler(id),
         FOREIGN KEY (ders_id) REFERENCES dersler(id)
     );

     -- Devamsızlık Tablosu
     CREATE TABLE devamsizlik (
         id INT AUTO_INCREMENT PRIMARY KEY,
         ogrenci_id INT,
         ders_id INT,
         tarih DATE,
         saat TIME,
         durum ENUM('var', 'yok'),
         FOREIGN KEY (ogrenci_id) REFERENCES ogrenciler(id),
         FOREIGN KEY (ders_id) REFERENCES dersler(id)
     );
   

2. **Proje Kurulumu:**
   - Visual Studio 2022'yi açın.
   - `OgrenciSistemi.sln` dosyasını açın.
   - Gerekli NuGet paketlerini yükleyin:
     - `MySql.Data`
     - `iTextSharp`

3. **Bağlantı Dizesi Güncelleme:**
   - Proje içindeki veritabanı bağlantı dizesini kendi MySQL kullanıcı adı ve şifrenize göre güncelleyin.

4. **Uygulamayı Çalıştırma:**
   - Projeyi derleyin ve çalıştırın.
   - Giriş ekranından öğrenci veya öğretim görevlisi olarak giriş yapın.

## 📄 Ekran Görüntüleri

*Ekran görüntüleri buraya eklenecek.*

## 📜 Lisans

Bu proje MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını inceleyin.

