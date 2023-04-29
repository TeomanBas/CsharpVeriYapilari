internal class Program
{
    public static void Main(string[] args)
    {
        //SortedSet Küme işlemleri
        var A = new SortedSet<int>() { 1, 2, 3, 4 };
        var B = new SortedSet<int>() { 1, 2, 5, 6 };
        var C = new SortedSet<int>(RastgeleSayiUret(100));
        var D = new SortedSet<int>(RastgeleSayiUret(100));
        var E = new SortedSet<int>() { 1, 2, 3, 4 };
        var F = new SortedSet<int>() { 1, 2, 5, 6 };
        var G = new SortedSet<int>() { 1, 2, 3, 4 };
        var H = new SortedSet<int>() { 1, 2, 5, 6 };
        var K = new SortedSet<int>() { 1, 2, 3, 4 };
        var L = new SortedSet<int>() { 1, 2, 5, 6 };
        var M = new SortedSet<int>() { 1, 2};
        var N = new SortedSet<int>() { 1, 2, 5, 6 };

        #region yazdirma
        Console.WriteLine();
        Console.WriteLine("A kümesi");
        foreach (int s in A)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("B kümesi");
        foreach (int s in B)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("C kümesi");
        foreach (int s in C)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("D kümesi");
        foreach (int s in D)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        #endregion

        // Union birleşim A ve B kümesi
        A.UnionWith(B);
        Console.WriteLine();
        Console.WriteLine("A ve B kümelerinin birleşimi");
        foreach (int s in A)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        // Union birleşim C ve D kümesi
        C.UnionWith(D);
        Console.WriteLine();
        Console.WriteLine("C ve D kümelerinin birleşimi");
        foreach (int s in C)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine("C ve D kümelerinin birleşimindeki eleman sayısı {0}",C.Count);

        // IntersectWith Kesişim ifadesi
        E.IntersectWith(F);
        Console.WriteLine();
        Console.WriteLine("E ve F kümelerinin kesisimi");
        foreach (int s in E)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        // ExceptWith dışlayan denilebilir g de olupta h de olmayan elemanlar 
        G.ExceptWith(H);
        Console.WriteLine();
        Console.WriteLine("H kümesinin G ye göre dışlayanaı (G DE OLUP H DE OLMAYANLAR) kesisimi");
        foreach (int s in G)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        // A.SymmetricExceptWith Kesişim dışındaki tüm elemanalar
        K.SymmetricExceptWith(L);
        Console.WriteLine();
        Console.WriteLine("K ve L kesimi dışındaki tüm elemanlar");
        foreach (int s in K)
        {
            Console.WriteLine($"{s,5}");
        }
        Console.WriteLine();

        // IsSubsetOf M kümesi N kümesinin alt kümesi olup olmadığını kontrol eder
        // M kümesi N kümesinin alt kümesi ise true değilse false döner
        bool AltKumeMi =M.IsSubsetOf(N);
        Console.WriteLine();
        Console.WriteLine("M kümesi N kümesinin alt kümesi ise true değilse false döner");
        if (AltKumeMi == true)
        {
            Console.WriteLine("M Kümesi N kümesinin alt kümesi");
        }
        else
        {
            Console.WriteLine("M Kümesi N kümesinin alt kümesi değil");
        }
        Console.WriteLine();






        Console.WriteLine();
        Console.ReadLine();
    }

    static List<int> RastgeleSayiUret(int n)
    {
        var list =new List<int>();
        var r = new Random();
        for (int i = 0;i < n; i++)
        {
            list.Add(r.Next(0,1000));
        }
        return list;
    }
}