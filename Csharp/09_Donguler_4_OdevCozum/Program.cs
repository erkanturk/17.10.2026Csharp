namespace _09_Donguler_4_OdevCozum
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
            Random random = new Random();
            int rSayi = random.Next(1, 101);
            int hak = 5;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Şanslı Tahmininizi Giriniz...");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                hak--;
                if (rSayi == tahmin)
                {
                    Console.WriteLine("Tebrikler doğru tahmin:"+tahmin);
                    Console.WriteLine("Devam etmek istiyor musun? (E/H)");
                    string cev = Console.ReadLine().ToLower();
                    if (cev == "e")
                    {
                        rSayi = random.Next(1, 101);
                        hak = 5;
                        Thread.Sleep(2000);
                        Console.WriteLine("Oyun tekrar başlıyor");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        continue;
                    }
                    else if (cev == "h")
                    {
                        Console.WriteLine("Oyun sonlanıyor yine bekleriz");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        break;
                    }

                }
                else if (tahmin > rSayi)
                {
                    Console.WriteLine("lütfen daha küçük sayı giriniz");
                    Thread.Sleep(1000);
                }
                else if (tahmin < rSayi)
                {
                    Console.WriteLine("Lütfen daha büyük sayı giriniz");
                }
                if (hak == 0)
                {
                    Console.WriteLine("Hakkınız kalmadı:"+rSayi);
                    Console.WriteLine("Devam etmek istiyor musun? (E/H)");
                    string cev = Console.ReadLine().ToLower();
                    if (cev == "e")
                    {
                        rSayi = random.Next(1, 101);
                        hak = 5;
                        Thread.Sleep(2000);
                        Console.WriteLine("Oyun tekrar başlıyor");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        continue;
                    }
                    else if (cev == "h")
                    {
                        Console.WriteLine("Oyun sonlanıyor yine bekleriz");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        break;
                    }
                }
            }


        }
    }
}
