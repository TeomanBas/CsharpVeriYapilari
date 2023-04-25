

using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Array | Dizi tanımlama
        int[] sayilar = new int[] { 1, 4, 6, 2, 5, 3, 15, 29, 203, 28 ,55, 99, 43};
        // alacağı eleman sayısını length olarakta verebiliriz
        var numbers = Array.CreateInstance(typeof(int), sayilar.Length);



        // var numbers = Array.CreateInstance(typeof(int), 6);

        /* CreateInstance ile dizi elemanlarının tanımlanması
        var numbers = Array.CreateInstance(typeof(int), 5);
        numbers.SetValue(5, 0);
        numbers.SetValue(6, 1);
        numbers.SetValue(4, 2);
        numbers.SetValue(3, 3);
        numbers.SetValue(2, 4);

        */
        // Array() bir class bunun içerisine yeni koleksiyonlarıda parametre olarak verebiliriz.
        var sayilar2 = new ArrayList(sayilar);


        // copyTo ifadesi ile bir dizi içerisindeki sayilari başka bir dizi içerisne kopyalayabiliriz.
        sayilar.CopyTo(numbers,0);

        // array class ının short metodu ile diziyi sıralayabiliriz
        Array.Sort(sayilar);
        Array.Sort(numbers);
        sayilar2.Sort();

        //dizi içerisinden belli bir elemeanı arayabiliriz olmayan bir eleman -1 değeri döndürür
        // eğer eleman dizi içerisinde varsa index numarsı döner
        Console.WriteLine(Array.IndexOf(sayilar,23));
        Console.WriteLine(Array.IndexOf(sayilar, 203));


        // dizi içerisindeki belli index aralığında elemanların temizlenmesi
        Array.Clear(sayilar, 2, 2);

        




        // Dolaşma
        for (int i = 0;i< numbers.Length; i++)
        {
           // Console.WriteLine("sayilar[{0}] = {1} - numbers[{0}] = {2}",i, sayilar[i], numbers.GetValue(i));
            Console.WriteLine($"sayilar[{i}] = " +
                $"{sayilar[i],3} - " +
                $"numbers[{i}] = " +
                $"{numbers.GetValue(i),3} - " +
                $"sayilar2[{i}] = " +
                $"{sayilar2[i],3} - " );

        }

        




        Console.ReadKey();
    }

  
}