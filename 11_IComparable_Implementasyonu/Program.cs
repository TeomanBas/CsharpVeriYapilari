internal class Program
{
    /* interface tanımlamak 
    public interface ISehir
    {
        // interface tanımlarken metod imzası yazılmaz burada ISehir bir kontrattır ve interfaceleri tanımlarken
        //  büyük I harfi ile tanımlamak daha anlaşılır kılar ve bu Kontratı kabul eden
        // metotların bu kontrat içerisine tanımlanan özelliklere sahip olması beklenir
        void Tanit();
        void NufusBilgisiGetir(int plakaNo);


    }
    */
    // " : ISehir" ifadesi ile kalıtım ile ISehir interface ini class yapımızıa ekledik
    // ve burada interface içerisine tanımlanan metotlarında implementasyonunu sağladık.
    //public class Sehir : ISehir

    // sehirler.sort(); fonksiyonunu kullanamıştırk bunun için IComparable<Sehir> şeklinde
    // IComparable interfaceini kalıtım ile devralıp implementasyonunu yapmamız gerekli
   public class Sehir : IComparable<Sehir> { 
        //default const
        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }       
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }
        public override string ToString()
        {
            return $"{PlakaNo,-5} {SehirAdi,-15}";
        }

        //IComparable metotlarının implementesi
        public int CompareTo(Sehir other)
        {
            if (this.PlakaNo < other.PlakaNo) 
            {
                return -1;
            }
            else if (this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /* ISehir interfacei için yapılan implementasyonlar
        public void Tanit()
        {
            throw new NotImplementedException();
        }

        public void NufusBilgisiGetir(int plakaNo)
        {
            throw new NotImplementedException();
        }
        */
    } 

    public static void Main(string[] args)
    {
        // list 
        var sayilar = new List<int>() { 15, 23, 15, 2, 14, 64, 23 };
        sayilar.Sort();
        sayilar.ForEach(s => { Console.WriteLine(s); });

        // Sehir Listesi
        var sehirler =new List<Sehir>()
        {
            new Sehir(1, "Ankara"),
            new Sehir(34, "İstanbul"),
            new Sehir(55, "samsun"),
            new Sehir(23, "Elazığ"),
            new Sehir(44,"Malatya")
        };

        // aşağıdaki kısım hata vercektir bunun için interface tanımı yapabiliriz
        // sehirler.Sort();
        
        sehirler.ForEach(s => { Console.WriteLine(s); });

        Console.ReadKey();
    }
}