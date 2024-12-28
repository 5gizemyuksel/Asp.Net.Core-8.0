using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Ogretmen
    {
        [Key]
        public int OgretmenId { get; set; }
        public string? Ad { get; set; } 
        public string? Soyad { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode =false)]
        public DateTime BaslamaTarihi { get; set; }

        //bir öğretmen birden fazla kurs verebilir ama kurslar tablosunda vir tane öğretmen belirttiğimiz için o kursu birden fazla öğretmen veremez.
        public ICollection<Kurs> Kurslar { get; set; } = new List<Kurs>();




    }
}