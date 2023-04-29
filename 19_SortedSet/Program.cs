/* SortedSet<T>
 * System.Collections.Generic sınıfı altında yer alır
 * Generic tiptedir
 * Elemanları benzersiz olmalıdır
 * Sıralı bir yapıdadır sıralama ekleme sırasında yapılır
 * Add() -ekleme için kullanılır ve ekleme işlemi gerçekleşirse boolean değer döner
 * Remove() - silme
 * RemoveWhere() -içerisine predicate ifade alır yani içerisne koşul ifadesi yazılabilr ve lamba ifadesi kullanılabilir
 * Dinamik yapıdadır
 * Küme teorisini destekler yani kümelerdeki kesisim vb ifadeleri sogulayabiliriz
 * küme işlemlerine ihtiyaç var ise SortedSet kullanılabilir.
 * A.UnionWith(B) -küme birleşimi
 * A.IntersectWith(B) -küme kesişimi
 * A.ExceptWith(B) - yanlızca a kümesine dahil olan elemanlar
 * A.SymetricExceptWith(B) - Kesişim dışındaki tüm elemanlar
 */
internal class Program
{
    private static void Main(string[] args)
    {
        // SortedSet
        // Tanımlama
        var list = new SortedSet<string>();

        // Ekleme
        list.Add("A");
        list.Add("Asdfgh");
        list.Add("Avbsfdg");
        list.Add("Aewrtwe");
        list.Add("Afgdvcn");
        list.Add("Adfge");

        // Koşul ile ekleme
        if (list.Add("B"))
        {
            Console.WriteLine("B EKLENDİ");
        }
        else
        {
            Console.WriteLine("EKLEME BAŞARIZ");
        }

        // yazdırırken ekleme
        Console.WriteLine("{0}", list.Add("C") == true ? "C eklendi" : "ekleme başarısız");


        Console.WriteLine(new string('-',25));
        Console.WriteLine("liste elemanları");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // silme
        list.Remove("A");

        Console.WriteLine(new string('-', 25));
        Console.WriteLine("liste elemanları A silindi");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }




        Console.WriteLine(new string('-', 25));
        Console.WriteLine("liste elemanları içinde e olan elemanlar yok");

        //liste içerindeki elemanları bir koşula bağlı olarak silmek
        list.RemoveWhere(deger => deger.Contains("e"));
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // listedeki eleman sayısını almak
        Console.WriteLine(new string('-', 25));
        Console.WriteLine("liste deki eleman sayısı");
        Console.WriteLine(list.Count()+" tane eleman var");





        Console.ReadKey();

    }
}