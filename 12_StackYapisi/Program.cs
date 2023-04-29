/* stack<T>
 * System.Collection.Generic sınıfı altında yer alır
 * Generic yapıdadır yani boxing işlemerine gerek yoktur
 * T tipi ifade eder
 * last-in first-out lifo son gelen ilk çıkar
 * push() ekleme
 * pop() çıkartma
 * peek() en üstteki elemanı alma
 * clear() temizleme
 * count() eleman sayısını alma
 * ToArray Dizi
 * 
 * --kullanımları
 * fonksiyonların çağrılması ve özyinelemeli (recursive)
 * Uygulamaların listesini tutma
 * söz dizilimi hataları yakalamak
 * geri izleme işlemleri
 * ayrıştırma (parcing)
 * ters çevirme 
 * hafıza yönetimi
 * tarayıcı sekmelerinde 
 */
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Basit Yığın örneği
        // YiginOrnek();
        var KarakterYigini = new Stack<char>();
        for (int i = 65; i <= 90; i++)
        {
            KarakterYigini.Push((char)i);
            Console.WriteLine($"{KarakterYigini.Peek()} yığına eklendi");
        }


        // ek bilgi ihtiyaç halinde tüm yığını bir diziyede çevirebiliriz
        var dizi = KarakterYigini.ToArray();

        Console.WriteLine("yığından çıkarma işlemi için bir tuşa basınız");

        Console.ReadKey();

        

        while (KarakterYigini.Count > 0)
        {
            Console.WriteLine(KarakterYigini.Pop() + " : yığından çıkartıldı");
        }

        Console.ReadKey();

    }

    private static void YiginOrnek()
    {
        // tanımlama
        // burada kullanacağımız ifade için System.Collection içerisindeki değilde System.Collection.Generic içindeki ifadeyi 
        // kullanacağız
        var KarakterYigini = new Stack<char>();

        // ekleme
        KarakterYigini.Push('A');
        Console.WriteLine(KarakterYigini.Peek());
        KarakterYigini.Push('B');
        Console.WriteLine(KarakterYigini.Peek());
        KarakterYigini.Push('C');
        Console.WriteLine(KarakterYigini.Peek());

        // çıkarma
        Console.WriteLine(KarakterYigini.Pop() + " : yığından çıkartıldı");
        Console.WriteLine(KarakterYigini.Pop() + " : yığından çıkartıldı");
        Console.WriteLine(KarakterYigini.Pop() + " : yığından çıkartıldı");
    }
}