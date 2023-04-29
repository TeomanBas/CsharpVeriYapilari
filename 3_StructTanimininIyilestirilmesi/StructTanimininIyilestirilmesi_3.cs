/* GENEL AÇIKLAMA
 * bu kısımda bir önceki uygulamada yapılan struct tanımlamaları ve örneklerinin iyileştirmesi yapılacak
 * önceki kısımda oluşturulan yorum satırları bu kısımda kullanılmayacak ve yeni açıklamalar oluşturulacak
 * kod kısımları bu kısımdan kaldırılmayacak yorum satırı yapılacak ve yerine düzenlenmiş kodlar yazılmış olacak
 * önce bir namespace oluşturalım eğitimdeki örneğe uygun olması açısından daha sonra oluşturduğumuz 
 * Ogrenci struct yapısını başka bir dosyaya alacağız ve bu yapıyı oradan kullanacağız daha sonra oluşturulan 
 * öğrenci kayıtları daha düzenli hale getirilecek.
 */

//namespace oluşturduk.
namespace VeriYapilari
{
    internal partial class StructYapisi
    {
    // buraya tanımladığımız Ogrenci adındaki struck yapımızı aldık ve yeni bir Ogrenci.cs adında bir dosyaya taşıdık.

        private static void Main(string[] args)
        {

            /*buradaki tanımlama ve yazdırma işlerini yapan kodlarımız kaldırıyoruz çünkü 
             * struct yapımıza override metodunu ekledik bu işleri daha kolay bir şekilde yapabiliriz
             
            
            // struct yapısının kullanımı
            Ogrenci ogr = new Ogrenci();
            ogr.Numara = 1;
            ogr.Adi = "ahmet";
            ogr.Soyadi = "yılmaz";
            ogr.Cinsiyet = true;

            Console.WriteLine($"{ogr.Numara} " +
                              $"{ogr.Adi} " +
                              $"{ogr.Soyadi} " +
                              $"{ogr.Cinsiyet} ");

            // alternatif tanımlama
            Ogrenci ogr2 = new Ogrenci();
            ogr2.Numara = 2;
            ogr2.Adi = "fatma";
            ogr2.Soyadi = "yavuz";
            ogr2.Cinsiyet = false;

            Console.WriteLine($"{ogr2.Numara} " +
                              $"{ogr2.Adi} " +
                              $"{ogr2.Soyadi} " +
                              $"{ogr2.Cinsiyet} ");


            //parametreler vererek değişkenlerimizi oluşturma
            var ogr3 = new Ogrenci(3, "mehmet", "deniz", true);

            
            Console.WriteLine($"{ogr3.Numara} " +
                              $"{ogr3.Adi} " +
                              $"{ogr3.Soyadi} " +
                              $"{ogr3.Cinsiyet} ");

            //cinsiyet değeri varsayılan olarak true yapıldıktan yeni bir ogrenci eklendi 
            var ogr4 = new Ogrenci(4, "asil", "kara");

            Console.WriteLine($"{ogr4.Numara} " +
                             $"{ogr4.Adi} " +
                             $"{ogr4.Soyadi} " +
                             $"{ogr4.Cinsiyet} ");

            */

            /*
             //override metodumuza göre yeniden daha basit bir şekilde öğrencileri tanımladık. 
             var ogr1 = new Ogrenci(1, "ahmet", "yılmaz");
             var ogr2 = new Ogrenci(2, "fatma", "yavuz", false);
             var ogr3 = new Ogrenci(3, "mehmet", "deniz");
             var ogr4 = new Ogrenci(4, "asil", "kara");

             //tanımlanan ogrencileri yazdıralım
             Console.WriteLine(ogr1);
             Console.WriteLine(ogr2);
             Console.WriteLine(ogr3);
             Console.WriteLine(ogr4);
            */

            /* bu kısma kadar Ogrenci struct Yapısını düzenledik burdan sonra bir öğrenci listesi oluşturmak istersek
             * aşağıdaki yapıyı kullanmamız daha iyi olur ve yukarıdaki ogrenci tanımlama yapılarını yorum satırı olarak işaretleyip
             * aşağıdaki şekilde yapalım
             */
            // oluşturduğumuz struct tipinde bir liste tanımladık
            // List<>() yapısı tanınmazsa System.Collections.Generic kütüphanesini kodumuza dahil etmemiz lazım
            // visual studio 2022 versiyonunda buna gerek kalmıyor
            var OgrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(1, "ahmet", "yılmaz"),
                new Ogrenci(2, "fatma", "yavuz", false),
                new Ogrenci(3, "mehmet", "deniz"),
                new Ogrenci(4, "asil", "kara")
            };

            // Foreach yapısı ile artık öğrencilerimizi yazdırabiliriz.
            foreach (Ogrenci o in OgrenciListesi)
            {
                Console.WriteLine(o.ToString());
            }

            // yazdırma işlemini lambda yapısı ile yapabiliriz
            Console.WriteLine("---------------------------------------");
            OgrenciListesi.ForEach(o => Console.WriteLine(o));


            Console.ReadKey();
        }
    }
}