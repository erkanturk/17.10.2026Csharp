namespace _11_Methodlar_3_Returns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Metin());
            //Console.WriteLine(Yaz());

            //string metin = Yaz();//değer taşımadığı için aktarım yapamaz.
            //string deger = Metin();//taşıdığı değeri aktarım yapabilir.
            //Console.WriteLine(deger);
            //Console.WriteLine(Deger(20,20));

            //char[] harfler = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g' };

            //foreach (int c in DiziDondur(harfler))
            //{
            //    Console.WriteLine(c);
            //}

            // string bir değer alacağız ve bu aldığımız değerin sayısal olarak değerini döndüren methodu yazacağız

            //Console.WriteLine(Yazdir("Bugün Sude derse geldi..."));

            //if (Yazdir("Bugün Sude derse geldi...") > 10)
            //{
            //    Console.WriteLine("uzun metin");
            //}
            //else
            //{
            //    Console.WriteLine("kısa metin");
            //}
            //methoda bir metin döndürelim bu metnin her bir karakterini tek tek alan  ve diziye ekleyen yapıyı yazalım

            Console.WriteLine("Bir metin girin");
            string metin = Console.ReadLine();
            foreach (char item in Dizi(metin))
            {
                Console.WriteLine(item);
            }
        }
        static void Yaz()
        {
            Console.WriteLine("Void Method");
        }

        static string Metin()
        {
            //geriye değer döndüren methodlarda return olmak zorundadır.
            return "Merhaba";
        }

        static string Deger(int sayi, int sayi2)
        {
            return $"Toplam: {sayi + sayi2}";
        }

        static int[] DiziDondur(char[] dizi)
        {
            int[] sayilar= new int[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
            {
                sayilar[i] = dizi[i];
            }
            return sayilar;//returnden sonra bir veri okuyamaz return sadece 1 değer dönderir işlem sonucu veya değer.
            
        }
        static int Yazdir(string metin)
        {
            return metin.Length;
        }
        static char[] Dizi(string deger)
        {
            char[] harfler= new char[deger.Length];
            for (int i = 0; i < harfler.Length; i++)
            {
                harfler[i] = deger[i];
            }
            return harfler;
        }
    }
}
