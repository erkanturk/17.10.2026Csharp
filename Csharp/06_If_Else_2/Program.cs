namespace _06_If_Else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

            #region Ödev Çözüm
            //string kad = "Admin";
            //string password = "A123";

            //Console.WriteLine("Kullanıcı Adınız");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Şifre");
            //string sifre = Console.ReadLine();

            //if (kullaniciAdi == kad && password == sifre)
            //{
            //    Console.WriteLine("Sisteme giriş Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            //}

            //if (kullaniciAdi == kad && password == sifre)
            //{
            //    Console.WriteLine("Sisteme giriş Başarılı");
            //}
            //else
            //{
            //    if (kullaniciAdi != kad)
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalı");
            //    }
            //    if (password != sifre)
            //    {
            //        Console.WriteLine("Şifre Hatalı");
            //    }
            //}
            #endregion
            #region Örnek1
            //Kullanıcıdan haftanın hangi günü olduğunu soralım
            //1 ila 7 arasında bir sayı değeri alalım kullanıcı 1 derse pazartesi
            //7 derse pazar olacak  eğer 1 ila 7 arasında bir değer girmezse uyarı verecek 
            //Haftada 7 gün vardır diye  

            //Console.WriteLine("Haftanın hangi günü");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //if (gun < 1 || gun > 7)
            //{
            //    Console.WriteLine("1 ila 7 arasında değer giriniz");
            //}
            //else
            //{
            //    if (gun == 1)
            //    {
            //        Console.WriteLine("Pazartesi");
            //    }
            //    else if (gun == 2)
            //    {
            //        Console.WriteLine("Salı");
            //    }
            //    else if (gun == 3)
            //    {
            //        Console.WriteLine("Çarşamba");
            //    }
            //    else if (gun == 4)
            //    {
            //        Console.WriteLine("Perşembe");
            //    }
            //    else if (gun == 5)
            //    {
            //        Console.WriteLine("Cumaya git ");
            //    }
            //    else if (gun == 6)
            //    {
            //        Console.WriteLine("Cumartesi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Pazar");
            //    }
            //}

            #endregion

            #region Örnek2
            //Kullanıcıdan notunu isteyelim kullanıcının girdiği not 85 ila 100 arasında ise AA
            //84 70 arası Ba
            //69 60 arası BB
            //59 50 Arası CC
            //49 40 Arası DD
            //39 0 arası FF olacak şekilde girilen nota göre 
            //Değer gösterelim

            //Console.WriteLine("Notunuzu giriniz");
            //int not = Convert.ToInt32(Console.ReadLine());
            //if (not > 84 && not <=100)
            //{
            //    Console.WriteLine("AA");
            //}
            //else if (not > 69 && not <= 84)
            //{
            //    Console.WriteLine("BA");
            //}
            //else if (not > 60 && not <= 69)
            //{
            //    Console.WriteLine("BB");
            //}
            //else if (not > 50 && not <= 59)
            //{
            //    Console.WriteLine("CC");
            //}
            //else if (not > 40 && not <= 49)
            //{
            //    Console.WriteLine("DD");
            //}
            //else if (not > 0 && not <= 39)
            //{
            //    Console.WriteLine("FF");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı not");
            //}

            #endregion
            #region Örnek3
            //Kullanıcıdan Aylık gelirini isteyeceğiz ve aylık geliri
            //40000 in üstünde ise %12 vergi kesintisi uygulayacağız
            //40000 tl ve altında ise %9 vergi kesintisi uygulayıp 
            //Vergi uygulanmış halini göstereceğiz
            //Örnek çıktı: Vergi uygulanmış maaşınız 37900

            //Console.WriteLine("Aylık gelirinizi giriniz");
            //double gelir = Convert.ToDouble(Console.ReadLine());
            //if (gelir > 40000)
            //{
            //    Console.WriteLine($"%12 vergi uygulanmış gelir:{gelir * 0.88}");
            //}
            //else
            //{
            //    Console.WriteLine($"%9 vergi uyğulanmış gelir:{gelir * 0.91}");
            //}

            // Kullanıcıdan 2 ürün fiyatı alalım bu fiyatlardan ucuz onala %30 indirim uygulayalım ve 2 ürünün toplamını
            //Ekrana yazdıracağız örneğin 2000 1000 ürünlerin fiyatı %30 1000 tl ye indirim uyguladık
            // sonuç 2700 olarak görünecek.
            //Console.WriteLine("1.Ürün fiyatı");
            //double f1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün fiyatı");
            //double f2 = Convert.ToDouble(Console.ReadLine());
            //double indirim = 0;
            //if (f1 > f2)
            //{
            //    Console.WriteLine($"indirimli toplam:{f1+(f2*0.70)} indirimsiz toplam:{f1+f2}");
            //}
            //else
            //{
            //    Console.WriteLine($"indirimli toplam:{f2 + (f1 * 0.70)} indirimsiz toplam:{f1 + f2}");
            //}
            //if (f1 > f2)
            //{
            //    indirim = f1 + (f2 * 0.70);

            //}
            //else
            //{
            //    indirim = f2 + (f1 * 0.70);
            //}
            //Console.WriteLine($"indirimli fiyat:{indirim}");

            //if (f1 > f2)
            //{
            //    f1 += (f2 * 0.70);
            //    Console.WriteLine($"indirimli fiyat:{f1}");
            //}
            //else
            //{
            //    f2 += (f1 * 0.70);
            //    Console.WriteLine($"indirimli fiyat:{f2}");
            //}


            #endregion
            //Ödev
            //Kullanıcıdan yaşını isteyeceğiz 18 veya büyükse 18 den 
            //bilet için öğrenci mi diye soracağız öğrenci ise 100 tl den bileti vereceğiz
            //öğrenci değilse 150 tl den bilet vereceğiz
            //eğer 18 değilse bilet alamazsınız diyeceğiz.


            Console.WriteLine("Yaşınız");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas >= 18)
            {
                Console.WriteLine("Öğrenci misin ?");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.WriteLine("Öğrenci bileti 100 Tl");
                }
                else
                {
                    Console.WriteLine("Öğrenci bileti 150tl");
                }
            }
            else
            {
                Console.WriteLine("Sinema da yaş sınırı var giremezsin");
            }
            
        }
    }
}
