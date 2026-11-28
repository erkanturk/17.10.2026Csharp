namespace _11_Methodlar_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aşırı yüklemeli methodlar
             * Normal durumda methodlar aynı isim değerlerini taşıyamazlar
             * Fakat overload method yapısı ile aynı isimde methodlar tanımlarız
             * Fakat imza tipleri ve işlevleri faklı olur
             * Bu yapıya eş değer olarak sık kullandığımız bir method yapısı vardır.
             * Console.WriteLine() methodu kendisi dışında 19 aşırı yüklemesi vardır.
             * OOP temel ilkelerinden biri olan Polymorphism yapısını destekleyen static polymorphism (sabit çok biçimcilik)
             * Yapısına overload method yapısı denir
             * Bir methodun birden fazla tip ile kullandığımız yapıya göre uygun olanın çağırılmasıdır.
             */
            //Console.WriteLine();//overload örnek
            //Console.WriteLine("Erkan");
            //Console.WriteLine(10);
            //Console.WriteLine('A');
            //Yaz(10,20);//Summary bilgilendirme amaçlı kullanılan bir yapıdır.
            //Yaz();
            //İşlem yap(IslemYap) adlı methodumuz olacak 4 farklı aynı isimde yapı olacak + - * / işlemleri yapacak bu işlem yap methodu

            IslemYap(10,10.5);
        }
        static void Yaz()
        {
            Console.WriteLine("Merhaba overload");
        }
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        /// <summary>
        /// Bu method 2 tam sayı alır ve toplar int x int y parametreleri var
        /// <see href="https://www.google.com"/>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Yaz(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void Yaz(int x, string metin)
        {
            Console.WriteLine(metin + " " + x);
        }

        static void IslemYap(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void IslemYap(double x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void IslemYap(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        static void IslemYap(int x, double y)
        {
            Console.WriteLine(x + y);
        }

    }
}
