using System;
//Bir bilgi yarışması yapıyoruz!

//2 cevap şıklı 3 adet sorumuz var ! ( Aşağıdaki sorular örnektir, kendi sorularınızla programı editleyebilirsiniz.)

//2 cevap şıklı 3 adet sorumuz var ! ( Aşağıdaki sorular örnektir, kendi sorularınızla programı editleyebilirsiniz.)
//1->Kızınca tüküren hayvan hangisidir ? a) Lama b) Deve

//2->Dünya'ya en yakın gezegen hangisidir ? a) Venüs b) Mars
//3-> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?a) 7 b) 12

//Yarışmacı 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik büyük ödülü kazanacak!

//Bu uygulamada kullanıcının doğru cevaplarını saymak için bir değişkene ihtiyacımız olduğunu unutmayın !

//Akış -> Kullanıcıya birinci soruyu soruyoruz ve cevabı alıyoruz. ( A ya da B şeklinde - Büyük küçük harf duyarlılığı olmasın!) ,
//Ardından cevabın doğruluk durumuna göre bir mesaj ile kullanıcıya durumu bildiriyoruz. 

//İlk 2 soruya cevap veren kullanıcının büyük ödülü kazanma ihtimali ortadan kalktığı için 3. soruyu sormuyoruz.

//Final neticesinde kullanıcıya büyük ödülü kazanıp kazanmadığını bir konsol mesajıyla bildiriyoruz.
class Program
{
    static void Main()
    {
        int correctCount = 0;

        //1.soru
        Console.WriteLine("Kızınca tüküren hayvan hangisidir ?");
        Console.WriteLine(" a) Lama b) Deve");
        Console.WriteLine("Cevabınız : ");

        string answer1 = Console.ReadLine().ToLower();
        if (answer1 == "a")
        {
            Console.WriteLine("Doğru cevap. Tebrikler ");
            correctCount++;
        }
        else
        {
            Console.WriteLine("Cevabınız yanlış.");
        }

        //2.soru
        Console.WriteLine("Dünya'ya en yakın gezegen hangisidir? ");
        Console.WriteLine("a) Venüs b) Mars ");
        Console.WriteLine("Cevabınız : ");

        string answer2 = Console.ReadLine().ToLower();

        if (answer2 == "a")
        {
            Console.WriteLine("Cevabınız doğru. Tebrikler ");
            correctCount++;
        }
        else
        {
            Console.WriteLine("Cevabınız yanlış. ");
        }

        if (correctCount == 2)
        {
            Console.WriteLine("Tebrikler büyük ödülü kazandınız! ");
            return;
        }
        else if (correctCount == 0)
        {
            Console.WriteLine("Üzgünüz, 3 soruda en az 2 doğru yanıt gerektiğinden 3. soruyu görmeniz gereksiz. Büyük ödülü kazanma şansınız kalmadı");
            return;
        }
        else
        {
            Console.WriteLine("\n3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
            Console.WriteLine("a) 7\tb) 12");
            Console.Write("Cevabınız: ");
            string answer3 = Console.ReadLine().ToLower();

            if (answer3 == "b")
            {
                Console.WriteLine("Tebrikler doğru cevap. ");
                correctCount++;
            }
            else
            {
                Console.WriteLine("Cevabınız Yanlış. ");
            }
        }

        //sonuc
        if (correctCount >= 2)
        {
            Console.WriteLine("Tebrikler büyük ödülü kazandınız! ");
        }
        else
        {
            Console.WriteLine("Üzgünüz büyük ödülü kaybettiniz. ");
        }
    }
}
