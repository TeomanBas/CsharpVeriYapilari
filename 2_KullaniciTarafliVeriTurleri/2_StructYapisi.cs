internal class StructYapisi_2
{
    //örnek bir struct tanımlama
    public struct Ogrenci
    {


        /* Tanımlama
* prop yazıp tab tuşuna basarak properties yapısını otomatik olarak oluşturabiliriz.
* get ifadesi içerideki bir değeri okuma , set ifadesi ise içerideki bir değişkene yazma izinleri kullanılır.
* eğer private olarak açmış olsaydık bazı özelliklere yada tamamen struct yapısına dışarıdan erişemeyecektir.
* veya hiçbir şekilde public veya private olarak bir tanımlama yapmasaydık internal olarak görecek ve struct yapısının
* dışarısından bu değişkenlere erişemeyecektir.
* 
* 
*/

        // ilk oluşturduğumuz struct içindeki değişkenleri seçip crtl+. tuşuna basarsak bize aşağıdaki şekilde 
        // parametre şeklinde bir kod yapısı sundu bunun sayesinde parametreler vererek nesnelerimizi oluşturabiliriz. 
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet)
        {
            //kısma yapılandırıcı metot denir buranın içerisindeki kodlar çalıştırılır
            Console.WriteLine("yapılandırıcı metot çalıştı");
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }


        public int Numara { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }




       

    }

    /* public olarak tanımlanmamış bir struct yapısının içerisindekilere dışarıdan erişemeyiz.internal olarak tanımlanırlar
       struct dene
       {
           int deneme;
       }
       void Deneme()
       {
           deneme = 0;
           Console.WriteLine(deneme);
       }
       */

    private static void Main(string[] args)
    {
        /* Kullanıcı Taraflı Veri Türleri struct 
         * değer tiplidir
         * parametre,yapılandırıcı metot,sabitler,alan(field),özellik(properties) gibi özellikleri vardır.
         * küçük ölçekli veriler üzerinde kullanılır
         * kalıtım(inheritance) yoktur.
         * arayüz kalıtımı (interface inheritance) destekler
         * kutulama ve kutudan çıkarma özelliklerini destekler
         * structlar değer tipli classlar referans tipli çalışır
         * 
         * eğer bir obje için birden çok veri türüne ihtiyacımız var ise kullanılabilir.
         */


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
        var ogr3=new Ogrenci(3,"mehmet","deniz",true);

        Console.WriteLine($"{ogr3.Numara} " +
                          $"{ogr3.Adi} " +
                          $"{ogr3.Soyadi} " +
                          $"{ogr3.Cinsiyet} ");

        Console.ReadKey();

    }
}