internal class Program
{
    // Personel tipinde bir veri yapısı tanımladık (complex type)
    public class Personel : PersonelBase
    {
        public Personel(string adi,string soyadi,decimal maas)
        {
            Adi = adi;
            Soyadi = soyadi;
            Maas = maas;
        }
    }

    private static void Main(string[] args)
    {
        // Dictionary
        // Tanımlama
        //var PersonelListesi = new Dictionary<int, Personel>();


        var PersonelListesi = new Dictionary<int, Personel>()
        {
            { 200, new Personel("nikola", "tesla", 5000)},
            { 300, new Personel("Albert", "Einstein", 5000) }
        };

        PersonelListesi.Add(100, new Personel("alice", "adams", 5000));

        foreach (var p in PersonelListesi)
        {
            Console.WriteLine(p);
        }

        
       









        Console.ReadKey();
    }
}