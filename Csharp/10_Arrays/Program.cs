namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ödev
            /* Sistem tarafından random sayı üreteceğiz 1 ila 100 arasında olacak 100 de dahil olacak
             * kullanıcıdan bu sayıyı tahmin etmesini isteyeceğiz
             * toplamta 5 tahmin hakkı olacak
             * kullanıcının girdiği sayı random sayıdan büyük ise ekrana "Daha küçük bir sayı giriniz" yazacak
             * kullanıcının girdiği sayı random sayıdan küçük ise ekrana "Daha büyük bir sayı giriniz" yazacak
             * doğru tahmin yaparsa ekrana "Tebrikler doğru tahmin" yazacak ve döngü sonlanacak
             * kullanıcı 5 tahmin hakkını da kullanırsa ekrana "Tahmin hakkınız bitti. Doğru sayıyı gösterecek
            */
            #endregion
            /* Diziler (array) string ifadeler aslında birer dizidir. Erkan => içinde birden çok eleman taşır.
             * Dizilerde birden çok yapıyı içinde barındıran bir koleksiyon yapısıdır.
             * Dizi tanımlarken eleman sayısı belirtmemiz gerekir bazı durumlarda belirmediğimiz 
             * sonradan artırma yaptığımız yada
             * kullanıcıdan uzunluk miktarını aldığımız durumlar olabilir.
             * Dizinin elemanlarını çağırırken yada güncelleme yaparken INDEX adı verilen key 
             * değerini kullanarak işlem yaparız
             * INDEX'ler daima 0 dan başlar.
             * Dizi tanımlama yapısında bir veri tipi belirtiriz isim veririz new keywordü ile 
             * uzunluk miktarını belirtiriz
             * Dizi tanımı
             * int[] dizi = new int[uzunluk]
             * Diziler belirtilen veri tipinden başka değer almazlar.
             * diziler boş veya dolu olarak iki farklı biçimde kullanılırlar.
             */
            #region örnek1
            //string isim = "Erkan";
            ////index=0,1,2,3,4
            ////eleman=1,2,3,4,5;
            ////Değişkenler bir değer taşır 
            //int[] yaslar = new int[10];//Boş dizi tanımı
            //yaslar[0] = 10;//[burası index] = buraya value yani veri yazılır.
            //yaslar[1]=20; 
            //yaslar[2]=30;
            //yaslar[3] = 40;
            //yaslar[4] = 140;
            //yaslar[5] = 240;
            //yaslar[6] = 340;
            //yaslar[7] = 440;
            //yaslar[8] = 540;
            //yaslar[9] = 640;
            ////yaslar[10] = 640;//index aşımı mevcut dizim 9 index 10 elemandır 10. indexi yoktur. System.IndexOutOfRangeException

            //Console.WriteLine(yaslar[4]);//index değerine göre tek bir elemanı yazdırma

            //for (int i = 0; i < yaslar.Length; i++)
            //{
            //    Console.WriteLine(yaslar[i]);
            //}

            #endregion
            #region Dolu dizi örnek
            //string[] adlar = { "Erkan", "Yasemin", "Eda", "Özge", "Tahsin", "Altan", "Onur", "Furkan", "Tunahan" };
            //int[] yaslar = { 20, 22, 23, 24, 25, 26, 24, 27, 25 };
            ////Console.WriteLine(adlar[4]);

            //for (int i = 0; i < adlar.Length; i++)
            //{//eğer uzunluklar aynı ise tek döngüde gösterilebilir.
            //    Console.WriteLine($"Ad:{adlar[i]} Yaş:{yaslar[i]}");
            //}

            //foreach (int yas in yaslar)//koleksiyon döngü yapısı
            //{
            //    Console.WriteLine(yas);
            //}
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}

            #endregion

            #region örnek2
            //char[] harfler = new char[20];
            //int index = 0;
            //for (char i = 'A'; i < 'U'; i++)
            //{
            //    harfler[index] = i;
            //    index++;
            //}
            //foreach (char item in harfler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine((char)85);

            //for (int i = 0; i < adlar.Length; i++)
            //{//eğer uzunluklar aynı ise tek döngüde gösterilebilir.
            //    Console.WriteLine($"Ad:{adlar[i]} Yaş:{yaslar[i]}");
            //}
            //Console.WriteLine("Kaç sayı gireceksiniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int[] sayilar = new int[sayi];
            //for (int i = 0; i <sayilar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. Sayı");//i +1 gösterimliktir
            //    //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    //sayilar[i]=sayi2;
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Soru1
            //Kullanıcıya kaç adet personeli olduğunu soracağız ve 
            // bu personellerin ad ayrı soyad ayrı diziye kaydedip ekrana yazdırırken ad soyad tek satırda 
            //görünecek şekilde yazalım

            //Console.WriteLine("Personel Sayınız Acilmiş Yasemin öyle diyor");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //string[] adlar = new string[sayi];
            //string[] soyadlar = new string[sayi];

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1} personel Adı:");
            //    adlar[i] = Console.ReadLine();
            //    Console.WriteLine($"{i+1} personel Soyadı:");
            //    soyadlar[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < adlar.Length; i++)
            //{//eğer uzunluklar aynı ise tek döngüde gösterilebilir.
            //    Console.WriteLine($"Ad:{adlar[i]} Soyad:{soyadlar[i]}");
            //}

            //Sabit şehirlerimiz olsun ve bu şehirin plakası girildiğinde şehir ismi görünsün
            //örneğin kullanıcı 1 dedi adana gelecek 2 dedi adıyaman gelecek
            //Şehir plakaları sizin belirtiğiniz yapıda olacak güncel plakalar olma zorunluluğu yok

            //string[] iller = { "", "Adana", "Adıyaman", "Artvin", "Ardahan", "Amasya", "Ankara", "Antalya" };

            //Console.WriteLine("Plaka gir şehir öğren");
            //int sehir = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(iller[sehir]);

            #endregion


        }
    }
}
