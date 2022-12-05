namespace Todo
{ 
    public class Eklemeİşlemi
    { 
        public static void Ekle()
        {
            Kart yeniKart = new Kart();

            Console.WriteLine("Başlık Giriniz:");
            string input = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz XS(1), S(2),M(3), L(4),XL(5)");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Atanacak Kişiyi seçiniz:");
            int input3 = Convert.ToInt32(Console.ReadLine());

            yeniKart = new Kart();
            yeniKart.başlık = input;
            yeniKart.içerik= input1;

            if (input2 != null)
            { 
                string büyüklükDeğeri =  Enum.GetName(typeof(EnumSize),input2);
                yeniKart.size = büyüklükDeğeri;
            }
            
            else
            { 
                Console.WriteLine("Geçersiz bir karakter girdiniz.Tekrar deneyiniz.");
                Ekle();
            }

            var kişi = Veri.kişiler.FirstOrDefault(x=> x.id == input3);
            if(kişi!= null)
            { 
                Veri.kartlar.Add(yeniKart);
            }
            else
            { 
                Console.WriteLine("Geçeresiz bir sayı girdiniz.");
                Ekle();
            }
        }

    }
}