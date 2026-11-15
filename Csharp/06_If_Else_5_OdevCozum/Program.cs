using System.Net.WebSockets;

namespace _06_If_Else_5_OdevCozum
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

            #region Odev 1 Çözüm
            //Console.WriteLine("1.Sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayı");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi > sayi2 && sayi > sayi3)
            //{
            //    Console.WriteLine("En büyük Sayı " + sayi);
            //    if (sayi2 > sayi3)
            //    {
            //        Console.WriteLine("Ortanca Sayı " + sayi2);
            //        Console.WriteLine("En küçük sayı " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı " + sayi3);
            //        Console.WriteLine("En küçük sayı " + sayi2);
            //    }
            //}
            //else if (sayi2 > sayi3 && sayi2 > sayi)
            //{
            //    Console.WriteLine("En büyük Sayı " + sayi2);
            //    if (sayi > sayi3)
            //    {
            //        Console.WriteLine("Ortanca Sayı " + sayi);
            //        Console.WriteLine("En küçük sayı " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı " + sayi3);
            //        Console.WriteLine("En küçük sayı " + sayi);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("En büyük Sayı " + sayi3);
            //    if (sayi > sayi2)
            //    {
            //        Console.WriteLine("Ortanca Sayı " + sayi);
            //        Console.WriteLine("En küçük sayı " + sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı " + sayi2);
            //        Console.WriteLine("En küçük sayı " + sayi);
            //    }
            //}
            #endregion
            #region Ödev2
            //Console.WriteLine("Hava sıcaklığını girin");
            //int sicaklik =Convert.ToInt32(Console.ReadLine());
            //if (sicaklik >= 5 && sicaklik <= 15)
            //{
            //    Console.WriteLine("Hava serin ceket giymeyi unutma");
            //}
            //else if (sicaklik >15 && sicaklik<=25)
            //{
            //    Console.WriteLine("Hava ılık. Rahat şeyler giyebilirsin");

            //}
            //else if (sicaklik > 25)
            //{
            //    Console.WriteLine("Hava sıcaK ");
            //}
            //else
            //{
            //    Console.WriteLine("Hava soğuk,Kalın giysiler giyin");
            //}
            #endregion
            #region Ödev3
            Console.WriteLine("İsim");
            string ad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaş");
            double maas = Convert.ToDouble(Console.ReadLine());

            if (yas > 45)
            {
                Console.WriteLine($"Ad:{ad} Maaş:{maas+5000}");
            }
            else
            {
                Console.WriteLine("Çocuk sayısı");
                int cocuk = Convert.ToInt32(Console.ReadLine());
                if (cocuk < 3)
                {
                    Console.WriteLine($"Ad:{ad} Maaş:{maas +(cocuk*2500)}");
                }
                else
                {
                    Console.WriteLine($"Ad:{ad} Maaş:{maas + (cocuk * 2000)}");
                }
            }
            #endregion
        }
    }
}
