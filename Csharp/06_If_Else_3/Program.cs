namespace _06_If_Else_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Kullanıcıdan 3 adet sayı alınız ve bu sayıları A şeklinde görüldüğü gibi büyükten küçüğe sıralayınız 
            //ve ekrana yazdırınız
            //A Şekli: 15>13>5 Console.WriteLine(15) Console.WriteLine(13) Console.WriteLine(5)

            //2. ödev
            //Kullanıcıdan şu anki hava sıcaklığını isteyip;
            //Hava sıcaklığı; 5 derece altındaysa "Hava soğuk,Kalın giysiler giyin" uyarısı yapsın.
            // 5 ile 15 arasında ise ; "Hava serin ceket giymeyi unutma" uyarısı.
            //15 ile 25 arasında ise ; "Hava ılık. Rahat şeyler giyebilirsin" uyarısı versin.
            //25 üzeri ise; Hava sıcaK uyarısı versin. 
            //3.Ödev

            //kullanıcıdan isim , yaş, maaş ve çocuk sayısı istenecek 
            //eğer kullanıcı 45 yaşının altında ise çocuk sayısına bakılacak
            //ve çocuk sayısı 3'ten az ise çocuk başına 2500₺ 3'ten fazla ise çocuk başına 2000₺ maaş eklemesi yapılacak
            //45 in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak
            //Son olarak ekrana :Erkan Türk Maaşınız 40000₺ yazılacak.
            #endregion
            /* Terenary if else 
             * ? if olarak adlandırılır
             * : ise else yapısıdır.
             */
            #region Terenary if else 
            //kısa if else
            //string cevap = 10 > 5 ? "10 büyüktür 5" : "10 büyük değildir";
            //Console.WriteLine(cevap);
            //Console.WriteLine("bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //string metin = sayi > 0 ? "Sayı pozitiftir" : sayi < 0 ? "Sayı negatiftir" : "Sayı 0 a eşittir";
            //Console.WriteLine(metin);

            //Kullanıcıdan bir sayı alalım bu sayı çift sayımı tek sayımı kontrol edelim tek yada çift olarak 
            //metinsel cevap versin terenary if else yapısını kullanacağız.
            //Console.WriteLine("bir sayı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //string tekCift = sayi2 % 2 == 0 ? "Sayı Çifttir" : "Sayı Tektir";
            //Console.WriteLine(tekCift);

            //Console.WriteLine("Bir renk Giriniz (Yeşil/Mavi/Kırmızı)");
            //string renk = Console.ReadLine();

            //Console.ForegroundColor = renk == "Yeşil" ? Console.ForegroundColor = ConsoleColor.DarkGreen :
            //    renk == "Mavi" ? Console.ForegroundColor = ConsoleColor.DarkBlue :
            //    renk == "Kırmızı" ? Console.ForegroundColor = ConsoleColor.DarkRed : ConsoleColor.Cyan;
            //Console.WriteLine(renk);

            #endregion
            #region Scopesuz if else

            Console.WriteLine("Sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi>0)
                Console.WriteLine("Sayı 0 dan büyüktür");
            else if(sayi<0)
                Console.WriteLine("Sayı 0 dan küçüktür");
            else
                Console.WriteLine("Sayı 0 dır");
            #endregion

        }
    }
}
