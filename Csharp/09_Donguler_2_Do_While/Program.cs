namespace _09_Donguler_2_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Do while döngü yapısı Diğer döngülerden farklı olarak koşul false olsa bile çalışır.
             * eğer koşul true ise döngü devam eder 
             * Döngü yapılarının prensipleri aynıdır hepsi true koşulu olduğu sürece devam eder fakat do while bu işlemi 1 defa çalıştırır
             * Yap kontrol et gibi düşünebiliriz.
             */
            #region kullanım
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int sayac = 0;
            //do
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            //while (sayac > 10);//koşul false ama 1 defa çalıştı

            //int sayac2 = 0;
            //do
            //{
            //    Console.WriteLine(sayac2);
            //    sayac2++;
            //}
            //while (sayac2 < 10);//koşula bağlı çalışma sistemi


            //int i = 0;
            //do
            //{
            //    i++;

            //    if (i == 15 || i == 16)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    if (i == 100)
            //    {
            //        break;
            //    }



            //}
            //while (true);//sonsuz döngü
            #endregion
            //int sayac2 = 0;
            //do
            //{
            //    Console.WriteLine(sayac2);
            //    sayac2++;
            //}
            //while (sayac2 < 10);//koşula bağlı çalışma sistemi
            #region Örnek1
            //kullanıcıya kaç personelin var diye soracağız
            //kullanıcının verdiği cevap kadar personel adlarını yazdıracağız 
            //örneğin 3 personel var 1 Erkan Türk 2 Altan Emre  Demirci 3 Tahsin Canpolat

            //Console.WriteLine("Personel Sayınızı girin");
            //int personel = Convert.ToInt32(Console.ReadLine());
            //int sayi = 0;
            //do
            //{
            //    Console.WriteLine($"{sayi+1}.Personel Adı ve Soyadı");
            //    string adSoyad= Console.ReadLine();
            //    Console.WriteLine($"{sayi+1}.Personel Bilgileri:{adSoyad} Kalan personel miktar {personel-1}");
            //    personel--;
            //    sayi++;
            //} while (personel>0);


            #endregion

            #region Örnek 2
            // Kullanıcı 0 girene kadar sayıları toplasın ve
            // 0 a bastığında döngü sonlansın 0 a basana kadar giridiği sayıların 
            //Toplamını ekrana yazdırsın 

            //int sayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine($"Sayı giriniz.");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //    toplam += sayi;
            //}
            //while (true);//sayi!=0;
            //Console.WriteLine($"Sayıların toplamı: {toplam}");

            // Kullanıcı 0 girene kadar sayıları toplasın ve ilk değer 0 olamaz yani eğer kullanıcı ilk sayıyı 0 giriyorsa 
            //döngü sonlanmayacak ama 0 a bastığında bu değer ilk değer değilse girdiği sayıları toplamını ekrana yazdıracak.



            int sayi = 0;
            int toplam = 0;
            int ilkDeger = 0;
            do
            {
                Console.WriteLine($"Sayı giriniz.");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0&&ilkDeger==0)
                {
                    Console.WriteLine("ilk sayı 0 girilemez");
                    continue;
                }
                if (sayi == 0)
                {
                    break;
                }

                toplam += sayi;
                ilkDeger++;
            }
            while (true);//sayi!=0;
            Console.WriteLine($"Sayıların toplamı: {toplam}");
            #endregion
        }
    }
}
