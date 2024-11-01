//ad,soyad,departman
using System;
public abstract class Calisan
{
    public required string Ad { get; set; }
    public required string Soyad { get; set; }
    public required string Departman { get; set; }
    public abstract void Gorev();
}
