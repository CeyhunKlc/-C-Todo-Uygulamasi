using Todo;

namespace todolist
{
    class Taşımaİşlemi : Veri
    {
        public static void Taşı()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            foreach (var item in kartlar)
            {
                if(item.başlık == input)
                {
                    Console.WriteLine("Bulunan Kart Bigileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık     : " + item.başlık);
                    Console.WriteLine("İçerik     : " + item.içerik);
                    Console.WriteLine("Atanan Kişi: " + item.kişi);
                    Console.WriteLine("Büyüklük   : " + item.size);
                    Console.WriteLine("Line       : " + item.line);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşıman istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) INPROGRESS");
                    Console.WriteLine("(3) DONE");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    switch (input1)
                    {                        
                        case 1:
                        item.line = "TODO";
                        break;
                        case 2:
                        item.line = "INPROGRESS";
                        break;
                        case 3:
                        item.line = "DONE";
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                    break;
                }
            }
        }
    }  
}