namespace _08_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Try-Catch 
             * Hata yakalama işlemi için kullanılır
             * Programın çalışma sırasında oluşabilecek haları yakalar ve programın çökmesini engeller
             * Kullancı veya sistem kaynaklı hataları yakalayarak programın akışışını bozmadan devam etmesini sağlar
             * Try catch yapısı syntax (yazım) hatalarını yakalamaz.
             * 
             */
            #region Try Catch olmasa örneği
            //Console.WriteLine("bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());//Sözel bir karakter girdiğimiz zaman program patlar
            //Console.WriteLine(sayi);
            //Console.WriteLine("Program çalışıyor");
            #endregion
            #region Örnek1
            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi2);
            //    Console.WriteLine("Program çalışıyor");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hata");
            //}

            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi2);
            //    Console.WriteLine("Program çalışıyor");
            //}
            //catch (Exception ex)//Genel tüm hataları exception yakalar.
            //{

            //    Console.WriteLine("hata:"+ex.Message);
            //}

            #endregion

            #region Try catch exception örnekleri
            //try
            //{
            //    Console.WriteLine("1 sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2.Sayı");
            //    int  sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi / sayi2);
            //    //Console.WriteLine("değer girin");
            //    //int deger = Convert.ToChar(Console.ReadLine());
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Program çalışmaya devam eder");
            #endregion

            #region Try Catch Finally

            //Finally yapısı her koşulda çalışır try durumunda da catch durumunda da 

            try
            {
                Console.WriteLine("Bağlantı açıldı");
                int sayi = 10;
                int sayi2 = 0;
                Console.WriteLine(sayi / sayi2);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("bağlantı kapatıldı");//finally her koşulda çalışır
            }
            #endregion
        }
    }
}
