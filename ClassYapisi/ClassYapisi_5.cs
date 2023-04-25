namespace ClassYapisi
{
    internal class ClassYapisi_5
    {
        private static void Main(string[] args)
        {
            // tanımlama
            OgretimElemani OgrGor = new OgretimElemani();

           
            // atama
            OgrGor.SicilNo = 101;
            OgrGor.Adi = "Ahmet";
            OgrGor.Soyadi = "Yalçın";
            OgrGor.Cinsiyet = true;
            Console.WriteLine(OgrGor);

            // alternatif tanımlama ve atama
            OgretimElemani OgrGor1 = new OgretimElemani()
            {
                SicilNo = 102,
                Adi = "mehmet",
                Soyadi = "dinç",
                Cinsiyet = true
            };

            Console.WriteLine(OgrGor1);

            // 3 üncü bir alternatif tanımlama bu kısımda daha kısa bir tanımlama yolu direkt parametreler verilerek
            // tanımlama yapılabilir bunun için bu tanımlamaya uygun class içine bir metot oluşturmamız gerekiyor
            OgretimElemani OgrGor2 = new OgretimElemani(100, "eda", "duman", false);
            Console.WriteLine(OgrGor2);


            //bu kısım classların referans tipleri ilişkin örnekler yaptığımız kısım
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------CLASLARIN REFERANS DEGER TiPi------------------------");
            Console.WriteLine();
            //region ifadesi komut satırları arasında istediğimiz satıları gizlemek için kullanılır
            #region
            var Liste1 = new List<OgretimElemani>()
            {
                new OgretimElemani(111,"zeynep","dinç",false),
                new OgretimElemani(112,"neşe","yılmaz",false),
                new OgretimElemani(113,"ayşe","dağ",false),
                new OgretimElemani(114,"aylin","inan",false),
                new OgretimElemani(115,"kübra","yeşil",false),

            };
            Console.WriteLine("liste1");
            Liste1.ForEach(o => Console.WriteLine(o));
            Console.WriteLine();

            var Liste2 = Liste1;
            Console.WriteLine("liste2");
            Liste2.ForEach(o => Console.WriteLine(o));
#endregion
            

            Console.WriteLine();
            Liste2.Add(new OgretimElemani(116, "ömer", "han", true));
            Console.WriteLine("Liste2 elemean eklendi");

            Console.WriteLine("Liste1");
            Liste1.ForEach(o => Console.WriteLine(o));
            Console.WriteLine();

            Console.WriteLine("Liste2");
            Liste2.ForEach(o => Console.WriteLine(o));
            Console.WriteLine();

            Console.WriteLine("eleman liste2 ye eklendi ancak liste1 e de eklenmiş görünüyor");
            Console.WriteLine("---------");
            Liste1.RemoveAt(0);
            Console.WriteLine("Liste 1 den 0 ıncı eleman silindi");

            Console.WriteLine("Liste1");
            Liste1.ForEach(o => Console.WriteLine(o));
            Console.WriteLine();

            Console.WriteLine("Liste2");
            Liste2.ForEach(o => Console.WriteLine(o));
            Console.WriteLine();

            Console.WriteLine("Liste 2 den de silindi");


            Console.ReadKey();
        }

       
    }
}