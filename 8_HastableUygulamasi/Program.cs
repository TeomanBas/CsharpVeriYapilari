using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // hastable uygulaması

        // başlığı okuma
        Console.WriteLine("başlığı giriniz: ");
        string baslik=Console.ReadLine();

        // karakterleri küçültme
        baslik = baslik.ToLower();

        // hastable
        //hastable ifadesinde tanımlanan anahtarlar tekil olmak zorunda aynı anahtardan bir tane olmalıdır.
        var KarakterSeti = new Hashtable()
        {
            {'ç','c'},
            {'ü','u'},
            {'ğ','g'},
            {'ö','o'},
            {'ı','i'},
            {' ','-'},
            {'.','_'},
            {'\'','-'}
        };

        foreach (DictionaryEntry item in KarakterSeti)
        {
            baslik = baslik.Replace((char)item.Key, (char)item.Value);
        };

        Console.WriteLine(baslik);

        Console.ReadKey();
    }
}