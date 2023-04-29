using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // SortedList Uygulamasi
        var icerikler = new SortedList();
        icerikler.Add(1, "giris");
        icerikler.Add(50, "php");
        icerikler.Add(20, "css");
        icerikler.Add(2, "html");
        icerikler.Add(70, "javascript");


        Console.WriteLine("içerikler");
        Console.WriteLine(new string('-', 40));

        Console.WriteLine($"{"Konu", -30} {"sayfalar",8}");
        Console.WriteLine(new string('-', 40));

        foreach (DictionaryEntry item in icerikler)
        {
            Console.WriteLine($"{item.Value,-30} {item.Key,8}");
        }


        Console.ReadKey();

    }
}