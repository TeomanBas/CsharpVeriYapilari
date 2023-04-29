/* LinkedList<T> (bağlı liste yapısı) dinamik veri türüdür
 * System.Collection.Generic sınıfına aittir
 * boxing ve unboxing yoktur
 * doğrusal yapıdadır
 * bağlı liste veri yapılarıdır ve elemanlar sıralı olarak organize edilmezler.
 * [önceki elemanı işaret eder (previous) | veri | kendi nodundanki veriyi işaret eder(next)] ...[önceki elemanı işaret eder | veri | kendi nodundanki veriyi işaret eder] 
 * ilk düğüm first son düğüm last olarak ifade edilir ve bunlar özel düğümlerdir.
 * AddFirst - ilk düğüme ekleme yapar
 * AddLast - son düğüme ekleme yapar
 * Remove - belli düğümü çıkartır
 * RemoveFirst - ilk düğümü listeden çıkartır
 * RemoveLast - son düğümü listeden çıkartır
 * AddBefore -önceki düğümün önüne ekleme yapar
 * AddAfter - sonraki düğümün sonuna ekleme yapar
 * Value - değer okuma
 * büyük ölçekli verilerde dinamik olarak ekleme çıkartma işlevselliği sağlar
 */
internal class Program
{
    private static void Main(string[] args)
    {
        //LinkedList<T> Temelleri 
        //Tanımlama
        var sehirler =new LinkedList<string>();
        sehirler.AddFirst("ingiltere");
        sehirler.AddFirst("fransa");
        sehirler.AddLast("belçika");

        sehirler.AddAfter(sehirler.Find("fransa"), "amerika");
        sehirler.AddBefore(sehirler.First.Next.Next, "isveç");
        sehirler.AddAfter(sehirler.Last.Previous, "izlanda");
       
        // dolaşma
        foreach (string s in sehirler)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine(new string('-',25));

        // elemanların testen yazdırılması

        var eleman = sehirler.Last;
        while (eleman != null)
        {
            Console.WriteLine(eleman.Value);
            eleman = eleman.Previous;
        }

        Console.ReadLine();
    }
}