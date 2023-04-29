using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYapisi
{
    //yeni bir class ve namespace yapısı oluşturduk ve buraya  bir class tanımlaması yaptık
    public class OgretimElemani
    {
        // property
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // default constructor
        public OgretimElemani()
        {
            
        }

        // 3 üncü alternatif tanımlama için  default constructor u override ediyoruz
        public OgretimElemani(int SicilNoAlt, string AdiAlt, string SoyadiAlt, bool CinsiyetAlt)
        {
            SicilNo = SicilNoAlt;
            Adi = AdiAlt;
            Soyadi = SoyadiAlt;
            Cinsiyet = CinsiyetAlt;
        }

        // override işlemi genel
        public override string? ToString()
        {
            return $"{SicilNo,-8}" +
                $"{Adi,-8}" +
                $"{Soyadi,-8}" +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }

        


    }
}
