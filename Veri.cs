namespace Todo
{
    public class Veri : Kart
    {
        public static List<Kart> kartlar = new List<Kart>();
        public static List<Kişi> kişiler = new List<Kişi>();

        static Veri()
        {
            kişiler = new List<Kişi>()
            {
                new Kişi{id = 1, isim= "Ceyhun"},
                new Kişi{id = 2, isim= "Abdullah"},
                new Kişi{id = 3, isim= "Ahmet"},
                new Kişi{id = 4, isim= "Burak"},
            };

            kartlar = new List<Kart>()
            {
                new Kart{başlık= "Ödev", içerik= "C# Ödevi Yapılacak", kişi = "Ceyhun",size ="M",line ="TODO"},
                new Kart{başlık="Toplantı",içerik=" Proje Toplantısı",kişi="Abdullah",size= "XL",line ="DONE"},
                new Kart{başlık= "Eğitim", içerik= "C# Video izlenecek", kişi = "Ahmet",size ="XS",line ="TODO"},
                new Kart{başlık="Proje",içerik=" TODO Projesi",kişi="Burak",size= "L",line ="DONE"}
            };
        }
             public static void VeriYaz()
             {
                  foreach (var item in kartlar)
                  {
                    Console.WriteLine(item.başlık + " " + item.içerik + " " + item.kişi + " " + item.size + " " + item.line);
                  }
             }
     }     

}
