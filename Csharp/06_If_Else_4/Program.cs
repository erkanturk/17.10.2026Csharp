using System.Threading.Channels;

namespace _06_If_Else_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* If Else ve Goto
             * Goto bir döngü değildir satıra konuşlanma işlemidir Döngülerden sonra asla döngü gibi kullanılmamalıdır
             * Belirtilen satıra bizi yönlendirir ve o satırda işlem yapmamızı sağlar
             * Döngü gibi çalışır fakat döngü yapısı gibi bir çalışma prensibi yoktur
             * Konuşlandığı satıra bizi geri götürür genelde switch case yapısında birden fazla case
             * bloğunu tetiklemek için kullanırız.
             */
        https://www.w3schools.com/cs/cs_syntax.php
            #region Goto Örnek 1
            //Basla://iki nokta
            //    Console.WriteLine("Adınız");
            //    string ad = Console.ReadLine();
            //    Console.WriteLine("Soyadınız");
            //    string soyad = Console.ReadLine();

            //    if (ad == "Erkan" && soyad == "Türk")
            //    {
            //        Console.WriteLine("Giriş doğru");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlış işlem tekrar dene");
            //        goto Basla;//noktalı virgül
            //    }

            #endregion

            #region Goto Çay Demleme Algoritma
            //    Console.WriteLine("Çay demleme algoritması");
            //Mutfak:
            //    Console.WriteLine("Mutfağa git");
            //    Thread.Sleep(2000);//Sistemi 2 saniye mili saniye cinsinden değer alır bekletir.
            //    Console.WriteLine("Çay su var mı ? (E/H)");
            //    Thread.Sleep(2000);
            //    string cevap = Console.ReadLine();
            //    if (cevap == "E")
            //    {
            //        Console.WriteLine("Çaydanlığa su koy");
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Ocağın altını yak");
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Çaydanlığı Ocağa koy");
            //        Thread.Sleep(2000);
            //    kaynama:
            //        Console.WriteLine("Su kaynadı mı ? E/H");
            //        string cevap2 = Console.ReadLine();
            //        if (cevap2 == "E")
            //        {
            //            Console.WriteLine("Demliğe Su koy");
            //            Thread.Sleep(2000);
            //            Console.WriteLine("Demliğe Çay koy");
            //            Thread.Sleep(2000);
            //            Console.WriteLine("Çaydanlığa Su koy");
            //            Thread.Sleep(2000);
            //            Console.WriteLine("Çaydanlığı Ocağa koy");

            //        }
            //        else if (cevap2 == "H")
            //        {
            //            Console.WriteLine("Bekle");
            //            Thread.Sleep(5000);
            //            goto kaynama;
            //        }
            //    }
            //    else if (cevap == "H")
            //    {
            //        Console.WriteLine("Bakkala git");
            //        Thread.Sleep(2000);
            //    Bakkal:
            //        Console.WriteLine("Bakkal Açık mı ? E/H");
            //        string bakkal = Console.ReadLine();
            //        if (bakkal == "E")
            //        {
            //            Console.WriteLine("Eksikleri al");
            //            Thread.Sleep(2000);
            //            Console.WriteLine("Eve dön");
            //            Thread.Sleep(2000);
            //            goto Mutfak;
            //        }
            //        else if (bakkal == "H")
            //        {
            //            Console.WriteLine("Başka bakkala git");
            //            Thread.Sleep(2000);
            //            goto Bakkal;
            //        }
            //    }
            #endregion

            #region Random Tahmin oyunu
            /* Random bir sınıf yapısıdır 
             * Bu yapı sistem tarafından rasgele sayılar üretir
             * Bu sınıfın içerisinde next yapısını dahil ederek
             * içerisine parametre olarak 2 değer veririz
             * ilk değer başlangıç noktası 2. değer ise bitiş noktası fakat
             * bitiş noktasının daima -1 değerini alır 100 dersek 100 dahil etmez 99 a kadar değer alır.
        //     */
            //    Random random = new Random();//new(); instance örneklem nesne oluşturma
            //    int sansliSayi = random.Next(1,5);
            //    int hak = 3;
            //basla:
            //    Console.WriteLine("Lütfen şanslı sayınızı giriniz");
            //    int kullaniciSayi = Convert.ToInt32(Console.ReadLine());
            //    if (sansliSayi == kullaniciSayi)
            //    {
            //        Console.WriteLine("Tebrikler doğru tahmin");
            //    }
            //    else if (hak != 0)
            //    {
            //        hak--;
            //        Console.WriteLine("Tekrar deneyin");
            //        if (hak == 0)
            //        {
            //            Console.WriteLine("Hakkınız kalmadı Şanslı sayı:"+sansliSayi);
            //        }
            //        else
            //        {
            //            goto basla;
            //        }
            //    }

            #endregion

            #region Goto Örnek
            //300 den başlıyarak 7 ye tam bölünen sayıları ekrana yazdıran goto yapısı 
            int toplam1= 0;
            int toplam2= 0;
            int sayi = 300;
        don:
            if (sayi % 7 == 0)
            {
                toplam1 += sayi;
                Console.WriteLine(sayi);
                sayi--;
                goto don;
            }
            else
            {
                sayi--;
                if (sayi != 0)
                {
                    toplam2 += sayi;
                    goto don;
                }
                else
                {
                    Console.WriteLine("işlem tamamlandı");
                }
            }
            Console.WriteLine("7 Ye tam bölünen toplam:"+toplam1);
            Console.WriteLine("7 Ye tam bölünmeyen toplam:"+toplam2);
            //Yukarıdaki örneği yapacağız ve
            //7 ye tam bölünenlerin ve bölünmeyenlerin toplamını işlem bitince göstereceğiz.
            #endregion
        }
    }
}
