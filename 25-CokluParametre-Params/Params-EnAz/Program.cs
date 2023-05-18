internal class Program
{
    static int EnAz(params int[] sayilar)
    {
        int ek = sayilar[0];
        foreach (int i in sayilar)
        {
            if (i < ek)
            {
                ek=i;
            }
        }
        return ek;
    }
    private static void Main(string[] args)
    {
        int a = 10;
        int b = 120;      
        int c = 130;
        int d = 5;
        int e = 20;
        Console.WriteLine(EnAz(a,b,c,d,e));

    }
}