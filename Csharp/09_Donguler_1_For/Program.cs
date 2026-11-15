namespace _09_Donguler_1_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Döngüler (Loops)
             * Döngüler belirli bir işi tekrar tekrar yapmamızı sağlayan ve bu yapının bir koşula bağlı ilerlemesini 
             * sağlayan yapılardır 
             * Döngüler tekrar eden işleri  bize basit bir şekilde yapmamızı sağlar 
             * True olduğu sürece çalışırlar
             * False olması durumunda çalışmaz (Do while dışında)
             * genelde koleksiyon yapıları ile kullanılırlar 
             */

            /*Döngü yapıları  For /Do while / While*/
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            //Console.WriteLine("Sude Çakır");
            #region Örnek 1
            //for (int i = 0; i < 10; i++)//int i =0 başlangıç ; i<10 koşul ; i ++ veya i -- artış azalış
            //{
            //    Console.WriteLine("Erkan Türk");
            //}
            //0 dan başlıyarak 9 a kadar sayıları ekrana yazdırın
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i >0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10; i--)//sonsuz döngü
            //{
            //    Console.WriteLine(i);
            //}
            //for (; ; )//Sonsuz döngü
            //{
            //    Console.WriteLine("sonsuz döngü");
            //    break;//Sonsuz döngü kullanıla bilir fakat belirli koşullarda break ifadesi ile döngü kırılmalıdır.

            //}
            //Console.WriteLine("");
            #endregion

            #region Örnek2
            //Sadece 2 nin katlarını ekrana yazdıralım
            //for (int i = 0; i <= 20; i+=2)//Artış azalış miktarınıda belirtebiliriz.
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;//i ++ olmazsa sonsuz döngü olur.
            //}

            #endregion

            #region Örnek3
            //Kullanıcıdan aldığımız sayının faktoriyelini bulma
            //5=> 1*2*3*4*5=>120
            //Console.WriteLine("bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int fakt = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    fakt *= i;
            //}
            //Console.WriteLine(fakt);
            #endregion

            #region Çarpım tablosu 
            //Döngüler iç içe olabilir  bir aracın dişlisi gibi düşünün küçük çark 10 defa dönerken büyük çark 1
            //defa döner

            //for (int i = 1; i <11; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{j} * {i} = {i * j}\t"); // 1 tab boşluk bırak \t
            //    }
            //    Console.WriteLine("*******************");
            //}

            #endregion
            #region Continue & Break
            // 1 den 20 ye kadar sayıları ekrana yazdıralım fakat  11 13 sayıları yazdırılmasın
            // 18 e geldiğinde döngü 18 i yazdırıp sonlansın
            //for (int i = 1; i <=20; i++)
            //{
            //    if (i == 11 || i == 13)
            //    {
            //        continue;//continue yapısı döngüye tekrar yönlendirir aşağıdaki kodları okumasına izin vermez.
            //        //iç içe döngülerde bağlı olduğu döngüye aktarır dışta olan döngüye işlem yapamaz
            //    }
            //    if (i == 18)
            //    {
            //        Console.WriteLine(i);
            //        Console.WriteLine("Döngü sonlandı");
            //        break;//break ifadesi koşul true dahi olsa döngüyü sonlandırır.
            //              //iç içe döngülerde bağlı olduğu döngüyü kırar dışta olan döngüye işlem yapamaz
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion


            #region Örnekler
            //300 den başlıyarak 7 ye tam bölünenleri ekrana yazdıran döngü yapısı

            //for (int i = 300; i > 0; i--)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // 7 ye tam bölünen ve bölünmeyenlerin toplamı
            //int bolunen = 0;
            //int bolunmeyen = 0;
            //for (int i = 300; i > 0; i--)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        bolunen += i;
            //    }
            //    else
            //    {
            //        bolunmeyen += i;
            //    }
            //}
            //Console.WriteLine("Bölünen " + bolunen);
            //Console.WriteLine("Bölünmeyen " + bolunmeyen);


            //for (char i = 'A'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i + "=>" + (int)i);
            //}

            #endregion


        }
    }
}
