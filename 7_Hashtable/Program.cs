/* Hashtable
 * system.collection sınıfı altında yer alır
 * non-generic object dir ve boxing/unboxing işlemleri uygulanmalıdır
 * indeksleme yoktur
 * key-value-pairs-anahtar-değer çiftine göre veri organizasyonu sağlanır
 * Key-value ICollection Interface kullanırlar
 * Anahtar - Contain Key
 * Değer - Contain Value
 */
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // tanımlama
        var sehirler = new Hashtable();

        // ekleme
        sehirler.Add(6, "Ankara");
        sehirler.Add(34, "İstanbul");
        sehirler.Add(55, "Samsun");
        sehirler.Add(23, "Elazığ");

        // dolaşma
        //eğer item va olarak tanımlanırsa item tipini döndürür bunun için item DictionaryEntry tipinde olmalı
        foreach (DictionaryEntry item in sehirler)
        {
            Console.WriteLine($"{item.Key,-5} - " +
                $"{item.Value,-20}" );
        }

        // anahtarları alma
        Console.WriteLine("\nAnahtarlar (Keys)");
        var anahtarlar = sehirler.Keys;
        foreach (var item in anahtarlar)
        {
            Console.WriteLine(item);
        }

        // degerler
        Console.WriteLine("\nDeğerler (Values)");
        ICollection degerler =sehirler.Values;
        foreach (var item in degerler)
        {
            Console.WriteLine(item);
        }

        // elemana erişmek
        Console.WriteLine("\nelemana erişmek");
        Console.WriteLine(sehirler[34]);


        //eleman silme
        Console.WriteLine("\neleman silme");
        sehirler.Remove(6);
        foreach (DictionaryEntry item in sehirler)
        {
            Console.WriteLine($"{item.Key,-5} - " +
                $"{item.Value,-20}");
        }





        Console.ReadKey();

    }
}