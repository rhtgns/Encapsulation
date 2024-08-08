using System;
public class Program
{
    public static void Main()
    {
        //burada alınan kapı sayisi ile bir araba nesnesi oluştuıacagız 
        Araba araba1 =new Araba("Ford","Focus","Sarı",4);
        Console.WriteLine("Araba 1");
        Console.WriteLine($"Marka: {araba1.Marka}");
        Console.WriteLine($"Model: {araba1.Model}");
        Console.WriteLine($"Renk: {araba1.Renk}");
        Console.WriteLine($"Kapi Sayısı: {araba1.KapSayisi}");


        //burda ise gecerli olmayan kapı sayiis degeri ile işlem yapacagız

        Araba araba2 = new Araba("Audi", "A8", "Siyah", 4);
        Console.WriteLine("\nAraba 2 :");
        Console.WriteLine($"Marka: {araba2.Marka}");
        Console.WriteLine($"Marka: {araba2.Model}");
        Console.WriteLine($"Marka: {araba2.Renk}");
        Console.WriteLine($"Marka: {araba2.KapSayisi}");
    }

}


