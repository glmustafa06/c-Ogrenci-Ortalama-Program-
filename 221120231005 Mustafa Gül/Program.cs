using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Sınıfta kaç öğrenci var? ");
        int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

        List<string> ogrenciAdlari = new List<string>();
        List<int> ogrenciNotlari = new List<int>();

        // Öğrencilerin adını ve notunu alma
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.Write($"\n{i + 1}. öğrencinin adını girin: ");
            string ad = Console.ReadLine();
            ogrenciAdlari.Add(ad);

            int notu;
            do
            {
                Console.Write($"{ad} öğrencisinin notunu girin (0-100 arası): ");
                notu = Convert.ToInt32(Console.ReadLine());
            } while (notu < 0 || notu > 100);

            ogrenciNotlari.Add(notu);
        }

        // Sınıf ortalamasını hesaplama
        double ortalama = ogrenciNotlari.Average();
        Console.WriteLine($"\nSınıfın not ortalaması: {ortalama:F2}");

        // En yüksek ve en düşük notu bulma
        int enYuksekNot = ogrenciNotlari.Max();
        int enDusukNot = ogrenciNotlari.Min();

        int enBasariliIndex = ogrenciNotlari.IndexOf(enYuksekNot);
        int enZayifIndex = ogrenciNotlari.IndexOf(enDusukNot);

        Console.WriteLine($"\nEn yüksek not: {ogrenciAdlari[enBasariliIndex]} - {enYuksekNot}");
        Console.WriteLine($"En düşük not: {ogrenciAdlari[enZayifIndex]} - {enDusukNot}");

        // Geçen ve kalan öğrencileri yazdırma
        Console.WriteLine("\nGeçen öğrenciler (Not >= 50):");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            if (ogrenciNotlari[i] >= 50)
            {
                Console.WriteLine($"{ogrenciAdlari[i]} - {ogrenciNotlari[i]} (Geçti)");
            }
        }

        Console.WriteLine("\nKalan öğrenciler (Not < 50):");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            if (ogrenciNotlari[i] < 50)
            {
                Console.WriteLine($"{ogrenciAdlari[i]} - {ogrenciNotlari[i]} (Kaldı)");
            }
        }

        // Sınıf ortalamasına göre başarılı ve başarısız öğrencileri yazdırma
        Console.WriteLine("\nSınıf ortalamasının üstünde veya eşit olan öğrenciler:");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            if (ogrenciNotlari[i] >= ortalama)
            {
                Console.WriteLine($"{ogrenciAdlari[i]} - {ogrenciNotlari[i]}");
            }
        }

        Console.WriteLine("\nSınıf ortalamasının altında kalan öğrenciler:");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            if (ogrenciNotlari[i] < ortalama)
            {
                Console.WriteLine($"{ogrenciAdlari[i]} - {ogrenciNotlari[i]}");
            }
        }

        // En başarılı ve en zayıf öğrenciyi yazdırma
        Console.WriteLine($"\nEn başarılı öğrenci: {ogrenciAdlari[enBasariliIndex]} - {ogrenciNotlari[enBasariliIndex]}");
        Console.WriteLine($"En zayıf öğrenci: {ogrenciAdlari[enZayifIndex]} - {ogrenciNotlari[enZayifIndex]}");
    }
}
