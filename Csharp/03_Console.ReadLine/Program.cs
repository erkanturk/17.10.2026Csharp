namespace _03_Console.ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.ReadLine(); bu yapı konsol ekranında kullanıcıdan gelecek değeri almak için kullanılan
             * Satır okuma işlemi yapan yapıdır 
             * Kullanıcının girdiği değeri alır ve değişkenin içerisine aktarır.
             * string değer dışında her yapı convert edilmesi gerekmektedir.
             * 4. konuda convert işlemini işleyeceğiz.
             */

            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();//Kullanıcıdan gelen her değer metinsen olduğu için bu alanda convert yapılmaz.
            //Console.WriteLine("Soyadınız:");
            //string soyad = Console.ReadLine();

            //Console.WriteLine($"Adınız:{ad} Soyadınız:{soyad}");

            //Uçak bileti işlemleri
            //Console.Write("Adınız ve Soyadınızı giriniz: ");
            //string adSoyad = Console.ReadLine();
            //Console.Write("Nereden: ");
            //string nereden = Console.ReadLine();
            //Console.Write("Nereye: ");
            //string nereye = Console.ReadLine();
            //Console.Write("Uçuş Saati: ");
            //string ucusSaati = Console.ReadLine();
            //Console.Write("Koltuk Numarası: ");
            //string koltukNumarasi = Console.ReadLine();

            //Console.Clear();//Konsolu temizle

            //Console.ForegroundColor = ConsoleColor.DarkGreen;//yazının rengini değiştir.

            //Console.WriteLine("============Uçuş Bileti==============");
            //Console.WriteLine($"Yolcunun Adı Soyadı:{adSoyad}");
            //Console.WriteLine($"From: {nereden} =========> {nereye}");
            //Console.WriteLine($"Uçuş Saati: {ucusSaati}");
            //Console.WriteLine($"Koltuk Numarası: {koltukNumarasi}");
            //Console.WriteLine("=====================================");

            //Console.WriteLine("1.Sayı");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.Sayı");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"1.ve 2. sayının çarpım sonucu: {number*number2}");

            Console.WriteLine("1.Sayı");
            string n = Console.ReadLine();

            Console.WriteLine("2.Sayı");
            string n2 = Console.ReadLine();

            Console.WriteLine($"1.ve 2. sayının çarpım sonucu: {n + n2}");

            //https://www.w3schools.com/cs/cs_getstarted.php




        }
    }
}
