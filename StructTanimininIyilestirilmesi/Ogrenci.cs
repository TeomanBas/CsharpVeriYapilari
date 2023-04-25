/* GENEL AÇIKLAMA
 * bu kısımda bir önceki uygulamada yapılan struct tanımlamaları ve örneklerinin iyileştirmesi yapılacak
 * önceki kısımda oluşturulan yorum satırları bu kısımda kullanılmayacak ve yeni açıklamalar oluşturulacak
 * kod kısımları bu kısımdan kaldırılmayacak yorum satırı yapılacak ve yerine düzenlenmiş kodlar yazılmış olacak
 * önce bir namespace oluşturalım eğitimdeki örneğe uygun olması açısından daha sonra oluşturduğumuz 
 * Ogrenci struct yapısını başka bir dosyaya alacağız ve bu yapıyı oradan kullanacağız daha sonra oluşturulan 
 * öğrenci kayıtları daha düzenli hale getirilecek.
 */

namespace VeriYapilari
{

    /* Partial class nedir?
     * partial class olarak oluşturulan ve aynı isme sahip olan class lar çalışma zamanında bir bütün gibi hareket eder 
     * ve böylece bir sınıfa ait farklı fiziksel dosyalar oluşturabiliriz.
     */
    internal partial class StructYapisi
    {
        //örnek bir struct tanımlama
        public struct Ogrenci
        {
            // Tanımlama
            //public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet)
            //cinsiyet parametresine varsayılan olarak true değeri eklendi
            public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet=true)
            {
                //aşağıdaki satır çalıştığını kontrol etmek için yazılmıştı.
                //Console.WriteLine("yapılandırıcı metot çalıştı");
                Numara = numara;
                Adi = adi;
                Soyadi = soyadi;
                Cinsiyet = cinsiyet;
            }

            public int Numara { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public bool Cinsiyet { get; set; }

            // geçersiz kılmak ,ezmek anlamına gelen override metodu
            // bu metod ile bizim struct yapımızın 
            public override string ToString()
            {
                return $"{Numara,-5} " +
                    $"{Adi,-10} " +
                    $"{Soyadi,-15} " +
                    // $"{Cinsiyet,-20}" +
                    string.Format("{0,-5}", Cinsiyet == true ? "Bay" : "Bayan");


            }



        }
    }
}