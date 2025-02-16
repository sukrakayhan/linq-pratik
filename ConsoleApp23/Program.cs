using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rasgele sayılardan oluşan bir liste oluşturuyoruz. 
        // Negatif ve sayısal çeşitlilik sağlamak için Random.Next kullanarak -50 ile 50 arasında sayılar seçiyoruz.
        Random random = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 51));
        }

        // Aşağıda listeyi ekrana yazdırıyoruz.
        Console.WriteLine("Orijinal Sayı Listesi:");
        numbers.ForEach(n => Console.WriteLine(n));

        // Çift sayıları bulmak için LINQ kullanıyoruz.
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("\nÇift Sayılar:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Tek sayıları bulmak için LINQ kullanıyoruz.
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("\nTek Sayılar:");
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }

        // Negatif sayıları bulmak için LINQ kullanıyoruz.
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("\nNegatif Sayılar:");
        foreach (var num in negativeNumbers)
        {
            Console.WriteLine(num);
        }

        // Pozitif sayıları bulmak için LINQ kullanıyoruz.
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("\nPozitif Sayılar:");
        foreach (var num in positiveNumbers)
        {
            Console.WriteLine(num);
        }

        // 15'ten büyük ve 22'den küçük sayıları bulmak için LINQ kullanıyoruz.
        var between15And22 = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("\n15'ten Büyük ve 22'den Küçük Sayılar:");
        foreach (var num in between15And22)
        {
            Console.WriteLine(num);
        }

        // Her sayının karesini alan yeni bir liste oluşturuyoruz.
        var squares = numbers.Select(n => n * n);
        Console.WriteLine("\nHer Sayının Karesi:");
        foreach (var square in squares)
        {
            Console.WriteLine(square);
        }
    }
}