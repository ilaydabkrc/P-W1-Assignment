// See https://aka.ms/new-console-template for more information

//1.Konsola "Merhaba Dünya" yazdıran bir program yazın.
Console.WriteLine("Hello, World!");

//2. Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.
Console.WriteLine("Birinci sayıyı giriniz.");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz.");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = number1 + number2;
Console.WriteLine("Girdiğiniz sayıların toplamı " + sum);

//3. Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.
Console.WriteLine("Lütfen yaşınızı giriniz. ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Yetişkinsiniz");
}
else
{
    Console.WriteLine("Çocuksunuz");
}

//4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.
Console.WriteLine("Lütfen bir sayı giriniz. ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çift sayıdır.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
}

//5. Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın.
Console.WriteLine("Lütfen bir sıcaklık değeri giriniz.");
int temperature = Convert.ToInt32(Console.ReadLine());

if (temperature <= 0)
{
    Console.WriteLine("Donuyorsunuz.");
}
else if (temperature <= 30)
{
    Console.WriteLine("Normal. ");
}
else
{
    Console.WriteLine("Sıcak. ");
}

//6. Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.
Console.WriteLine("Lütfen 1-7 arası bir sayı giriniz. ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Pazartesi.");
}
else if (day == 2)
{
    Console.WriteLine("Salı");
}
else if (day == 3)
{
    Console.WriteLine("Çarşamba");
}
else if (day == 4)
{
    Console.WriteLine("Perşembe");
}
else if (day == 5)
{
    Console.WriteLine("Cuma");
}
else if (day == 6)
{
    Console.WriteLine("Cumartesi");
}
else if (day == 7)
{
    Console.WriteLine("Pazar");
}
else
{
    Console.WriteLine("Geçersiz gün");
}

//7. Kullanıcıdan bir not (0-100 arasında) alın.Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)
Console.WriteLine("Lütfen notunuzu girin. ");
int grade = Convert.ToInt32(Console.ReadLine());

if (grade <= 60)
{
    Console.WriteLine("Başarısız. ");
}
else if (grade <= 80)
{
    Console.WriteLine("Orta. ");
}
else
{
    Console.WriteLine("Başarılı. ");
}

//8.Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.
Console.WriteLine("Bir ay numarası girin.");
int month = Convert.ToInt32(Console.ReadLine());

if (month == 2)
{
    Console.WriteLine("Şubat. ");
}
else if (month == 4 || month == 6 || month == 9 || month == 11)
{
    Console.WriteLine("30 gün. ");
}
else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
{
    Console.WriteLine("31 gün. ");
}
else
{
    Console.WriteLine("Geçersiz bir sayı girdiniz. ");
}

//9. Kullanıcıdan bir şifre isteyin. Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.
Console.WriteLine("Şifreyi giriniz. ");
string password = Console.ReadLine();
if (password == "12345")
{
    Console.WriteLine("Giriş Başarılı. ");
}
else
{
    Console.WriteLine("Giriş Başarısız. ");
}

//10. Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın.Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.
Console.WriteLine("Birinci sayıyı giriniz. ");
int inputNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz. ");
int inputNumber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen bir işlem seçiniz. (+, -, *, /) ");
char operation = Convert.ToChar(Console.ReadLine());

if (operation == '+')
{
    Console.WriteLine("Sayırların toplamı = " + (inputNumber1 + inputNumber2));
}
else if (operation == '-')
{
    Console.WriteLine("Sayıların farkı = " + (inputNumber1 - inputNumber2));
}
else if (operation == '*')
{
    Console.WriteLine("Sayıların çarpımı = " + (inputNumber1 * inputNumber2));
}
else
{
    Console.WriteLine("Sayıların bölümü = " + (inputNumber1 / inputNumber2));
}
