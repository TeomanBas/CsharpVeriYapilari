/* Dictionary<TKey,TValue>
 * System.Collections.Generic class ında bulunuyor
 * Generic bir ifade
 * TKey,TValue pairs anahtar değer çiftinden oluşuyor
 * TKey benzersiz olmak zorunda
 * Tvalue istediğimiz değeri alır
 * HashTable ile kıyaslandığında daha performanslıdır.
 * 
 * 
 */
internal class Program
{
    private static void Main(string[] args)
    {
        // Tanımlama
        var TelefonKodlari = new Dictionary<int, string>()
        {
            {332,"konya" },
            {424,"elazığ" },
            {466,"Art" }

        };

        // ekleme
        TelefonKodlari.Add(322, "adana");
        TelefonKodlari.Add(212, "istanbul");
        TelefonKodlari.Add(216, "istanbul");

        // erişme-değiştirme
        TelefonKodlari[466] = "Artvin";

        // ContainsKey
        // ContainKey ile Key kontrolü
        if (!TelefonKodlari.ContainsKey(312))
        {
            Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil");
            TelefonKodlari.Add(312, "ankara");
            Console.WriteLine("yeni kod eklendi");
        }
        foreach(var s in TelefonKodlari)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine(new string('-',25));

        // ContainValue ile değer kontrolü
        if (!TelefonKodlari.ContainsValue("malatya"))
        {
            Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil");
            TelefonKodlari.Add(422, "malatya");
            Console.WriteLine("yeni kod eklendi");

        }
        foreach (var s in TelefonKodlari)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine(new string('-', 25));

        Console.ReadKey();
    }
}