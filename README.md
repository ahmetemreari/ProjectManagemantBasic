
# Project Management Basic

Bu proje, bir şirket içindeki farklı çalışan rollerini temsil eden bir C# uygulamasıdır. Uygulama, yazılım geliştiricileri, proje yöneticileri ve satış temsilcilerinin görevlerini simüle eder.

## Özellikler

- **Yazılım Geliştirici**: Yazılım geliştirme görevlerini yerine getirir.
- **Proje Yöneticisi**: Proje yönetimi görevlerini yürütür.
- **Satış Temsilcisi**: Satış süreçlerini yönetir.

## Kullanım

### Gereksinimler

- .NET 6.0 veya üzeri
- C# 8.0 veya üzeri

### Çalıştırma Adımları

1. Projeyi klonlayın veya indirin.
2. Terminal veya komut istemcisinde proje dizinine gidin.
3. Aşağıdaki komutla projeyi çalıştırın:

   ```bash
   dotnet run
   ```

### Örnek Çıktı

```
Yazılım Geliştirici: Ali Veli - Yazılım geliştirme görevleri gerçekleştiriliyor.
Proje Yöneticisi: Ayşe Fatma - Proje yönetimi görevleri yürütülüyor.
Satış Temsilcisi: Mehmet Şevket - Satış süreçleri yönetiliyor.
```

## Kod Yapısı

### `Program.cs`

- **YazilimGelistirici, ProjeYoneticisi, SatisTemsilcisi Sınıfları**: Her bir sınıf, çalışanların adını, soyadını ve departmanını içerir. Ayrıca, her bir çalışanın görevini yerine getiren `Gorev` metoduna sahiptir.

### Örnek Kod

```csharp
class Program
{
    static void Main()
    {
        // Yazılım Geliştirici
        YazilimGelistirici yazilimGelistirici = new YazilimGelistirici
        {
            Ad = "Ali",
            Soyad = "Veli",
            Departman = "Yazılım"
        };
        yazilimGelistirici.Gorev();

        // Proje Yöneticisi
        ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi
        {
            Ad = "Ayşe",
            Soyad = "Fatma",
            Departman = "Proje Yöneticisi"
        };
        projeYoneticisi.Gorev();

        // Satış Temsilcisi
        SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi
        {
            Ad = "Mehmet",
            Soyad = "Şevket",
            Departman = "Satış Temsilcisi"
        };
        satisTemsilcisi.Gorev();

        Console.ReadKey();
    }
}
```

## Katkıda Bulunma

Herhangi bir öneri veya hata bildirimi için lütfen bir [sorun](https://github.com/ahmetemreari/ProjectManagemantBasic.git/issues) oluşturun.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için lütfen [LICENSE](LICENSE) dosyasını kontrol edin.

```

