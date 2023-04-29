internal class Program
{
    private static void Main(string[] args)
    {
        // SortedSet
        var Sayilar=new List<int>();
        var r =new Random();

        for (int i = 0; i < 100; i++) 
        {
            Sayilar.Add(r.Next(0,100));
            Console.WriteLine($"{Sayilar[i],-3}");

        }
        Console.WriteLine();

        // Listedeki benzersiz elemanarı bulmak
        var benzersizSayilarinListesi = new SortedSet<int>(Sayilar);
        Console.WriteLine();
        Console.WriteLine("\nBenzersiz sayilarin listesi\n");
        foreach(int sayi in benzersizSayilarinListesi)
        {
            Console.WriteLine($"{sayi,-3}");
        }
        Console.WriteLine("benzersiz {0} tane sayi var ",benzersizSayilarinListesi.Count());


        Console.ReadKey();
    }
}