class Program
{
    // Kullanıcıya T.C Kimlik Numarasını, adını, soyadını , telefon numarasını, yaşını,
    // ilk aldığı ürünün fiyatını, ikinci aldığını ürünün fiyatını soran ve bu değerleri
    // kullanıcıdan sırasıyla alan bir uygulama kodlayınız. Uygulama girilen ürün fiyatına göre aşağıdaki gibi bir mesaj yayınlasın.
    static void Main(string[] args)
    {
        // Get user information
        Console.WriteLine("Lütfen TC kimlik numaranızı giriniz. ");
        string nationalId = Console.ReadLine();

        Console.WriteLine("Lütfen adınızı giriniz. ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Lütfen soyadınızı giriniz. ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Lütfen telefon numaranızı giriniz. ");
        string phoneNumber = Console.ReadLine();
        // Phone number kept as string due to possible leading '0' and no math operation.

        Console.WriteLine("Lütfen yaşınızı giriniz. ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen ilk aldığınız ürünün fiyatını giriniz. ");
        double productPrice1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci aldığınız ürünün fiyatını giriniz. ");
        double productPrice2 = Convert.ToDouble(Console.ReadLine());
        // Used double for product prices as they may include decimals

        double totalPrice = productPrice1 + productPrice2;

        Console.WriteLine("TC kimlik numarası : " + nationalId);
        Console.WriteLine("Adı : " + firstName);
        Console.WriteLine("Soyadı : " + lastName);
        Console.WriteLine("Telefon numarası : " + phoneNumber);
        Console.WriteLine("Yaşı : " + age);
        Console.WriteLine("İlk aldığı ürünün fiyatı : " + productPrice1);
        Console.WriteLine("İkinci aldığı ürünün fiyatı : " + productPrice2);
        Console.WriteLine("----------------------------------------");

        Console.WriteLine(nationalId + " tc numaralı " + firstName + " " + lastName + " isimli kişi için kayıt oluşturulmuştur");
        Console.WriteLine(totalPrice + " toplam harcama karşılığında kazanılan 10% patika puan miktarı -> 55 TL'dir");
    }
}
