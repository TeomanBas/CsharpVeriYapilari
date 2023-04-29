public class PersonelBase
{
    public string Adi { get; set; }
    public decimal Maas { get; set; }
    public int ScilNo { get; set; }
    public string Soyadi { get; set; }

    public override string ToString()
    {
        return $"{Adi,-10} {Soyadi,-10} {Maas,-10}";
    }
}