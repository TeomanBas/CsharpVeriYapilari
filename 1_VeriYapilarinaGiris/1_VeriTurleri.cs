internal class VeriTurleri_1
{
    private static void Main(string[] args)
    {
        /*Veri Yapıları
         * veri yapıları ikiye ayrılır 
         * "Yerleşik veri türleri(build-in)" ve "Kullanıcı taraflı veri türleri(user/custom defined)"
         * 1-build-in veri türleri "int,double,string,char,decimal,bool" gibi objelerden oluşur.
         * 2-custom defined veri türleri build-in veri türlerinin bir arada kullanılmasıyla yeni bir veri türü 
         * oluşturulmasıdır.iki türü vardır "struct" ve "class" , 
         * struct lar value yani değer tiplidir clash lar ise referans tiplidir.
         */

        /*alt ve üst limitler
         * int sayi=5; gibi bir tanımlama yaptığımızda bellekte bir yer ayrılır ve bu ayrılan alanın içerisine 
         * 5 değeri nin olduğu bilgisi yazılır burada alt ve üst limitleri belirleyen değişkeni tanımladığımız tiptir
         * yani alt ve üst limitleri değişkenin tipi belirler burada bunu int belirlemiştir.
         * 
         * int16=2 byte, int32=4 byte, int64=8 byte, Byte=1 byte, SByte=1byte (1 byte=8 bit) , 2 üzeri 8 eşiti 256 olması
         * bizim 1byte lık bir alan içerisinde 256 tane karakterin kodlanabileceği anlamına gelir.
         * 
         * 8bit => {a7 a6 a5 a4 a3 a2 a1 a0} olarak göstermeye çalışırsak soldan birinci bit "a7" işaret bitidir ve burası 1 ise negatif 0 ise pozitif olduğu anlamına gelir.
         * 
         * SByte (signed/işaretli) = negatif sayıları sıfırı ve pozitif sayıları tutabilir.
         * Byte(unsigned/işaretsiz) = sıfırı ve pozitif sayıları tutabilir.
         * 
         * alt ve üst limitler hesaplanırken baştaki işaret biti hesaba katılmaz örn "10000000" ifadesini açarsak 2 üzeri 0 dan
         * 2 üzeri 7 ye kadar gider burada 0 olan kısımlar örn 2 üzeri 3 sağdan 5 inci sıfıra denk gelen kısım 0 olarak alınır hesaplanmaz 
         * eğer 1 olsaydı 2 üzeri 4 den 15 değeri hesaba katılacaktı ancak 2 üzeri 7  ye karşılık gelen 1 işaret biti olduğu için  normalde 
         * hesaplamamız gereklidir ve sadece bu gösterimde bir istisna uygulanır ve işaret biti hesaba katılarak hesaplanır
         * açılan değer 128 dir ve 1 den dolayı negatif bir sayıdır
         * [1 =>2 üzeri 7=128 => 128] - 
         * [0 =>2 üzeri 6=64 => 0] - 
         * [0 =>2 üzeri 5=32 => 0] - 
         * [0 =>2 üzeri 4=16 => 0] - 
         * [0 =>2 üzeri 3=8 => 0] - 
         * [0 =>2 üzeri 2=4 => 0] - 
         * [0 =>2 üzeri 1=2 => 0] - 
         * [0 =>2 üzeri 0=1 => 0] = -128
         * 
         * 10001111 için hesaplayalım bu örnek genel bir örnektir;
         * [1 =>2 üzeri 7=128 => 0] - 
         * [0 =>2 üzeri 6=64 => 0] - 
         * [0 =>2 üzeri 5=32 => 0] - 
         * [0 =>2 üzeri 4=16 => 0] - 
         * [1 =>2 üzeri 3=8 => 8] - 
         * [1 =>2 üzeri 2=4 => 4] - 
         * [1 =>2 üzeri 1=2 => 2] - 
         * [1 =>2 üzeri 0=1 => 1] = -15
         * 
         * 00000001 için hesaplayalım bu örnek genel bir örnektir;
         * [0 =>2 üzeri 7=128 => 0] + 
         * [0 =>2 üzeri 6=64 => 0] + 
         * [0 =>2 üzeri 5=32 => 0] + 
         * [0 =>2 üzeri 4=16 => 0] + 
         * [1 =>2 üzeri 3=8 => 8] + 
         * [1 =>2 üzeri 2=4 => 4] + 
         * [1 =>2 üzeri 1=2 => 2] + 
         * [1 =>2 üzeri 0=1 => 1] = +15
         * 
         * 01111111 için hesaplayalım bu örnek genel bir örnektir;
         * [0 =>2 üzeri 7=128 => 0] + 
         * [1 =>2 üzeri 6=64 => 64] + 
         * [1 =>2 üzeri 5=32 => 32] + 
         * [1 =>2 üzeri 4=16 => 16] + 
         * [1 =>2 üzeri 3=8 => 8] + 
         * [1 =>2 üzeri 2=4 => 4] + 
         * [1 =>2 üzeri 1=2 => 2] + 
         * [1 =>2 üzeri 0=1 => 1] = +127 sıfır da pozitif bir sayı sayıldığı için sıfırla beraber 128 karakterlik bir yapı olmuş oluyor
         * ve 128 tanede negatif ifade yi eklersek 256 karakter olur
         * 
         * 0000000 için hesaplayalım Byte(unsigned) işaretsiz;
         * [0 =>2 üzeri 7=128 => 0] + 
         * [0 =>2 üzeri 6=64 => 0] + 
         * [0 =>2 üzeri 5=32 => 0] + 
         * [0 =>2 üzeri 4=16 => 0] + 
         * [0 =>2 üzeri 3=8 => 0] + 
         * [0 =>2 üzeri 2=4 => 0] + 
         * [0 =>2 üzeri 1=2 => 0] + 
         * [0 =>2 üzeri 0=1 => 0] = 0
         * burada tüm bitlerin 0 olduğu durumda değerin sıfır olduğu anlamına gelir unsigned işaretsiz yani işaret biti dikkate alınmaz ve 
         * hesaplamaya dahil edilmiş olur buda bize 0 değerini verir.
         * 
         * 
         * verini boyutunu "sizeOf" ile görebiliriz.
         * 
         */

        // 8-bit integer
        Console.WriteLine(nameof(SByte));
        Console.WriteLine($"alt limit       : {SByte.MinValue,20}");
        Console.WriteLine($"üst limit       : {SByte.MaxValue,20}");
        Console.WriteLine($"boyut           : {sizeof(SByte),20} tane 8 bit anlamına gelir");
        Console.WriteLine();
        Console.ReadKey();

        // unsigned 8-bit integer
        Console.WriteLine(nameof(Byte));
        Console.WriteLine($"alt limit       : {Byte.MinValue,20}");
        Console.WriteLine($"üst limit       : {Byte.MaxValue,20}");
        Console.WriteLine($"boyut           : {sizeof(Byte),20} tane 8 bit anlamına gelir");
        Console.WriteLine();
        Console.ReadKey();

        // 16-bit integer
        Console.WriteLine(nameof(Int16));
        Console.WriteLine($"alt limit       : {Int16.MinValue,20}");
        Console.WriteLine($"üst limit       : {Int16.MaxValue,20}");
        Console.WriteLine($"boyut           : {sizeof(Int16),20} tane 8 bit anlamına gelir");
        Console.WriteLine();
        Console.ReadKey();

        // 16-bit integer
        Console.WriteLine(nameof(UInt16));
        Console.WriteLine($"alt limit       : {UInt16.MinValue,20}");
        Console.WriteLine($"üst limit       : {UInt16.MaxValue,20}");
        Console.WriteLine($"boyut           : {sizeof(UInt16),20} tane 8 bit anlamına gelir");
        Console.WriteLine();
        Console.ReadKey();

        // 32-bit integer
        Console.WriteLine(nameof(Int32));
        Console.WriteLine($"alt limit       : {Int32.MinValue,20}");
        Console.WriteLine($"üst limit       : {Int32.MaxValue,20}");
        Console.WriteLine($"boyut           : {sizeof(Int32),20} tane 8 bit anlamına gelir");
        Console.WriteLine();
        Console.ReadKey();

        // 32-bit integer
        Console.WriteLine(nameof(UInt32));
        Console.WriteLine($"alt limit       : {UInt32.MinValue,20}");
        Console.WriteLine($"üst limit       : {UInt32.MaxValue,20}");
        Console.WriteLine($"boyut           : {sizeof(UInt32),20} tane 8 bit anlamına gelir");
        Console.WriteLine();
        Console.ReadKey();

        // Double
        Console.WriteLine(nameof(Double));
        Console.WriteLine($"alt limit       : {Double.MinValue,20}");
        Console.WriteLine($"üst limit       : {Double.MaxValue,20}");
        Console.WriteLine($"boyut           : {sizeof(Double),20} tane 8 bit anlamına gelir");
        Console.WriteLine();
        Console.ReadKey();


    }
}