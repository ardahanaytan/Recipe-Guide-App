namespace YazLab1_1
{
    public class Tarif
    {
        // Özellikler
        public string TarifAdi { get; set; }
        public string Kategori { get; set; }
        public int HazirlamaSuresi { get; set; }
        public string Talimatlar { get; set; }
        public float Maliyet { get; set; }
        public string Path { get; set; }
        public int MalzemeSayisi { get; set; }

        // Yapıcı Metot
        public Tarif(string tarifAdi, string kategori, int hazirlamaSuresi, string talimatlar, float maliyet, string path, int malzemeSayisi)
        {
            TarifAdi = tarifAdi;
            Kategori = kategori;
            HazirlamaSuresi = hazirlamaSuresi;
            Talimatlar = talimatlar;
            Maliyet = maliyet;
            Path = path;
            MalzemeSayisi = malzemeSayisi;
        }
    }


    public class Malzeme
    {
        // Özellikler
        public string MalzemeAdi { get; set; }
        public string ToplamMiktar { get; set; }
        public string MalzemeBirim { get; set; }
        public float BirimFiyat { get; set; }

        // Yapıcı Metot
        public Malzeme(string malzemeAdi, string toplamMiktar, string malzemeBirim, float birimFiyat)
        {
            MalzemeAdi = malzemeAdi;
            ToplamMiktar = toplamMiktar;
            MalzemeBirim = malzemeBirim;
            BirimFiyat = birimFiyat;
        }
    }

    public class Iliski
    {
        // Özellikler
        public int MalzemeID { get; set; }
        public int TarifID { get; set; }
        public float Miktar { get; set; }

        // Yapıcı Metot
        public Iliski(int malzemeID, int tarifID, float miktar)
        {
            MalzemeID = malzemeID;
            TarifID = tarifID;
            Miktar = miktar;
        }
    }
}