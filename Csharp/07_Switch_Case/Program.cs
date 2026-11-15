namespace _07_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Switch Case 
             * If else gibi karar yapısıdır 
             * Fakat burada bulunan mantık if else yapısından farklıdır 
             * If else yapısında true olduğu sürecede çalışan bir yapı 
             * Switch case yapısı ise gelen değeri kontrol eder varsa uygun case i çalıştırır
             * Yoksa default kısmı çalışır
             * Her case işleminden sonra break ifadesi ile kod bloğunu kırarız.
             * Break ifadesi olmadan hata verir 
             * case yapısında koşullar verilir ve  : işleminden sonra gerçekleştirilecek kodlar yazılır.
             */
            #region Switch Case Örnekleri
            //Console.WriteLine("Şehir gir plaka bul");
            //string sehir = Console.ReadLine();

            //switch (sehir)
            //{
            //    //Eğer metinsel sorgulamayapacaksak case'ler metinsel olmalıdır sayısal olamaz
            //    case "istanbul": Console.WriteLine($"{sehir} plakası 34"); break;
            //    case "izmir": Console.WriteLine($"{sehir} plakası 35"); break;
            //    case "adana": Console.WriteLine($"{sehir} plakası 01"); break;
            //    case "antalya": Console.WriteLine($"{sehir} plakası 07"); break;
            //    case "bursa": Console.WriteLine($"{sehir} plakası 16"); break;
            //    default:
            //        Console.WriteLine("Sistemde yoğunlukdan dolayı bu bilgiye ulaşılamadı sonra tekrar deneyin");
            //        break;
            //}

            //Türkçe ingilizce sözlük 
            //Kullanıcı türkçe değer girecek yukarıdaki örnekte olduğu gibi bu girilen değerin ingilizcesi
            //deyip ingilizcesini göstereceği switch case yapısı oluşturacağız
            //Örneğin Yazılım değerinin ingilizcesi => Software

            //Console.WriteLine("Türkçe İngilizce Sözlük\nKelime girin");
            //string metin = Console.ReadLine().ToLower();//Kullanıcının girdiği her karakteri küçült

            //switch (metin)
            //{
            //    case "bulutlu": Console.WriteLine($"{metin} ingilizcesi => cloudy"); break;
            //    case "laptop": Console.WriteLine($"{metin} ingilizcesi => computer"); break;
            //    case "defter": Console.WriteLine($"{metin} ingilizcesi => book"); break;
            //    case "not defteri": Console.WriteLine($"{metin} ingilizcesi => note book"); break;
            //    case "güneşli": Console.WriteLine($"{metin} ingilizcesi => sunny"); break;
            //    case "gökyüzü": Console.WriteLine($"{metin} ingilizcesi => sky"); break;
            //    default:
            //        Console.WriteLine("Sözlükte aranan kelime bulunamadı");
            //        break;
            //}
            #endregion

            #region Örnek 2
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin.\n1-Stok eksilt \n2-Ürün ekle \n3-Satış yap\n4-Stok düzenle");
            //int islem = Convert.ToInt32(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1: Console.WriteLine("Stok Eksiltildi"); break;
            //    case 2: Console.WriteLine("Ürün eklendi"); goto case 4;
            //    case 3: Console.WriteLine("Satış yapıldı"); goto case 1;
            //    case 4: Console.WriteLine("Stok düzeltildi"); break;
            //    default:
            //        Console.WriteLine("Yanlış işlem");
            //        break;
            //}
            //Goto ile birden fazla case yapısını kullanabiliriz.

            /* Bir bankamatik yapısı olacak 
             * 1 Para yatırma
             * 2 Para çekme 
             * 3 Bakiye görüntüleme
             * 4 Çıkış 
             * Para  yatırma ve çekme işlemlerinde bakiye görüntülendi yazısı yazacak 
             * 
             * 
             */
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin.\n1-Para Yatır \n2-Para Çek" +
            //    " \n3-Bakiye Görüntüle\n4-Çıkış");
            //int islem = Convert.ToInt32(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1: Console.WriteLine("Para Yatırıldı"); goto case 3;
            //    case 2: Console.WriteLine("Para Çekildi"); goto case 3;
            //    case 3: Console.WriteLine("Bakiyeniz ***,** TL"); break;
            //    case 4: Console.WriteLine("Oturum Güvenli bir şekilde sonlanıyor"); break;
            //    default:
            //        Console.WriteLine("Yanlış işlem");
            //        break;
            //}



            #endregion

            #region Örnek3

            //double bakiye = 50000;
            //double miktar;
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin.\n1-Para Yatır \n2-Para Çek" +
            //    " \n3-Bakiye Görüntüle\n4-Çıkış");
            //int islem = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Tutar Girin");
            //miktar = Convert.ToInt32(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1:

            //        if(miktar<1)
            //        {
            //            Console.WriteLine("Miktar 0 veya negatif olamaz");

            //        }
            //        else
            //        {
            //            bakiye += miktar;
            //            Console.WriteLine($"Hesabınıza {miktar} para yatırıldı"); goto case 3;
            //        }
            //        break;

            //    case 2:
            //        if(miktar<=bakiye)
            //        {
            //            bakiye-= miktar;
            //            Console.WriteLine($"Hesabınızdan  {miktar} para çekildi"); goto case 3;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Yetersiz bakiye");
            //            break;
            //        }

            //    case 3: Console.WriteLine($"Bakiyeniz {bakiye} TL"); break;
            //    case 4: Console.WriteLine("Oturum Güvenli bir şekilde sonlanıyor"); break;
            //    default:
            //        Console.WriteLine("Yanlış işlem");
            //        break;
            //}
            #endregion

            #region Hesap makinesi
            /* Kullanıcıdan 2 adet sayı alacağız ve yapmak istediği işlemi soracağız
             *  + - * / olarak değerleri alacağız
             *  istenilen işleme göre girilen sayı değerlerini işleme tabi tutacağız.
             */

            Console.WriteLine("1.sayı");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.sayı");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yapmak istediğiniz işlemi (+ * - /) belirtin:");
            char islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '+': Console.WriteLine("Toplama işlemi sonucu:" + (sayi1 + sayi2)); break;
                case '-': Console.WriteLine("Çıkartma işlemi sonucu:" + (sayi1 - sayi2)); break;
                case '*': Console.WriteLine("Çarpma işlemi sonucu:" + (sayi1 * sayi2)); break;
                case '/':
                    if (sayi2 != 0) Console.WriteLine("Çarpma işlemi sonucu:" + (sayi1 / sayi2));
                    else Console.WriteLine("sayı 0 a bölünemez");
                    break;

                default:
                    Console.WriteLine("hatalı seçim");
                    break;
            }
            #endregion

            #region Ödev
            /*
           kullanıcıdan alınan cinsiyet bilgisine göre
        ==> ERKEK ise
           yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
          ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
          6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
            yaşı 56 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
          yaş 56'ın altında ise çalıştığı gün sayısına göre eğer 5000 ve üstü ise 
          maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5000 
          altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */
            #endregion

        }

    }
}
