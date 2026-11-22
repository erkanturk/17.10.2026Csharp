namespace _11_Methodlar_2_Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek1
            //kullanıcıdan kaç adet personeli olduğunu isteyelim personel sayısını girsin ve kullanıcının
            //belirtiği sayıda bir diziye personel bilgilerini ekleyelim AdSoyad ve yaş olarak iki farklı dizi değerini
            //ekleyip döndereceğiz
            #endregion
            #region Örnek2
            //Console.WriteLine("Personel Sayınız");
            //int sayi = int.Parse(Console.ReadLine());
            //PersonelBilgi(sayi);
            #endregion
            //kullanıcıdan 2 adet sayı alacaksınız double olarak alın
            // bu sayıları methoda gönderin 
            //method bu sayıları toplayacak çıkaracak çarpacak bölecek.
            Console.WriteLine("1.Sayı");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlem");
            string islem = Console.ReadLine();
            if (islem == "+")
            {
                Topla(x, y);
            }
            else if (islem == "-")
            {
                Cikart(x, y);
            }
            else if (islem == "*")
            {
                Carp(x, y);
            }
            else if (islem == "/")
            {
                Bol(x, y);
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }

        }
        static void PersonelBilgi(int sayi)
        {
            string[] adlar = new string[sayi];
            int[] yaslar = new int[sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine($"{i + 1}.Personel bilgileri");
                adlar[i] = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Personel Yaş bilgisi");
                yaslar[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (adlar.Length == yaslar.Length)
            {
                DiziDondur(adlar, yaslar);
            }

        }
        static void DiziDondur(string[] dizi, int[] dizi2)
        {
            for (int i = 0; i < dizi.Length && i < dizi2.Length; i++)
            {
                Console.WriteLine($"AdSoyad:{dizi[i]} Yaş:{dizi2[i]}");
            }
        }
        static void Topla(double sayi, double sayi2)
        {
            Console.WriteLine(sayi + sayi2);
        }
        static void Carp(double sayi, double sayi2)
        {
            Console.WriteLine(sayi * sayi2);
        }
        static void Cikart(double sayi, double sayi2)
        {
            Console.WriteLine(sayi - sayi2);
        }
        static void Bol(double sayi, double sayi2)
        {
            if (sayi2 > 0)
            {
                Console.WriteLine(sayi / sayi2);
            }
            else
            {
                Console.WriteLine("Sayı 0 a bölünmez");
            }
        }
    }
}
