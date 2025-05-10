// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Hangi meyveyi satın almak istiyorsunuz? ");
        string fruit = Console.ReadLine().ToLower(); // büyük-küçük harf duyarlılığını kaldırdık

        switch (fruit)
        {
            case "elma":
                Console.WriteLine("Elmanın fiyatı 2 TL'dir. ");
                break;

            case "armut":
                Console.WriteLine("Armutun fiyatı 3 TL'dir. ");
                break;

            case "çilek":
                Console.WriteLine("Çileğin fiyatı 2 TL'dir. ");
                break;

            case "muz":
                Console.WriteLine("Muzun fiyatı 3 TL'dir. ");
                break;

            default:
                Console.WriteLine("Diğer meyvelerin fiyatı 4 TL'dir. ");
                break;

                // Bu tür sabit, sınırlı ve belirli değerlere göre işlem yapılacak durumlarda switch-case kullanmak daha uygundur.
                // Çünkü:
                // 1. Daha okunabilir ve temizdir.
                // 2. Performans açısından daha verimlidir.
                // 3. Geliştirici için hata yapma riski daha azdır.

                // if-else yapısı ise daha karmaşık karşılaştırmalarda (örneğin büyüktür/küçüktür gibi mantıksal işlemlerde) tercih edilmelidir. Aşağıda bulabilirsiniz.


                // if (fruit == "elma")
                // {
                //     Console.WriteLine("Elma'nın fiyatı: 2 TL");
                // }
                // else if (fruit == "armut")
                // {
                //     Console.WriteLine("Armut'un fiyatı: 3 TL");
                // }
                // else if (fruit == "çilek")
                // {
                //     Console.WriteLine("Çilek'in fiyatı: 2 TL");
                // }
                // else if (fruit == "muz")
                // {
                //     Console.WriteLine("Muz'un fiyatı: 3 TL");
                // }
                // else
                // {
                //     Console.WriteLine("Diğer meyvelerin fiyatı: 4 TL");
                // }
        }
    }
}


