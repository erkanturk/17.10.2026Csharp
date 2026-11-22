namespace _11_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method
            /* Methodlar-Fonksiyonlar
             * Methodlar yazılımcılar tarafından geliştirilen ve diğer yazılımcıların kullanımına sunulan hazır kod bloglarıdır.
             * Methodlara bir isim verilir o isim altında bir kod bloğu yazılır.
             * Yazılımcı o işi yapmak için method yapısını çağırması yeterlidir.
             * bu sayede yazılımcı tanımlı bir işin kodunu tekrar tekrar yazmak yerine method yapısını çağırarak kullanır.
             * 
             * Methodlar ve function yapıları () ile tanımlanır.
             * Method içerisinde method yazılamaz ama çağrılabilir.
             * Methodlar çağırılmadığı sürece çalışmazlar.
             * Method isimleri benzersiz unique olmalıdır. aynı isime sahip methodların imza tipleri farklı olmalıdır.
             * İmza tipi:int,double,string,char gibi veri tipleridir bu yapılara sınıflar ve collection yapılarıda dahildir.
             * Methodlar hazır yapılardır fonksiyonlar ise yazılımcı tarafından yazılan method yapısıdır.
             * Methodlar 2 ye ayrılır
             * 
             * Geriye değer döndüren method (parametreli/parametresiz)
             * Geriye değer döndürme tipleri veri tipi olarak her tip olabilir int list class vb veri tiplerini döndürebilir.
             * iş yapan method (parametreli/parametresiz)
             *  static void Main(string[] args) bir methot yapısıdır void gördüğümüz yapı daima iş yapan methoddur.
        
             * method çağırma : Mymethod(); eğer parametre varsa Mymethod(value);
             */
            #endregion
            #region Örnek1
            //Yaz();
            //IsimYaz("Aleyna Narmanlı");
            //Console.WriteLine("Adınız");
            //string ad = Console.ReadLine();
            //IsimYaz(ad);
            #endregion
            #region örnek2
            //Personel kayıt işlemi yapan method
            //Kaydet();
            //2. senaryo
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            Kaydet2(ad,soyad,yas);
            #endregion
        }
        static void Yaz() // parametresiz iş yapan method
        {
            Console.WriteLine("Erkan Türk");
        }
        static void IsimYaz(string isim)//Method isimleri daima PascalCase ile yazılır.
        { 
            Console.WriteLine(isim);
        }
        static void Kaydet()
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ad:{ad}\nSoyad:{soyad}\nYaş:{yas}");
        }
        static void Kaydet2(string ad, string soyad, int yas)
        {
            Console.WriteLine($"Ad:{ad}\nSoyad:{soyad}\nYaş:{yas}");
        }


    }
}
