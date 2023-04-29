/*Queue<T>
 * System.Collection.Generic sınıfına dahil
 * Generic yapıdadır
 * T type
 * firt in first out fifo ilk giren ilk çıkar
 * Enqueue() -ekleme
 * Dequeue() -çıkarma
 * Peek() -en üstteki eleman
 * Count() -eleman sayısı
 * Clear() -elemanları temizleme
 * 
 * kullanımı
 * os çalışma önbelleği
 * ağ yazıcıları
 * mesaj kuyrukları
 * buffer (tampon)
 * 
 * eklenen dizinin sonuna eklenir ve çıkarılanlar diznin başından çıkartılır
 */
internal class Program
{
    private static void Main(string[] args)
    {
        // Queue Temel Kavramlar
        // QueueTemelleri();


        // Queue Uygulama
        var Sesliharfler = new List<char>()
        {
            'a','e','o','u','ü','ö'
        };

        // consoldan okunan tuş değerini tutacak değişken tanımladık
        ConsoleKeyInfo secim;

        // kuyruk tanımlaması yapılıyor
        var kuyruk=new Queue<char>();

        foreach(char c in Sesliharfler)
        {
            Console.WriteLine();
            // Sesli harfin eklenip eklenmiyeceği soruluyor
            Console.WriteLine($"{c,-5} kuyruğa eklensin mi? [e/h]");
            // Kullanıcıdan tuş isteniyor
            secim=Console.ReadKey();
            Console.WriteLine();
            // seçimi kontrol ediyoruz
            if (secim.Key == ConsoleKey.E)
            {
                // seçim e tuşu ise kuyruğa ekleniyor
                kuyruk.Enqueue(c);
                Console.WriteLine($"\n{c,-5} kuyruğa eklendi");
                Console.WriteLine($"kuyruktaki eleman sayısı : {kuyruk.Count()} ");
                Console.WriteLine();
            }

        }
        Console.Write("tüm elemanları kaldırmak istiyorsanız esc tuşuna basınız");
        secim = Console.ReadKey();
        if (secim.Key == ConsoleKey.Escape)
        {
            while (kuyruk.Count() > 0)
            {
                Console.WriteLine($"{kuyruk.Peek(),5} elemani kaldiriliyor");
                Console.WriteLine($"{kuyruk.Dequeue(),5} elemanı kaldırıldı");
                Console.WriteLine($"{kuyruk.Count(),5} tane eleman var");
                Console.WriteLine();
            }
            Console.WriteLine("tüm elemanlar kaldırıldı");

        }
        else
        {
            Console.WriteLine("program bitti");
        }

        

        Console.ReadKey();



    }

    private static void QueueTemelleri()
    {
        // Queue
        // tanımlama
        var KarakterKuyrugu = new Queue<char>();

        // ekleme
        KarakterKuyrugu.Enqueue('a');
        KarakterKuyrugu.Enqueue('e');
        KarakterKuyrugu.Enqueue('u');
        KarakterKuyrugu.Enqueue('o');


        // kuytuktaki eleman sayısı
        Console.WriteLine("kuytuktaki eleman sayisi :" + KarakterKuyrugu.Count());

        // kuyruğun başındaki eleman
        Console.WriteLine("kuyruğun başındaki eleman : " + KarakterKuyrugu.Peek());

        // çıkarma
        // Dequeue ifadesi çıkartılan elemanı yani ilk eklenen elemanı döndürür ve bu elemanı çıkartır
        Console.WriteLine("çıkartılan eleman : " + KarakterKuyrugu.Dequeue());
        Console.WriteLine("kuytuktaki eleman sayisi :" + KarakterKuyrugu.Count());
        Console.WriteLine("kuyruğun başındaki eleman : " + KarakterKuyrugu.Peek());



        // diziye atama
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("dizideki elemanlar");
        var dizi = KarakterKuyrugu.ToList();
        dizi.ForEach(x => Console.WriteLine(x));


        Console.ReadKey();
    }
}