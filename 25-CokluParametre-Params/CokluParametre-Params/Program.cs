internal class Program
{
    private static void Main(params string[] mesaj)
    {
        foreach (var mesajItem in mesaj)
        {
            switch(mesajItem)
            {
                case ("-a"):
                    Console.WriteLine("yardım sayfası");
                    Console.WriteLine();
                    break;
                case ("-b"):
                    Console.WriteLine("-b parametresi için işlemler");
                    Console.WriteLine();
                    break;
                case ("-c"):
                    Console.WriteLine("-c parametresi için işlemler");
                    Console.WriteLine();
                    break;
                case ("-d"):
                    Console.WriteLine("-c parametresi için işlemler");
                    Console.WriteLine();
                    break;
                case ("-h"):
                    Console.WriteLine("-c parametresi yardım sayfası");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Geçersiz parametre");
                    Console.WriteLine();
                    break;
            }
        }

        
    }
}