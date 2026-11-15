namespace _09_Donguler_3_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* While döngüsü true olduğu sürece çalışan bir yapıdadır.
             */

            #region Örnek1
            //int i = 0;
            //while (i < 10)//i ++ olmazsa sonsuz döngüye girer çünkü 0 daima 10 dan küçüktür.
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int sayac = 0;
            //while (true)
            //{
            //    sayac++;
            //    if (sayac == 10 || sayac == 12)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(sayac);
            //    if (sayac == 20)
            //    {
            //        break;
            //    }
            //}

            //for (char i = 'A'; i < 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //char harf = 'A';
            //char harf2 = 'z';
            //while (harf<harf2)
            //{
            //    Console.WriteLine(harf);
            //    harf++;
            //}


            #endregion

            #region Model sistemi
            //string kad = "Admin";
            //string pass = "Admin";
            //int hak = 5;
            //while (true)
            //{
            //    Console.WriteLine("Kullanıcı Adınızı giriniz");
            //    string giris = Console.ReadLine();
            //    Console.WriteLine("Şifre");
            //    string sifre = Console.ReadLine();
            //    hak--;
            //    if (giris == kad && pass == sifre)
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkGreen;
            //        Console.WriteLine("Sisteme giriş başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız kalmadı sistem 10 saniye kitlendi");
            //        Thread.Sleep(2000);
            //        for (int i = 10; i >= 0; i--)
            //        {
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.Clear();
            //            Console.WriteLine("Lütfen bekleyin" + i);
            //            Thread.Sleep(1000);
            //        }
            //        Console.ResetColor();
            //        hak = 5;
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş başarısız tekrar deneyin ");
            //        Console.WriteLine("Tekrar deneyiniz Kalan hak:" + (hak - 1));
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //    }
            //}
            #endregion

            #region Kullanıcıdan gelen her değeri tek tek ekrana yazdırma
            //String veri tipi bir koleksiyon yapısı gibi çalışır.
            //Ardaşık char karakterlerden oluşan bir dizidir.
            //Koleksiyon yapısının genelinde index değeri kullanılır.
            //Örneğin metinde yazan erkan türk karakteri toplam uzunluğu 10 dur.
            //string metin = "Erkan Türk";
            //index değeri: E=>0 r=>1 k=>2 a=>3 n=>4 ' '=>5 T=>6 ü=>7 r=>8 k=>9
            //eleman sayısı: E=>1 r=>2 k=>3 a=>4 n=>5 ' '=>6 T=>7 ü=>8 r=>9 k=>10
            //bu yapıya göre şunu diyebiliriz length -1 index değerine eşittir.

            // Console.WriteLine(metin.Length);//karakterin uzunluğunu göster length yapısı bize uzunluğu verir yani eleman sayısı


            Console.WriteLine("Bir metin giriniz");
            string metin = Console.ReadLine();
            for (int i = 0; i < metin.Length; i++)
            {
                Console.WriteLine($"index değeri {metin[i]}=>{i} eleman sayısı=>{i + 1}");
            }
            Console.WriteLine("****************");
            int index = 0;
            while (index < metin.Length)
            {
                Console.WriteLine($"index değeri {metin[index]}=>{index} eleman sayısı=>{index + 1}");
                index++;
            }
            Console.WriteLine("***********");
            index = 0;
            do
            {
                Console.WriteLine($"index değeri {metin[index]}=>{index} eleman sayısı=>{index + 1}");
                index++;
            } while (index < metin.Length);
          
            //indexler daima 0 dan başlar
            Console.WriteLine(metin[1]);//1. index değerini yazdır.
            #endregion
        }
    }
}
