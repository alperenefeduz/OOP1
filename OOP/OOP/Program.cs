using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanım
            //Gerçek hayatın simüle edilmesini sağlayan yapıdır
            //Sınıflar içerisinde veri tutabilmek için .. barındırır
            //Sınıfın nesnesi oluşmadıpı sürece RAM üzerinde hiç var olmaz.
            //
            #endregion

            #region Sınıf Nesnesini Tanımlama
            //ogrenci ogr = new ogrenci();
            //ogr.Isim = "Meltem";
            //ogr.Soyisim = "Yıldız";
            //Console.WriteLine(ogr.Isim+" "+ogr.Soyisim);
            //araba[] arabalar = new araba[2];
            //arabalar[0] = new araba();
            //arabalar[0].Marka = "BMW";
            //arabalar[0].Model = 2003;
            //arabalar[0].Fiyat = 450000;
            //arabalar[0].Renk = "Siyah";
            //arabalar[1] = new araba();
            //arabalar[1].Marka = "Fiat";
            //arabalar[1].Model = 2019;
            //arabalar[1].Fiyat = 800000;
            //arabalar[1].Renk = "Beyaz";

            //foreach (araba item in arabalar)
            //{
            //    Console.WriteLine(item.Marka + " " + item.Fiyat);
            //}

            #region örnek
            //Öğrenci No, Ögr adı, notlar fieldlarına sahip bir sınıf oluşturlarak aram yöntemi sorularak Adı yada no ile arama yapılacak.
            //Eğer öğrencinin notu 50'nin üzerindeyse geçtiği değilse kaldığı bilgisi consola yazdıralacak

            //ogrenci[] ogrenciler = new ogrenci[3];
            //ogrenciler[0] = new ogrenci();
            //ogrenciler[0].Isim = "Meltem";
            //ogrenciler[0].OgrenciNo = "123456";
            //ogrenciler[0].Not = 85;
            //ogrenciler[1] = new ogrenci();
            //ogrenciler[1].Isim = "Berkay";
            //ogrenciler[1].OgrenciNo = "123457"; 
            //ogrenciler[1].Not = 78;
            //ogrenciler[2] = new ogrenci();
            //ogrenciler[2].Isim = "Ömer";
            //ogrenciler[2].OgrenciNo = "123458";
            //ogrenciler[2].Not = 45;
            //string devammi = "E";
            //while (devammi.ToUpper() == "E")
            //{
            //    Console.WriteLine("Lütfen Arama Yöntemini Seçiniz");
            //    Console.WriteLine("1- İsim İle Arama");
            //    Console.WriteLine("2- Öğrenci No İle Arama");
            //    int secim = Convert.ToInt16(Console.ReadLine());
            //    if (secim ==1 )
            //    {
            //        Console.WriteLine("Lütfen İsim Giriniz");
            //        string isim = Console.ReadLine();
            //        for (int i = 0; i < ogrenciler.Count(); i++)
            //        {
            //            if (isim == ogrenciler[i].Isim)
            //            {
            //                Console.WriteLine($"{ogrenciler[i].Isim} öğrencimizin öğrenci no {ogrenciler[i].OgrenciNo} olup sınav sonucu {ogrenciler[i].Not} olarak iletilmiştir.");
            //                if (ogrenciler[i].Not>=50)
            //                {
            //                    Console.WriteLine("Tebrikler Geçtiniz");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Ne Yazık ki Kaldınız");
            //                }
            //            }
            //        }
            //    }
            //    else if (secim ==2)
            //    {
            //        Console.WriteLine("Lütfen Öğrenci No Giriniz");
            //        string no = Console.ReadLine();
            //        for (int i = 0; i < ogrenciler.Count(); i++)
            //        {
            //            if (no == ogrenciler[i].OgrenciNo)
            //            {
            //                Console.WriteLine($"{ogrenciler[i].Isim} öğrencimizin öğrenci no {ogrenciler[i].OgrenciNo} olup sınav sonucu {ogrenciler[i].Not} olarak iletilmiştir.");
            //                if (ogrenciler[i].Not >= 50)
            //                {
            //                    Console.WriteLine("Tebrikler Geçtiniz");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Ne Yazık ki Kaldınız");
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ya 1 Ya 2'ye basacaksın bari buna şaşırma ");
            //    }
            //    Console.WriteLine("Arama Yapmaya Devam Etmek İster misiniz E/H");
            //    devammi = Console.ReadLine();
            //    Console.Clear();
            //}



            #endregion


            #endregion
        }
    }
}
