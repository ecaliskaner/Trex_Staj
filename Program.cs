using System;

namespace Trex
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write/Read 
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Alt Satıra İndririr");

            #endregion
            #region Variables
            int plaka = 16; // Değişken tanımlama
            string sehir = "Bursa"; // String değişken tanımlama

            Console.WriteLine(sehir + " plakası " + plaka); // Değişkeni yazdırma
            #endregion
            #region input
            Console.Write("İsminizi Giriniz: ");
            string isim = Console.ReadLine(); // Kullanıcıdan veri alma
            Console.Write("Yaşınızı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine()); // Kullanıcıdan sayı alma ve string'ten int'e dönüştürme
            Console.WriteLine(isim + ": " + " yaş: " + sayi); // Kullanıcıdan alınan veriyi yazdırma
            #endregion
            #region Foreach
            string[] cities = { "Paris", "Londra", "Berlin", "New York" };
            foreach (string city in cities)
            {
                Console.WriteLine(city); // Dizi elemanlarını yazdırma
            }
            
        }
    }
}
