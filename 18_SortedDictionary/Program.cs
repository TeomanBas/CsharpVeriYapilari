/* SortedDictionary<TKey,TValue>
 * System.collections.Generic sınıfı altında tanımlanır
 * Dictionary sınıfında kullanılan metotların tamamı bu koleksiyon için de kullanılabilir
 * TKey-TValue pairs
 * ekleme adımında sıralama işlemi de yapıldığından dolayı bir miktar performans kaybı gözlemlenebilir
 * sıralama işlemi TKey ifadesine göre yapılır
 */
internal class Program
{
    private static void Main(string[] args)
    {
        // tanımlama
        var KitapIndex = new SortedDictionary<string, List<int>>
        {
            { "HTML", new List<int>() { 8, 10, 20 } },
            { "CSS", new List<int>() { 70, 23, 35 } },
            { "JQuery", new List<int>() { 32, 23, 55 } },
            { "SQL", new List<int>() { 64, 54, 62 } }
        };

        // ekleme
        KitapIndex.Add("FTP", new List<int> { 88, 99, 56 });
        KitapIndex.Add("ASP.NET", new List<int> { 188, 199, 156 });

        // yazdırma

        foreach (var i in KitapIndex)
        {
            Console.WriteLine(i.Key);
            i.Value.ForEach(x => Console.WriteLine("\t =>"+x));
          
        }





        Console.ReadKey();
    }
}