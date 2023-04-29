internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("bir sayi giriniz");
        int Sayi = Convert.ToInt32(Console.ReadLine());

        var SayiYigini= new Stack<int>();
        
        // aşağıdaki ifade hata verecketir çünkü biz SayiYigini değişkenini int olarak tanimladik
        //SayiYigini.Push('A');

        while (Sayi > 0)
        {
            int k = Sayi % 10;
            SayiYigini.Push(k);
            Sayi = Sayi / 10;
            Console.WriteLine(SayiYigini.Peek());
        }
        Console.WriteLine(new string('-',25));
        int i = 0;
        int n = SayiYigini.Count() - 1;
        foreach (int s in SayiYigini)
        {
            
            Console.WriteLine($"{s} x {Math.Pow(10,n-i)} = {s*Math.Pow(10,n-i)}");
            i++;
        }



        Console.ReadKey();
    }
}