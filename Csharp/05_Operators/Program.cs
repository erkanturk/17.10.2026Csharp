namespace _05_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazım Kuralları
            /* Programlama dillerinde syntax adı verilen yazım tipleri vardır 
             * Her programlama dilinin kendine has syntax yapısı olabilir fakat tüm programlama dillerinde ortak olarak kullanılan 
             * Case yapıları mevcuttur bu case yapıları üzerinden değişkenler veri tipleri sınıf isimleri methodlar ve propertyler oluşyurulur.
             * Case yapıları
             * 
             * CamelCase=> adSoyad
             * SnakeCase=>ad_Soyad
             * UpperCase=>ADSOYAD
             * lowerCase=>adsoyad
             * PascalCase=>AdSoyad
             * 
             * Yanlış yazım biçimleri
             * !adSoyad ,ad soyad, ad-soyad,1sayi,?sayi 
             * 
             * Doğru biçimler
             * adSoyad,adsoyad,sayi1,sayi_,_sayi,ad_soyad
             * 
             * Syntax hataları
             * sayı,Öğretmen,Çöp,Şal,Üsküdar,vb (Ö,Ü,Ç,Ş,İ,Ğ,ı,ç,ş,ğ,ü) gibi karakterler kullanılamaz.
             * bunları sadece " " içinde metinsel olarak kullanabiliriz
             * Veri tipi yada method sınıf property gibi yapılarda değişkenlerde
             * 
             * sayi,Ogretmen,Istanbul,Umraniye,SanliUrfa,Calisanlar,izmir gibi yanımlama yapabiliriz
             * 
             * 
             */

            //Multi değişken tanımlama

            //double sayi, sayi2, sayi3;//undefined tanımsız

            //double number = 10, number2 = 20, number3 = 30;//tanımlı veri yapıları
            //Console.WriteLine(number);
            //Console.WriteLine(number2);
            //Console.WriteLine(number3);
            //Console.WriteLine("sayı giriniz");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("sayı giriniz");
            //sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("sayı giriniz");
            //sayi3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);
            #endregion

            #region Aritmatik Operatörler
            /*Aritmatik operatörler
             * + Toplama (Metinsel birleştirme işlemi yapar)
             * - Çıkartma 
             * * Çarpma
             * / Bölme
             * % mod alma bir sayının bölümünden kalan 10 /3 kalan 1
             */

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mod olacak değer");
            //int mod = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi % mod);

            //Kullanıcıdan iki sayı alacaksınız double olarak alınacak sayılar 
            //Bir değişken oluşturacağız toplam diye bu sayılar bu alanda toplanacak
            //Toplanan değer ekrana yazdırılacak
            //Toplanan değere + kdv eklenip ekrana yazdırılacak 
            //toplanan değer 2 ye bölünecek
            //toplanan değer den 100 çıkarılacak 

            //Console.WriteLine("1.Sayı");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //double sayi3 = sayi + sayi2;
            //Console.WriteLine($"Toplam:{sayi3}");

            //Console.WriteLine($"Kdv li toplam:{sayi3 * 1.20}");

            //Console.WriteLine($"Ortalama:{sayi3 / 2}");
            //Console.WriteLine($"İndirim:{sayi3 - 100}");
            #endregion


            #region Atama Operatörleri
            /* Atama operatörü
             * = Sağdaki değeri soldaki değişkene aktarır
             * += Mevcut değerin üzerine ekler
             * -= Mevcut değerden azaltma yapar
             * *= Mevcut değerle çarpma
             * /= Mevcut değerle bölme
             * . Erişim operatörü
             * ++ bir artırma
             * -- bir azaltma
             */
            // double sayi = 10;
            //sayi++;//Bir arttır
            //Console.WriteLine(sayi);//Console . ile WriteLine yapısına erişiriz.
            //sayi--;// Bir azalt
            //Console.WriteLine(sayi);
            //Mevcut miktar üzerinden işlem yapmamızı sağlar.
            //sayi += 10;
            //Console.WriteLine(sayi);
            //sayi *= 2;
            //Console.WriteLine(sayi);
            //sayi /= 2;
            //Console.WriteLine(sayi);
            //sayi -= 10;
            //Console.WriteLine(sayi);

            #endregion
            #region Karşılaştırma operatörleri
            /* Karşılaştırma operatörleri daima true false değer dönderir 
             * > Büyüktür
             * < Küçüktür Operatörü
             * >= Büyük veya eşittir
             * <= Küçük veya eşittir
             * == Eşittir
             * != Eşit değildir
             * ! Zıtlık operatörü bir değer true ise ! gelirse başına false olur.
             */
            //bool deger = true;
            //int sayi = 10;
            //int sayi2 = 5;
            //Console.WriteLine(sayi>sayi2);//True
            //Console.WriteLine(sayi<sayi2);//False
            //Console.WriteLine(sayi>=10);//true
            //Console.WriteLine(sayi2<=5);//true
            //Console.WriteLine(sayi == 10);//true
            //Console.WriteLine(sayi2!=sayi);//true
            //Console.WriteLine(!deger);//false
            #endregion

            #region Mantıksal Operatörler
            /* Mantıksal operatörler True 1 false 0 değeri dönderir
             * && => ve (and) matematik işlemindeki çarpmaya benzer
             * || => veya (or) matematik işlemindeki toplamaya benzer
             * 
             * && => Başlangıç Bitiş Sonuç
             *          1       0      0
             *          0       1      0
             *          1       1      1
             *          0       0      0
             * || => 
             *          1       0      1
             *          0       1      1
             *          1       1      1
             *          0       0      0
             */
            #endregion
            //int a = 5;
            //int b = ++a;//arttır aktar
            //int c = a++;//aktar arttır
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            #region Kısayol tuşları
            /* cw+tab Console.WriteLine()
             * Ctrl+k+c Seçilen alanı yorum satırına alır
             * Ctrl+k+u seçilen alanı yorum satırından çıkarır
             * Ctrl+D Bir alt satıra kopyalama
             * Ctrl+Z geri alma
             * Ctrl+Y ileri alma
             * Alt+shift+yön tuşları birden fazla imleç oluşturma
             * Ctrl+A Tüm sayfayı seç
             * Ctrl+K+D Sayfayı düzenle
             * Ctrl+L imlecin olduğu satırı siler
             * Ctrl+B build 
             * Ctrl+F arama işlemi
             * Ctrl+H ilk değeri şununla değiştir.
             * Crtl+G Satır bulma 
             */

            #endregion

            #region Karşılaştırma operatörler örnek
            //Kullanıcıdan kullanıcı adı şifre alacağız bu aldığımız değer kayıtlı olan kullanıcı adı ve şifre ile eşleşirse kullanıcı adı doğru 
            //Şifre doğru diye iki uyarı gösterecek 
            //string kullaniciAdi = "Admin";
            //string sifre = "Admin123";
            //Console.WriteLine("Kullanıcı adınızı giriniz");
            //string kad = Console.ReadLine();
            //Console.WriteLine("Şifreniz");
            //string password = Console.ReadLine();

            //Console.WriteLine(kad == kullaniciAdi && password == sifre);


            //Kullanıcı 3 değerden birini girsin 
            //string kullaniciAdi = "Admin";
            //string sifre = "Admin123";
            //Console.WriteLine("Kullanıcı Adı , Eposta veya Cep numarası");
            //string kad = Console.ReadLine();
            //Console.WriteLine("Şifreniz");
            //string password = Console.ReadLine();
            //Console.WriteLine((kad==kullaniciAdi|| kad=="admin@admin.com"||kad=="12345")&&sifre==password);



            #endregion
            #region Atama Operatörleri örnek
            //Kullanıcıdan 2 sayı istenecek  bu sayı değerleri mevcut tanımlı olan sayıyı manipüle edecek
            //örneğin 200 değerim var kullanıcıdan 2 sayı aldım 100 200 olarak geldi += ekleyip bu sayıyı 500 olarak arttıracağız
            //çarpma bölme ve çıkartma işlemleri de yapacağız 
            double sayi = 200;

            Console.WriteLine("1.Sayı");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            double sayi2= Convert.ToDouble(Console.ReadLine());

            sayi += sayi1 + sayi2;
            Console.WriteLine(sayi);
            sayi *= sayi1 + sayi2;
            Console.WriteLine(sayi);
            sayi /= sayi1 + sayi2;
            Console.WriteLine(sayi);
            sayi -= sayi1 + sayi2;
            Console.WriteLine(sayi);
            #endregion

        }
    }
}
