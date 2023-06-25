﻿internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("lütfen parametre giriniz");
        }
        else
        {
            var arrayLength = int.Parse(args[0]);
            var array=new int[arrayLength];
            var initialValue = int.Parse(args[1]);
            var increment = int.Parse(args[2]);

            for (var counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = initialValue + increment*counter;
            }
            Console.WriteLine($"{"Index"}{"Value",8}");
            for(int counter=0; counter < array.Length; counter++)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");
            }
        }
    }
}
