using System;
using System.Collections.Generic;
using todolist;

namespace Todo
{ 
    class program
    { 
        static void Main(string[]args)
        { 
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int input = Convert.ToInt32(Console.ReadLine());
            

            switch (input)
            { 
                case 1:
                Listelemİşlemi.Listele();
                break;
                case 2:
                Eklemeİşlemi.Ekle();
                break;
                case 3:
                Silmeİşlemi.sil();
                break;
                case 4:
                Taşımaİşlemi.Taşı();
                break;
                default:
                Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                break;
            }
        }
    }
}
