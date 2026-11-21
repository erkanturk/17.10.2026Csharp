namespace _10_Arrays_2_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region proje
            /* 
             * admin girişi -1
            5 elemanlı bir ürünler dizisi olsun 
          Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
         Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği
         ile tekrar para girmesi sağlanacak. eğer para fazla ise üstü verilecek.
         satın alma tamamlandıktan sonra başka bir isteğiniz var mı diye sorulacak
            var ise tekrardan ürünler listesine geçilecek yok ise program sonlanacak.

          // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek
            aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
            Admin şifresi 3 defa yanlış girilince
            10 saniye bekletecek hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
          */
            #endregion

            //string[] sehirler = { "İzmir", "Adana", "İstanbul", "Maraş", "Urfa", "Amasya", "Yozgat", "Adana","Urfa", "Tokat", "Adana" };
            //int[] sayilar = { 200, 100, 50, 110, 111, 22, 5 };
            #region ArrayMethods
            #region Clear
            //Array.Clear(sayilar);//mevcut dizinin tüm elemanlarını siler
            //Array.Clear(sehirler);//mevcut dizinin tüm elemanlarını siler
            //// Array.Clear(sehirler, 1, 3);//istediğimiz aralıkta silme işlemi
            // foreach (int item in sayilar)
            // {
            //     Console.WriteLine(item);
            // }
            // foreach (string item in sehirler)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Copy
            //string[] sehirler2 = new string[sehirler.Length];
            //sehirler2[0] = "Antalya";
            //sehirler2[1] = "Tekirdağ";
            //sehirler2[7] = "Bursa";
            //sehirler2[8] = "Muğla";
            //sehirler2[9] = "Çanakkale";
            //Array.Copy(sehirler, 0, sehirler2, 2, 5);//mevcut değerlerin üstüne ekleme
            //0 mevcut dizide başlayacağı index   2 5 ise kopyalamaya başlayacağı index ve aktaracağı uzunluk
            ////Array.Copy(sehirler, sehirler2, sehirler.Length);
            ////Array.Copy(sehirler, sehirler2, 4);
            //foreach (string item in sehirler2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region IndexOf&LastIndexOf
            //int index = Array.IndexOf(sehirler, "Adana");//IndexOf ilk bulduğu değeri getirir.
            //int index2 = Array.IndexOf(sehirler, "Adana",2);//aramaya 2 den başla
            //int index3 = Array.LastIndexOf(sehirler, "Adana");//sondan arama yapar ilk bulduğunu getirir
            //int index4 = Array.LastIndexOf(sehirler, "Adana",8);
            //Console.WriteLine(index);
            //Console.WriteLine(index2);
            //Console.WriteLine(index3);
            //Console.WriteLine(index4);
            //Console.WriteLine(sehirler[index]);

            //foreach (string i in sehirler)
            //{
            //    if (i == "Urfa")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Sort&&Reverse
            //reverse mevcut durumu tersine çevirir 
            //sort diziyi düzene sokar a dan z ye yada küçükten büyüğe
            //Array.Sort(sehirler);
            //foreach (string i in sehirler)
            //{
            //    Console.WriteLine(i);
            //}
            ////Array.Sort(sayilar);
            //Array.Reverse(sayilar);
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Contains
            //contains yapısı dizide varsa true yoksa false dönderir

            //string var = sehirler.Contains("Adana") ? "Var" : "Yok";
            //Console.WriteLine(var);
            //bool deger = sehirler.Contains("Antalya");
            //Console.WriteLine(deger);
            #endregion
            #region Resize
            //int[] dizi = new int[0];

            //Array.Resize(ref dizi, 5);//resize var olan bir dizinin boyutlandırılmasını sağlar
            ////ref keywordü ise mevcutta olan bir değerin güncellenmesine olanak tanır.
            //dizi[0] = 1;
            //dizi[1]= 2;
            //dizi[2] = 3; 
            //dizi[3]=4;
            //dizi[4] = 5;
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Resize(ref dizi, dizi.Length - 1);
            //Console.WriteLine("********");
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //Array.Resize(ref dizi, dizi.Length + 1);
            //dizi[5] = 15;
            //dizi[6] = 15;
            //dizi[7] = 15;
            //dizi[8] = 15;
            //dizi[9] = 15;
            //dizi[10] = 15;
            //dizi[11] = 15;
            //dizi[10] = 2222;
            //dizi[12] = 2222;
            //Array.Resize(ref dizi, dizi.Length - 2);
            //Console.WriteLine("**********");
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            // out olmayan bir değeri (null,undefined) güncellememizi sağlar

            string[] meyveler = { "elma", "armut", "muz" };
            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.WriteLine(i+" " + meyveler[i]); ;
            }
            Console.WriteLine("Bir meyve giriniz");
            string meyve = Console.ReadLine().ToLower();
            if (int.TryParse(meyve, out int meyveNo))
            {
                if (meyveNo == 0)
                {
                    Console.WriteLine($"{meyveler[meyveNo]} aldınız");
                }
                else if (meyveNo == 1)
                {
                    Console.WriteLine($"{meyveler[meyveNo]} aldınız");
                }
                else if (meyveNo == 2)
                {
                    Console.WriteLine($"{meyveler[meyveNo]} aldınız");
                }
            }
            else
            {
                int index = meyveler.IndexOf(meyve);
                Console.WriteLine(index);
                if (index >= 0&&index<meyveler.Length)
                {
                    if (meyve == "elma")
                    {
                        Console.WriteLine($"{meyveler[index]} aldınız");
                    }
                    else if (meyve == "armut")
                    {
                        Console.WriteLine($"{meyveler[index]} aldınız");
                    }
                    else if (meyve == "muz")
                    {
                        Console.WriteLine($"{meyveler[index]} aldınız");
                    }
                }

              
            }
            //int meyve = Convert.ToInt32(Console.ReadLine());
            //if (meyve == 0)
            //{
            //    Console.WriteLine("Elma aldınız");
            //}
            //else if (meyve == 1)
            //{
            //    Console.WriteLine("armut aldınız");
            //}
            //else if (meyve == 2)
            //{
            //    Console.WriteLine("muz aldınız");
            //}
            #endregion
            #endregion
        }
    }
}
