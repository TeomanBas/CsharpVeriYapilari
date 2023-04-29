/* System collection sınıfına dahildir
 * non-generic yani objedir
 * key-value pairs
 * Key sıralaması yapılır.ekleme yapıldığında
 * sıralı organize edilir
 * Hem Key hemde indis ile elemanlarına erişilebilir
 * IndexofKey gibi anahtar ile elemanlarına ulaşılabilir.
 * IndexofValue ile indislerine ulaşılabilir
 * GetKey ile indeks değeri verilen elemanın anahtarını görebiliriz
 * GetbyIndex ile indeksi verilen elemanın değeri alınabilr.
 * DictionaryEntry ile elemanları yönetiyoruz
 * Icomparable arayüzü uygular
 */
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // SortedList - Temeller
        // Tanımlama

        var list = new SortedList()
        {
            {12,"oniki" },
            {1,"bir" },
            {2,"iki" },
            {3,"üç" },
            {8,"sekiz" },
            {4,"dört" },
            {6,"altı" },
            {5,"beş" },
            {7,"yedi" },
            {9,"dokuz" }
        };

        list.Add(11, "onbir");

        // dolaşma
        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key}- {item.Value}");
        }

        Console.WriteLine("Listedeki eleman sayısı : {0}",list.Count);
        Console.WriteLine("listedeki eleman kapasitesi : {0}",list.Capacity);
        // listede set edilmiş olan eleman sayısı kadarlık bir kapasite belirler ve fazlandan ayrılmış olan kısmı keser
        list.TrimToSize();
        Console.WriteLine("listedeki eleman kapasitesi : {0}", list.Capacity);

        // erişme
        // key
        Console.WriteLine(list[4]);
        // index
        Console.WriteLine(list.GetByIndex(0));
        // get ->  key
        Console.WriteLine(list.GetKey(0));
        // liste sonundaki elemanın değeri
        Console.WriteLine(list.GetByIndex(list.Count-1));


        var anahtar = list.Keys;
        foreach (var item in  anahtar)
        {
            Console.WriteLine(item);
        }

        var deger = list.Values;
        foreach (var item in deger)
        { 
            Console.WriteLine(item);
        }

        // güncelleme
        // belli bir ifadesyi güncellemek burada 1 e karşılık gelen bir anahtar varmı diye kontrol edildi ve güncellendi
        if (list.ContainsKey(1))
        {
            list[1] = "one";
        }
        foreach (var item in list)
        { Console.WriteLine(item); }

        Console.ReadKey();
        
    }
}