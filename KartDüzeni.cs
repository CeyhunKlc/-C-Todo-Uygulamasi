namespace Todo
{
    public class KartDüzeni
    {
        public static void KartGöster(string Line, List<Kart> listeismi)
        {
            Console.WriteLine(Line);
            Console.WriteLine("*********************");
            foreach (var item in listeismi)
            {
                Console.WriteLine("Başlık   :" + item.başlık);
                Console.WriteLine("İçerik   :" + item.içerik);
                Console.WriteLine("Atanan Kişi:" + item.kişi);
                Console.WriteLine("Büyüklük   :" + item.size);
                Console.WriteLine("-----------------------");

            }
        }
    }
}