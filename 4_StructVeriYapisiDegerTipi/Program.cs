using System;

namespace StructVeriYapisiDegerTipi_4
{
    // struct tanımı
    public struct Nokta
    {
        // struct yapısı için protperties tanımlamaları
        public int X { get; set; }
        public int Y { get; set; }

        // override metodu tanımladık
        public override string ToString()
        {
            return $"{X},{Y}";
        }

        // default constructer bu yapıyı struct yapısı içerisinde kullanamayız ancak class yapıları içerisinde kullanabiliriz.
        public Nokta(int x,int y)
        {
            X = x;
            Y = y;
        }

        // Yapıya yeni üye -> metotd tanımı
        // bu yapı değikenlerimizi origine çeken sıfırlayan bir yapı olacak
        public void SetOrigin()
        {
            //this struct ifadesinde Nokta ismindeki struct yapısını temsil eder
            this.X = 0;
            this.Y = 0;
        }
        
        // bu yapı değişkenlerin içindeki değerleri birbiri ile değiştiren bir yapı olacak
        public void Degistir()
        {
            var gecici = X;
            X = Y;
            Y= gecici;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // x ve y değerlerimizi tanımladık
            var n1 = new Nokta(3, 4);
            Console.WriteLine($"n1 : {n1}");
            var n2 = n1;
            Console.WriteLine($"n2 : {n2}");
            n1.Degistir();
            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            n1.X = -1;
            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");

           // buradaki örneklerde gördüğümüz gibi değerlerin değişmediği
           // ve oluşturudğumuz struc yapısının üyelerinin değer tipli çalıştığını görmüş olduk

            Console.ReadKey();
        }
    }
}