namespace _06_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Karar yapısı (Conditions) if else ,switch case
             * Karar yapılarından sadece birtanesi çalışır  birden fazla koşul olması durumunda 
             * Karar yapıları devreye girer ve koşul olarak hangisi true dönerse o bloktaki yapının içerisinde bulunan
             * Kod blokları çalışır  eğer hiçbir koşul uymazsa else yapısı devreye girer ve geriye kalan tüm koşullar
             * için yapması gereken yapıyı çalıştırır
             * Bir if else yapısında birden fazla else if yapısı olabilir fakat bir if bir else tanımlanır
             * If else yapısının içerisinde de tekrar karar yapıları olabilir yani iç içe if else yapısı tanımlana bilir.
             * If else yapısı daima True olduğu sürece çalışır 
             * Else yapısında bir koşul vermeyiz 
             */

            #region Ödev
            /* kayıtlı olarak kullanıcı adı ve şifremiz olacak
             * string admin="Admin";
             * string password="A123";
             * kullanıcıdan kullanıcı adı ve şifre girmesini isteyeceğiz
             * ve if yapıları ile kontrol ettireceğiz eğer
             * kullanıcı adı ve şifre doğru girildiyse sisteme giriş başarılı diye yazı yazdıracağız
             * eğer kullanıcı adı veya şifre hatalı ise kullanıcıya kullanıcı adı veya şifre hatalıdır yazısı göstereceğiz
             */
            #endregion
            #region Örnek 1
            //Kullanıcıdan bir sayı girmesini isteyelim bu sayının 0 dan büyük  olup olmadığını kontrol edelim
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı 0 dan büyüktür");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Sayı 0 dan küçüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0 dır");
            //}
            #endregion
            #region örnek 2
            //Kullanıcıdan 2 sayı değeri alalım büyük olanı bulalım
            //Console.WriteLine("1.Sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int sayi2= Convert.ToInt32(Console.ReadLine());
            //if (sayi > sayi2)
            //{
            //    Console.WriteLine($"En büyük sayı {sayi}");
            //}
            //else//geriye kalan tüm koşullar olduğu için eşitlik durumunda yada sayı2 nin büyük olma durumunda çalışır.
            //{
            //    Console.WriteLine($"En büyük sayı {sayi2}");
            //}
            #endregion
            #region If else Yanlış kullanım 
            //tek koşula bağlı birden fazla if açmak hatalı bir davranıştır clean code yapısına uymaz

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 10)
            //{
            //    Console.WriteLine("SAyı 10 dan büyüktür");
            //}
            //if (sayi < 10)
            //{
            //    Console.WriteLine("Sayı 10 dan küçüktür");
            //}
            //if (sayi == 10)
            //{
            //    Console.WriteLine("Sayı 10 a eşittir");
            //}
            #endregion

            #region Pozitif mi Negatif mi ?
            //Kullanıcıdan sayı girmesini isteyelim kullanıcının girdiği sayının negatif mi pozitif mi olduğunu bulalım
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif sayı");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Negatif");
            //}
            //else
            //{
            //    Console.WriteLine("nötür");
            //}
            #endregion

            #region Örnek 4
            //Kullanıcıdan 2 sayı değeri alacağız aldığımız bu sayı değerlerinin Tek mi çift mi olduğunu bulacağız.
            //Console.WriteLine("1.Sayı değeri");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı değeri");
            //int sayi2=Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("ilk girilen değer Çifttir " + sayi);
            //    if (sayi2 % 2 == 0)
            //    {
            //        Console.WriteLine("ikinci girilen değer Çifttir " + sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("ikinci değer Tekttir " + sayi2);
            //    }

            //}
            //else if (sayi % 2 == 1)
            //{
            //    Console.WriteLine("ilk değer Tekttir " + sayi);
            //    if (sayi2 % 2 == 0)
            //    {
            //        Console.WriteLine("ikinci girilen değer Çifttir " + sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("ikinci değer Tekttir " + sayi2);
            //    }
            //}
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("ilk girilen değer Çifttir " + sayi);


            //}
            //else if (sayi % 2 == 1)
            //{
            //    Console.WriteLine("ilk değer Tekttir " + sayi);

            //}
            //if (sayi2 % 2 == 0)
            //{
            //    Console.WriteLine("ikinci girilen değer Çifttir " + sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("ikinci değer Tekttir " + sayi2);
            //}
            #endregion

        }
    }
}
