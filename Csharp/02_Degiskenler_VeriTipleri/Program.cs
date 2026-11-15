namespace _02_Degiskenler_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Erkan Türk");//Block line bulunduğu satırı tamamen kapsar
            //Console.WriteLine("Tahsin Canpolat");
            //Console.Write("Altan");//Aynı satırda birden fazla değer taşır
            //Console.Write("Onur");
            //Console.Write("Furkan");
            //Dışarıdan gelen her değer metinseldir.
            //Csharp Programlama dili Data Protected bir dildir yani tip güvenliği olan bir yapıdadır
            //Metinsel ise metinsel veritipi seçilmelidir.
            //Sayısal ise sayısal olarak belirtilmelidir.
            //Programlama dilleri büyük küçük harf duyarlılığı vardır. büyük A ile küçük a birbirine eşit değildir. 
            /* Değişkenler ve veri tipleri
             * Değişkenler bir değeri taşımak için kullandığımız yapılardır 
             * Veri tipleri ise bir değerin nasıl tutulacağını belirten yapılardır.
             */
            // Metinsel veri tipi 
            //string metin = "Erkan";
            //string metin2 = "Türk";
            //Console.WriteLine(metin + metin2);
            //Console.WriteLine(metin);
            ////Tam sayı veri tipi
            //byte yas = 32;//En küçük sayısal veri tipi 0 255 arası değer tutar
            //short ortaUzunluk = 32767;//Maksimum değeri -32768 +32767
            //int tamSayi = 2147483647;//Maksimum değeri Min değer=> -2147483648
            //long enBuyukTamSayi = 9223372036854775807;//Max değeri Min değeri =>9223372036854775808
            //Console.WriteLine(yas);
            //Console.WriteLine(ortaUzunluk);
            //Console.WriteLine(tamSayi);
            //Console.WriteLine(enBuyukTamSayi);

            ////Ondalıklı sayı tipleri
            //float ondalikli = 123.456f;
            //double ondalikli2 = 12345.6789;
            //decimal ondalikli3 = 123456789.1011m;
            //Console.WriteLine(ondalikli);
            //Console.WriteLine(ondalikli2);
            //Console.WriteLine(ondalikli3);

            Console.WriteLine($"Byte {byte.MaxValue} {byte.MinValue}");//$string interpolation bu yapı metinsel bir yapının içerisinde csharp dilini yazmamı sağlar
            Console.WriteLine($"Short {short.MaxValue} {short.MinValue}");
            Console.WriteLine($"Int {int.MaxValue} {int.MinValue}");
            Console.WriteLine($"Long {long.MaxValue} {long.MinValue}");
            Console.WriteLine($"Double {double.MaxValue} {double.MinValue}");
            Console.WriteLine($"float {float.MaxValue} {float.MinValue}");
            Console.WriteLine($"decimal {decimal.MaxValue} {decimal.MinValue}");

            ////Tek harf veri tipi
            //char harf = 'A';
            //char harf2 = 'B';
            //Console.WriteLine(harf);
            //Console.WriteLine(harf2);

            //// boolean veri tipi //Truelar 1 false 0 değeri dönderir
            //bool veri = true;
            //bool veri2 = false;
            //Console.WriteLine(veri);
            //Console.WriteLine(veri2);

            ////Sayısal değerle string değer toplanamaz.
            //string deger = "10";
            //int sayi = 10;
            //Console.WriteLine(deger + sayi);//değerler birleşir
            //Console.WriteLine("10" + "10");
            //int sayi2 = 10;
            //int sayi3 = 10;
            //Console.WriteLine(sayi2 + sayi3);
            //Console.WriteLine(10 + 10);

            //Console.WriteLine(10 + 'a');//char karakterler sayısal değer barındırır ascii olarak bu değerler matematiksel işlemlere uygundur.

           // Tarih zaman veri tipleri
            DateTime time = DateTime.Now;//Şimdiki zaman
            Console.WriteLine(time);
            Console.WriteLine(time.Year);
            Console.WriteLine(time.Month);
            Console.WriteLine(time.Day);
            Console.WriteLine(time.Hour);
            Console.WriteLine(time.Minute);
            Console.WriteLine(time.Second);
            Console.WriteLine(time.Millisecond);
            Console.WriteLine(time.ToString("yyyy-MM-dd HH:mm:ss"));//metinsel olarak formatla istediğim zaman yapısında getir.
            Console.WriteLine(time.ToString("2026-01-01 23:36"));

            ////Sabit değer tanımlama
            //string ad = "Erkan";
            //Console.WriteLine(ad);
            ////string ad = "Tahsin";//var olan bir değeri tekrar tanımlayamazsınız.
            //ad = "Tahsin";//veri güncelleme
            //Console.WriteLine(ad);
            //const double pi = 3.14;
            ///* pi = 4;*///const yapısı ile tanımladığımız değer asla değiştirilemez.
            //Console.WriteLine(pi);
            ////const ifadesini verinin güncellenmesini istemediğimiz durumlarda kullanırız.

            ////var variables
            ////var yapısı gerçek hayatta su gibi düşünebilirsiniz suyu koyduğumuz kabın şeklini almasıyla aynı durumdadır
            //var deger = 10;
            //var deger2 = "10";
            //var deger3 = true;
            //var deger4 = 'A';//Dış kaynaktan ne tipte değer gelceğini bilmediğimiz zaman kullanılır.


            ////Nesnesel veri tipi
            //object nesne = 10;//sayısal değerler ise value type daha hızlıdır.
            //object nesne2 = "10";
            //object nesne3 = true;//Object ve string yapısı referance type olarak çalışır
            //object nesne4 = 'A';//boxing işlemi deriz 


            //Uygun veri tipleri ile Ad Soyad Yaş Boy Cinsiyet değerlerinizi yazın ve ekrana yazdırın

            string ad = "Erkan";
            string soyad = "Türk";
            int yas = 32;
            double boy = 1.76;
            char cinsiyet = 'E';


            string fullName = ad + soyad;
            Console.WriteLine(fullName);
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(yas);
            Console.WriteLine(boy);
            Console.WriteLine(cinsiyet);
            Console.WriteLine("*****************");
            Console.WriteLine($"Ad:{ad}");
            Console.WriteLine($"Soyad:{soyad}");
            Console.WriteLine($"Yaş:{yas}");
            Console.WriteLine($"Boy:{boy}");
            Console.WriteLine($"Cinsiyet:{cinsiyet}");

            Console.WriteLine("****************");

            Console.WriteLine($"Ad:{ad} Soyad:{soyad} Yaş:{yas} Boy:{boy} Cinsiyet:{cinsiyet}");

            Console.WriteLine("String birleştirme yazım tipi");
            Console.WriteLine("Ad:"+ad+"Soyad:"+soyad+"Yaş:"+yas+"Boy:"+boy+"Cinsiyet:"+cinsiyet);
            Console.WriteLine("***********************");
            Console.WriteLine("Ad:" + ad);
            Console.WriteLine("Soyad:" + soyad);
            Console.WriteLine("Yaş:" + yas);
            Console.WriteLine("Boy:" + boy);
            Console.WriteLine("Cinsiyet:" + cinsiyet);

            Console.WriteLine("Indexleme yazım tipi");
            Console.WriteLine("Ad:{0} Soyad:{1} Yaş:{2} Boy:{3} Cinsiyet:{4}",ad,soyad,yas,boy,cinsiyet);

        }
    }
}
