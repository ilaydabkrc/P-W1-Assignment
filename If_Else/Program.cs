// See https://aka.ms/new-console-template for more information
using System;

//Bu pratik uygulamasında sizlerden konsol ekranı yardımıyla kullanıcıdan bir sayı değeri almanızı, bu değerin 10'a eşit mi , 10'dan küçük mü, 10'dan büyük mü olduğu durumları kontrol ederek kullanıcıya bir bilgilendirme mesajı yazmanız isteniyor.

//Ardından 2.bir kontrol yapısıyla girilen sayının çift mi yoksa tek mi olduğunu ekrana yazdırınız.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı giriniz : ");
        int num = Convert.ToInt32(Console.ReadLine()); 
        //10 ile karşılaştırma
        if (num == 10){
            Console.WriteLine("Girdiğiniz sayı 10'a eşit. ");
        }
        else if (num < 10){
            Console.WriteLine("Girdiğiniz sayı 10'dan küçük. ");
        }
        else{
            Console.WriteLine("Girdiğiniz sayı 10'dan büyük. ");
        }
        if (num % 2 == 0){
            Console.WriteLine("Girdiğiniz sayı çift sayıdır. ");
        }
        else{
            Console.WriteLine("Girdiğiniz sayı tek sayıdır. ");
        }
    }

}