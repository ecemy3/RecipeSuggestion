# RecipeSuggestion - Tarif Önerisi Uygulaması

Kullanıcıların tarif ekleyebileceği, düzenleyebileceği, silebileceği ve arayabileceği bir C# Windows Forms uygulaması.

## Özellikler

- ✨ **Tarif Yönetimi**: Yeni tarifler ekleyin, düzenleyin ve silin
- 🔍 **Arama ve Filtreleme**: Tarifler arasında kolayca arama yapın
- 📋 **Malzeme Yönetimi**: Tariflerle ilişkili malzemeleri yönetin
- 📊 **Tarif Detayları**: Her tarife ait ayrıntılı bilgileri görüntüleyin

## Proje Yapısı

```
RecipeSuggestion/
├── DataAcsess/
│   └── DataBase.cs          # Veritabanı işlemleri
├── Models/
│   ├── Tarif.cs             # Tarif modeli
│   ├── Malzeme.cs           # Malzeme modeli
│   └── Tarif_Malzeme.cs     # Tarif-Malzeme ilişkisi
├── Forms/
│   ├── Form1.cs             # Ana form
│   ├── TarifEkle.cs         # Tarif ekleme formu
│   ├── TarifGuncelle.cs     # Tarif güncelleme formu
│   ├── TarifSil.cs          # Tarif silme formu
│   ├── AramaFiltreleme.cs   # Arama ve filtreleme formu
│   └── Detay.cs             # Tarif detay formu
└── README.md

```

## Teknoloji Stack

- **Platform**: .NET 8.0 (Windows)
- **UI**: Windows Forms
- **Dil**: C#
- **Veritabanı**: SQL Server / SQL Compact

## Kurulum

### Gereksinimler
- .NET 8.0 SDK veya üzeri
- Visual Studio 2022 (veya Visual Studio Code)

### Adımlar

1. Repository'yi klonlayın:
```bash
git clone https://github.com/ecemy3/RecipeSuggestion.git
cd RecipeSuggestion
```

2. Bağımlılıkları yükleyin:
```bash
dotnet restore
```

3. Uygulamayı çalıştırın:
```bash
dotnet run
```

## Kullanım

### Ana Ekran
- Tüm tarifler listelenir
- Tarif seçerek detaylarını görebilirsiniz

### Tarif Ekleme
1. "Yeni Tarif Ekle" butonuna tıklayın
2. Tarif bilgilerini girin
3. Malzemeleri ekleyin
4. "Kaydet" butonuna tıklayın

### Tarif Arama
1. "Arama/Filtreleme" kısmını kullanın
2. Tarif adı veya malzeme adı ile arayın

### Tarif Güncelleme
1. Listeden tarifi seçin
2. "Düzenle" butonuna tıklayın
3. Bilgileri güncelleyin
4. "Kaydet" butonuna tıklayın

### Tarif Silme
1. Listeden tarifi seçin
2. "Sil" butonuna tıklayın
3. Silme işlemini onaylayın

## Dosya Yapısı

| Dosya | Açıklama |
|-------|----------|
| `Form1.cs` | Ana uygulama formu |
| `TarifEkle.cs` | Yeni tarif ekleme formu |
| `TarifGuncelle.cs` | Tarif güncelleme formu |
| `TarifSil.cs` | Tarif silme formu |
| `AramaFiltreleme.cs` | Arama ve filtreleme formu |
| `Detay.cs` | Tarif detay görüntüleme formu |
| `DataBase.cs` | Veritabanı işlemlerini yönetir |

## Lisans

Bu proje açık kaynak kodlu olup kişisel kullanım için tasarlanmıştır.

## İletişim

**Geliştirici**: ecemy3  
**GitHub**: [ecemy3](https://github.com/ecemy3)  
**E-mail**: ecemyalcin3434@gmail.com

---

**Son Güncelleme**: Kasım 2025
