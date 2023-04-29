/*HashSet<T>
 * System.Collection.Generic sınıfına dahil
 * Elemanalar benzersizdir
 * sıralma yoktur
 * küme işlemlerine izin verir
 * 
 */



internal class Program
{
    private static void Main(string[] args)
    {
        // hashset tanımlama
        var sesliharf = new HashSet<char>()
        {
            'e','ı','i','u','ü','o','Ö','b'
        };

        KoleksiyonYazdir(sesliharf);
        // ekleme
        sesliharf.Add('a');
        KoleksiyonYazdir(sesliharf);

        // eleman silme
        sesliharf.Remove('b');
        KoleksiyonYazdir(sesliharf);


        //listeye alfabedeki harfleri ekleme
        var alfabe = new List<char>();
        for(int i = 97; i < 123; i++)
        {
            alfabe.Add((char)i);
            // alfabe.ForEach(k => Console.WriteLine(k));
        }
        KoleksiyonYazdir(alfabe);
        Console.WriteLine();

        // türkçede kullanılan sesli harfler
        // sesliharf.ExceptWith(alfabe);
        // KoleksiyonYazdir(sesliharf);
        
        // türkçede bulunan sesli harfleri alfabeye ekleyelim
        // sesliharf.UnionWith(alfabe);
        // KoleksiyonYazdir(sesliharf);

        // hem türkçeden hemde ingilizce harfler içerisinde ortak olan sesli harfler
        // sesliharf.IntersectWith(alfabe);
        // KoleksiyonYazdir(sesliharf);

        // alfabe ve sesliharfler in kesişimi dışında kalan harfler
        // sesliharf.SymmetricExceptWith(alfabe);
        // KoleksiyonYazdir(sesliharf);



        Console.ReadKey();
    }

    // yazdirma işlemi için fonksiyon oluşturduk
    // IEnumerable ifadesi bir KoleksiyonYazdır fonksiyonunu hem list hemde hashset için kullanabilmemizi sağlayan ortak bir interface
    static void KoleksiyonYazdir(System.Collections.IEnumerable koleksiyon)
    {
        Console.WriteLine();
        int harfsayaci = 0;
        foreach (char c in koleksiyon)
        {
            Console.Write($"{c,5}");
            harfsayaci++;

        }
        Console.WriteLine();
        //IEnumerable arayüzünü kullandığımız için count fonksiyonunu kullanamıyoruz
        //Console.WriteLine("eleman sayısı : {0}", koleksiyon.Count);
        //count ifadesinin yerine geçebilecek bir çözüm olarak döngü her döndüğünde bir harf sayacını arttırmak olabilir
        Console.WriteLine("eleman sayısı : {0}", harfsayaci);


        
    }
}