internal class Program
{
    private static void Main(string[] args)
    {
        // jagged array
        int[,] a = { { 1, 2, 3, 4, }, { 51, 28, 23, 454, }, {231, 826, 343, 64, }, { 241, 52, 36, 423, } };
        // array içerisindeki dimensionların diagonal toplamları
        int toplam = 0;
        for(int satir=0; satir<a.GetLength(0); satir++)
        {
            for(int sutun=0;sutun<a.GetLength(1); sutun++)
            {
                if(satir==sutun)
                toplam = toplam + a[satir,sutun];
            }
        }
        Console.WriteLine(toplam);
        Console.WriteLine("-----------------daha basit bir yazımla-------------------");
        toplam = 0;
        for (int i=0; i<a.GetLength(0); i++)
        {
            toplam += a[i, i];
        }
        Console.WriteLine(toplam);

        Console.WriteLine("-----------------eğer dikdörtgen olma ihtimali varsa?(rectangular array)-------------------");
        toplam = 0;
        for (int i = 0; i < (a.GetLength(0)<a.GetLength(1) ? a.GetLength(0):a.GetLength(1)); i++)
        {
            toplam += a[i, i];
        }
        Console.WriteLine(toplam);

        Console.WriteLine("-----------------diyagonal metodun çağrılması-------------------");
        Console.WriteLine(DiyagonalTopla(a));

    }
    //bunu metod olarak tanımlayalım eğer metod main içerisinden çağrılacaksa static olmak zorunda
    static int DiyagonalTopla(int[,] a)
    {
        int toplam = 0;
        for (int i = 0; i < (a.GetLength(0) < a.GetLength(1) ? a.GetLength(0) : a.GetLength(1)); i++)
        {
            toplam += a[i, i];
        }
        return toplam;
    }
}