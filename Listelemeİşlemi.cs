namespace Todo
{
    public class Listelemİşlemi
    {
        private static Board boards;
        public static void LineBoard()
        {
            var todo = Veri.kartlar.Where(x => x.line == "TODO").ToList();
            var inprogress = Veri.kartlar.Where(x => x.line == "INPROGRESS").ToList();
            var done = Veri.kartlar.Where(x => x.line == "DONE").ToList();


            boards = new Board();
            boards.ToDO = todo;
            boards.InProgress = inprogress;
            boards.Done = done;

        }
        public static void Listele()
        {
            LineBoard();
            KartDüzeni.KartGöster("TODO Line", boards.ToDO);
            KartDüzeni.KartGöster("INPROGRESS Line", boards.InProgress);
            KartDüzeni.KartGöster("DONE Line", boards.Done);
        }


    }
}