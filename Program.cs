using System.ComponentModel;

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