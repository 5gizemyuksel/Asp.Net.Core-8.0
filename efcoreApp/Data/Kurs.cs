namespace efcoreApp.Data
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string? Baslik { get; set; }

//kurs açıldığında illaki öğretmeni de zorunlu olarak olacaksa intin sonuna soru işareti koymuyoruz öğretmenıd başlığında ama öğretmensiz de kurs açılır sonra öğretmen ataması yapılır diyorsak intin yanına soru işaretiyle null olabilir demeliyiz.
        public int? OgretmenId { get; set; } 
        public Ogretmen Ogretmen { get; set; } = null!;
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}