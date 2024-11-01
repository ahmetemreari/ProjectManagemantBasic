using System;

public class YazilimGelistirici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum kanka.");
    }
}