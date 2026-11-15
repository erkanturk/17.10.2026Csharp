namespace _04_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan alınan yani dışarıdan gelen değerler metinsel olarak gelir
             * Çünkü metinsel ifade içerisinde her veriyi tutabilir
             * Bu veri yapılarını uygun yapıya dönüştürerek işlem yapmamız gerekir
             * Bu işleme convert işlemi denir tür dönüşümüdür.
             * Casting ve convert birbirinden farklı yapılardır
             * Casting bir yapıyı uyumlu olduğu alanda kullanmamızı sağlar 
             * Convert ise yapının formatını değiştirir.
             */

            #region Casting
            //double sayi = 21474836481;
            //int number = (int)sayi;//bilinçli tür dönüşümü int uyumluluğunda çalıştır.
            ////Console.WriteLine(number);
            //int x = 10; //bilinçsiz tür dönüşümü
            //double y = x;
            //Console.WriteLine(y);

            //string deger = "10";
            //int deger2 =(int)deger;//Bu yapıda format değişikliği yani convert işlemi olması gerekir.
            #endregion

            #region Convert
            //string deger = "10";
            //int deger2 = (int)deger;

            //string metin = "10";
            //int sayi = Convert.ToInt32(metin);//Format değiştirme
            //Console.WriteLine(sayi);

            //Dışarıdan gelen her değeri eğer metinsel değilse convert etmemiz gerekiyor.
            //Console.WriteLine("Adınız Soyadınız");
            //string adSoyad = Console.ReadLine();
            //Console.WriteLine("Yaşınız");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Maaş");
            //double maas = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Doğum Yılı");
            //short yil = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Tc");
            //long tc = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Boy");
            //float boy = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Kilo");
            //decimal kilo = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Cinsiyet (E/K)");
            //char cinsiyet = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("İşe giriş tarihi");
            //DateTime time = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Hala çalışıyor musun ? (true/false)");
            //bool soru = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Yaşadığın ilin plakası");
            //byte plaka = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine($"Ad Soyad:{adSoyad} Yaş:{yas} Maaş:{maas} Doğum Yılı:{yil} Tc:{tc} Boy:{boy} Kilo:{kilo} Cinsiyet:{cinsiyet} " +
            //    $"İşe Giriş:{time} İş Durumu:{soru} Plaka:{plaka}");

            ////Convert veya Parse işlemi
            //int sayi = int.Parse("123");//Convert.ToInt32(); ile aynı
            //double sayi2 = double.Parse("123");
            //decimal sayi3 = decimal.Parse("123");
            //float sayi4 = float.Parse("123");
            //long sayi5 = long.Parse("123");
            //char harf = char.Parse("A");
            #endregion
            #region Örnek 1
            //Kullanıcıdan doğum yılını ve şimdiki zamanı alarak yaşını bulunuz.
            //Console.WriteLine("Doğum yılı");
            //DateTime dYil = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Şimdiki zaman");
            //DateTime sYil= Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine($"Yaşınız:{sYil.Year-dYil.Year}");

            //Console.WriteLine("Doğum yılı");
            //int  yil = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Şimdiki zaman");
            //int yil2= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Yaşınız:{yil2-yil}");
            #endregion
            #region Örnek 2
            //Kullanıcıdan adSoyad değeri alın ve Doğum yılını isteyin
            //Kullanıcının yaşını bulduktan sonra  10 ekleyip gösterin 
            //yani yukarıda ki örnekte 36 çıktı 10 ekledim 10 yıl sonraki yaşınız 46 olarak görünecek
            //Örnek Çıktı Console.WriteLine("Erkan Türk" 46);
            //Console.WriteLine("Ad Soyad");
            //string adSoyad=Console.ReadLine();
            //Console.WriteLine("Doğum yılı");
            //int yil = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Şimdiki zaman");
            //int yil2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Ad Soyad:{adSoyad}10 Yıl sonraki Yaşınız:{yil2 - yil+10}");

            //Console.WriteLine("Ad Soyad");
            //string adSoyad=Console.ReadLine();
            //Console.WriteLine("Doğum yılı");
            //DateTime dYil = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Şimdiki zaman");
            //DateTime sYil = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine($"Yaşınız:{sYil.Year - dYil.Year}");
            //int deger = sYil.Year - dYil.Year;
            //Console.WriteLine($"Ad Soyad:{adSoyad}10 Yıl sonraki Yaşınız:{deger + 10}");


            #endregion
            #region Örnek3
            //Console.WriteLine("1 sayı giriniz");
            //string sayi = Console.ReadLine();
            //Console.WriteLine("2.Sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi+sayi2);//metinsel değerle sayısal değer toplanamaz.
            #endregion

            #region Boxing Unboxing
            //double sayi = 123.456;
            //object nesne = sayi;//Boxing 
            //Console.WriteLine(nesne);
            //Console.WriteLine(nesne.GetType());

            //object obj = 123.456;
            //double sayi = (double)obj;//unboxing
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi*1.20);

            #endregion
            #region Casting
            //Console.WriteLine((int)'A');
            //Console.WriteLine((char)126);
            //Console.WriteLine((char)99);

            double sayi = 123.456;
            int sayi2 = (int)sayi;//küsüratsız yazdırır.
            Console.WriteLine(sayi2);
            #endregion


        }
    }
}
