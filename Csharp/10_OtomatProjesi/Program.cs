namespace _10_OtomatProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Read Update Delete Crud 
            #region proje
            /* 
            5 elemanlı bir ürünler dizisi olsun 
          Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
         Para girişi yapacak. Girilen para seçilen ürünün 
            fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği
         ile tekrar para girmesi sağlanacak. eğer para fazla ise üstü verilecek.
         satın alma tamamlandıktan sonra başka bir isteğiniz var mı diye sorulacak
            var ise tekrardan ürünler listesine geçilecek yok ise program sonlanacak.

          // Admin => Ürün Ekleyecek, Ürün Silecek,
            Fiyat Güncelleyecek aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
            Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir 
            uyarısı veririp açıldığında bilgilendirecek
          */
            #endregion
            #region OtomatProje
            //bool admin = false;
            //string password = "A123";
            //string adminPassword;
            //int hak = 0;
            //bool hesapKitlimi= false;
            //double bakiye = 0;
            string[] urunler = { "kola", "fanta", "ayran", "kek", "cips" };
            double[] fiyatlar = { 90, 90, 50, 40, 100 };

            //while (true)
            //{
            //    try
            //    {
            //        for (int i = 0; i < urunler.Length; i++)
            //        {
            //            Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
            //        }
            //        Console.WriteLine("Ürün numarası giriniz(Admin girişi -1 e basın)");
            //        int urunNo = Convert.ToInt32(Console.ReadLine());
            //        if (urunNo == -1)
            //        {
            //            Console.Clear();
            //            if (!hesapKitlimi)
            //            {
            //                while (hak < 3)
            //                {
            //                    Console.WriteLine("Admin Şifreniz");
            //                    adminPassword = Console.ReadLine().ToUpper();
            //                    if (adminPassword == password)
            //                    {
            //                        admin = true;
            //                        Console.Clear();
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        hak++;
            //                        Console.WriteLine("Yanlış giriş bilgileri kalan hak:"+(3-hak));
            //                    }
            //                    if (hak == 3)
            //                    {
            //                        Console.WriteLine("Çok sayıda hatalı işlem yapıldı sistem 10 saniye kitlendi");
            //                        hesapKitlimi = true;
            //                        for (int i = 10; i >=0; i--)
            //                        {
            //                            Console.ForegroundColor = ConsoleColor.Red;
            //                            Console.WriteLine("Lütfen bekleyin:"+i);
            //                            Thread.Sleep(1000);
            //                            Console.Clear();
            //                        }
            //                        Console.ResetColor();
            //                        hesapKitlimi = false;
            //                        hak = 0;
            //                        continue;
            //                    }
            //                }
            //                Console.Clear();
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hesap Kilitli");
            //                hesapKitlimi = true;
            //                for (int i = 10; i >= 0; i--)
            //                {
            //                    Console.ForegroundColor = ConsoleColor.Red;
            //                    Console.WriteLine("Lütfen bekleyin:" + i);
            //                    Thread.Sleep(1000);
            //                    Console.Clear();
            //                }
            //                Console.ResetColor();
            //                hesapKitlimi = false;
            //                hak = 0;
                            
            //            }
            //            continue;
            //        }
            //        Console.WriteLine("Para girişi yapınız");
            //        bakiye = Convert.ToDouble(Console.ReadLine());
            //        if (bakiye >= fiyatlar[urunNo])
            //        {
            //            Console.WriteLine("Ürünü aldınız.\nAfiyet olsun\nPara üstü:" + (bakiye - fiyatlar[urunNo]));
            //            Thread.Sleep(2000);
            //            bakiye = 0;
            //            Console.Clear();
            //        }
            //        else
            //        {
            //            while (true)
            //            {
            //                Console.WriteLine("Yetersiz bakiye");
            //                Console.WriteLine("1-Para Ekle\n2-Para iade");
            //                int secim = Convert.ToInt32(Console.ReadLine());
            //                if (secim == 1)
            //                {
            //                    Console.WriteLine("Para ekle");
            //                    bakiye += Convert.ToDouble(Console.ReadLine());
            //                    if (bakiye >= fiyatlar[urunNo])
            //                    {
            //                        Console.WriteLine("Ürünü aldınız.\nAfiyet olsun\nPara üstü:" + (bakiye - fiyatlar[urunNo]));
            //                        Thread.Sleep(2000);
            //                        bakiye = 0;
            //                        Console.Clear();
            //                        break;
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Para iade edildi:"+bakiye);
            //                    bakiye = 0;
            //                    Thread.Sleep(2000);
            //                    Console.Clear();
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Hata:"+ex.Message);
            //        Thread.Sleep(2000);
            //    }
            //}
            //if (admin)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            Console.Clear();
            //            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //            Console.WriteLine("Admin Paneli");
            //            Console.WriteLine("1-Ürün Ekle\n2-Güncelle\n3-Sil\n4-Listele\n5-Çıkış");
            //            int secim=Convert.ToInt32(Console.ReadLine());
            //            if (secim == 1)
            //            {
            //                Console.WriteLine("Ürün Adı:");
            //                string urunAdi = Console.ReadLine().ToLower();
            //                //bool kontrol = false;
            //                //for (int i = 0; i < urunler.Length; i++)
            //                //{
            //                //    if (urunler[i] == urunAdi)
            //                //    {
            //                //        kontrol = true;
            //                //        break;
            //                //    }
            //                //}
            //                if (urunler.Contains(urunAdi))
            //                {
            //                    Console.WriteLine("Ürün zaten mevcut");
            //                    Thread.Sleep(2000);
            //                    continue;
            //                }
            //                Console.WriteLine("Ürün fiyatı");
            //                double fiyat = Convert.ToDouble(Console.ReadLine());
            //                Array.Resize(ref urunler, urunler.Length + 1);
            //                Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
            //                urunler[urunler.Length - 1] = urunAdi;
            //                fiyatlar[urunler.Length - 1] = fiyat;
            //                Console.WriteLine("Ürün eklendi");
            //                Thread.Sleep(2000);


            //            }
            //            else if (secim == 2)
            //            {
            //                for (int i = 0; i < urunler.Length; i++)
            //                {
            //                    Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
            //                }
            //                Console.WriteLine("Güncellenecek ürün no");
            //                string guncelle = Console.ReadLine().ToLower();
            //                int index;
            //                if (int.TryParse(guncelle, out index))
            //                {
            //                    if (index >= 0 && index < urunler.Length)
            //                    {
            //                        Console.WriteLine("Yeni ürün adı:");
            //                        string yeniUrun = Console.ReadLine().ToLower();
            //                        Console.WriteLine("Yeni ürün fiyad:");
            //                        double yeniFiyat= Convert.ToDouble(Console.ReadLine());
            //                        urunler[index]= yeniUrun;
            //                        fiyatlar[index]= yeniFiyat;
            //                        Console.WriteLine("Ürün güncellendi");
            //                        Thread.Sleep(2000);

            //                    }
            //                }
            //                else
            //                {
            //                    int i = Array.IndexOf(urunler,guncelle);
            //                    if (i >= 0 && i < urunler.Length)
            //                    {
            //                        Console.WriteLine("Yeni ürün adı:");
            //                        string yeniUrun = Console.ReadLine().ToLower();
            //                        Console.WriteLine("Yeni ürün fiyatı:");
            //                        double yeniFiyat = Convert.ToDouble(Console.ReadLine());
            //                        urunler[i]= yeniUrun;
            //                        fiyatlar[i] = yeniFiyat;
            //                        Console.WriteLine("Ürün Güncellendi");
            //                        Thread.Sleep(2000);
            //                    }
            //                }
            //            }
            //            else if (secim == 3)
            //            {
            //                for (int i = 0; i < urunler.Length; i++)
            //                {
            //                    Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
            //                }
            //                Console.WriteLine("Silmek istediğiniz ürün numarası:");
            //                int silinecekNo = Convert.ToInt32(Console.ReadLine());
            //                if (silinecekNo >= 0 && silinecekNo < urunler.Length)
            //                {
            //                    for (int i = silinecekNo; i < urunler.Length-1; i++)
            //                    {
            //                        urunler[i] = urunler[i + 1];
            //                        fiyatlar[i] = fiyatlar[i + 1];
            //                    }
            //                    Array.Resize(ref urunler, urunler.Length - 1);
            //                    Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
            //                    Console.WriteLine("Ürün silindi");
            //                    Thread.Sleep(2000);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Hatalı seçim");
            //                    Thread.Sleep(2000);
            //                }
            //            }
            //            else if (secim == 4)
            //            {
            //                for (int i = 0; i < urunler.Length; i++)
            //                {
            //                    Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
            //                }
            //                Thread.Sleep(2000);
            //            }
            //            else if (secim == 5)
            //            {
            //                Console.WriteLine("Çıkış yapılıyor");
            //                Thread.Sleep(2000);
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hatalı işlem");
            //                Thread.Sleep(2000);
            //            }


            //        }
            //        catch (Exception ex)
            //        {

            //            Console.WriteLine($"Hata:"+ex.Message);
            //            Thread.Sleep(2000);
            //        }
            //    }

            //}
            Kullanici(urunler, fiyatlar);
            #endregion
        }
        static void Kullanici(string[] urunler, double[] fiyatlar )
        {
            bool admin = false;
            string password = "A123";
            string adminPassword;
            int hak = 0;
            bool hesapKitlimi = false;
            double bakiye = 0;
            while (true)
            {
                try
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                    }
                    Console.WriteLine("Ürün numarası giriniz(Admin girişi -1 e basın)");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    if (urunNo == -1)
                    {
                        Console.Clear();
                        if (!hesapKitlimi)
                        {
                            while (hak < 3)
                            {
                                Console.WriteLine("Admin Şifreniz");
                                adminPassword = Console.ReadLine().ToUpper();
                                if (adminPassword == password)
                                {
                                    admin = true;
                                    Admin(urunler, fiyatlar, admin);
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    hak++;
                                    Console.WriteLine("Yanlış giriş bilgileri kalan hak:" + (3 - hak));
                                }
                                if (hak == 3)
                                {
                                    Console.WriteLine("Çok sayıda hatalı işlem yapıldı sistem 10 saniye kitlendi");
                                    hesapKitlimi = true;
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Lütfen bekleyin:" + i);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                    Console.ResetColor();
                                    hesapKitlimi = false;
                                    hak = 0;
                                    continue;
                                }
                            }
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hesap Kilitli");
                            hesapKitlimi = true;
                            for (int i = 10; i >= 0; i--)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Lütfen bekleyin:" + i);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.ResetColor();
                            hesapKitlimi = false;
                            hak = 0;

                        }
                        continue;
                    }
                    Console.WriteLine("Para girişi yapınız");
                    bakiye = Convert.ToDouble(Console.ReadLine());
                    if (bakiye >= fiyatlar[urunNo])
                    {
                        Console.WriteLine("Ürünü aldınız.\nAfiyet olsun\nPara üstü:" + (bakiye - fiyatlar[urunNo]));
                        Thread.Sleep(2000);
                        bakiye = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz bakiye");
                            Console.WriteLine("1-Para Ekle\n2-Para iade");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("Para ekle");
                                bakiye += Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= fiyatlar[urunNo])
                                {
                                    Console.WriteLine("Ürünü aldınız.\nAfiyet olsun\nPara üstü:" + (bakiye - fiyatlar[urunNo]));
                                    Thread.Sleep(2000);
                                    bakiye = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Para iade edildi:" + bakiye);
                                bakiye = 0;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata:" + ex.Message);
                    Thread.Sleep(2000);
                }
            }
        }
        static void Admin(string[] urunler, double[] fiyatlar, bool admin)
        {
            if (admin)
            {
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Admin Paneli");
                        Console.WriteLine("1-Ürün Ekle\n2-Güncelle\n3-Sil\n4-Listele\n5-Çıkış");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAdi = Console.ReadLine().ToLower();
                            //bool kontrol = false;
                            //for (int i = 0; i < urunler.Length; i++)
                            //{
                            //    if (urunler[i] == urunAdi)
                            //    {
                            //        kontrol = true;
                            //        break;
                            //    }
                            //}
                            if (urunler.Contains(urunAdi))
                            {
                                Console.WriteLine("Ürün zaten mevcut");
                                Thread.Sleep(2000);
                                continue;
                            }
                            Console.WriteLine("Ürün fiyatı");
                            double fiyat = Convert.ToDouble(Console.ReadLine());
                            Array.Resize(ref urunler, urunler.Length + 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                            urunler[urunler.Length - 1] = urunAdi;
                            fiyatlar[urunler.Length - 1] = fiyat;
                            Console.WriteLine("Ürün eklendi");
                            Thread.Sleep(2000);


                        }
                        else if (secim == 2)
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                            }
                            Console.WriteLine("Güncellenecek ürün no");
                            string guncelle = Console.ReadLine().ToLower();
                            int index;
                            if (int.TryParse(guncelle, out index))
                            {
                                if (index >= 0 && index < urunler.Length)
                                {
                                    Console.WriteLine("Yeni ürün adı:");
                                    string yeniUrun = Console.ReadLine().ToLower();
                                    Console.WriteLine("Yeni ürün fiyad:");
                                    double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                                    urunler[index] = yeniUrun;
                                    fiyatlar[index] = yeniFiyat;
                                    Console.WriteLine("Ürün güncellendi");
                                    Thread.Sleep(2000);

                                }
                            }
                            else
                            {
                                int i = Array.IndexOf(urunler, guncelle);
                                if (i >= 0 && i < urunler.Length)
                                {
                                    Console.WriteLine("Yeni ürün adı:");
                                    string yeniUrun = Console.ReadLine().ToLower();
                                    Console.WriteLine("Yeni ürün fiyatı:");
                                    double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                                    urunler[i] = yeniUrun;
                                    fiyatlar[i] = yeniFiyat;
                                    Console.WriteLine("Ürün Güncellendi");
                                    Thread.Sleep(2000);
                                }
                            }
                        }
                        else if (secim == 3)
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                            }
                            Console.WriteLine("Silmek istediğiniz ürün numarası:");
                            int silinecekNo = Convert.ToInt32(Console.ReadLine());
                            if (silinecekNo >= 0 && silinecekNo < urunler.Length)
                            {
                                for (int i = silinecekNo; i < urunler.Length - 1; i++)
                                {
                                    urunler[i] = urunler[i + 1];
                                    fiyatlar[i] = fiyatlar[i + 1];
                                }
                                Array.Resize(ref urunler, urunler.Length - 1);
                                Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
                                Console.WriteLine("Ürün silindi");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        else if (secim == 4)
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                            }
                            Thread.Sleep(2000);
                        }
                        else if (secim == 5)
                        {
                            Console.WriteLine("Çıkış yapılıyor");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı işlem");
                            Thread.Sleep(2000);
                        }


                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"Hata:" + ex.Message);
                        Thread.Sleep(2000);
                    }
                }

            }
        }
    }
}
