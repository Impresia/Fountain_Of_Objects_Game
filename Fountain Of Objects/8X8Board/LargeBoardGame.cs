

using Fountain_Of_Objects.Game;
using Fountain_Of_Objects.GameObjects;

namespace Fountain_Of_Objects._8X8Board
{
    public class LargeBoardGame : MainGame
    {

        private List<string> squares = new List<string>() { P, " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ",
            " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " ," ", " ", " ", " ", " ", " ", " ", " ",
            " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "};
        
        
        protected override int maxRow { get; set; } = 7;
        protected override int maxCol { get; set; } = 7;
        protected override int minRow { get; set; } = 0;
        protected override int minCol { get; set; } = 0;

        public override bool itsLargeBoardGame { get; protected set; } = true;

        public override void GetRandomNums()
        {
            base.GetRandomNums();

            randomPitRow2 = random.Next(maxRow + 1);
            randomPitCol2 = random.Next(maxCol + 1);

            randomPitRow3 = random.Next(maxRow + 1);
            randomPitCol3 = random.Next(maxCol + 1);

            randomPitRow4 = random.Next(maxRow + 1);
            randomPitCol4 = random.Next(maxCol + 1);



            randomAmarokRow2 = random.Next(maxRow + 1);
            randomAmarokCol2 = random.Next(maxCol + 1);

            randomAmarokRow3 = random.Next(maxRow + 1);
            randomAmarokCol3 = random.Next(maxCol + 1);

            randomMaelstrmRow2 = random.Next(maxRow + 1);
            randomMaelstrmCol2 = random.Next(maxCol + 1);



            (int, int)[] coord = new (int, int)[] {(randomRow, randomCol), (randomPitRow, randomPitCol), (randomAmarokRow, randomAmarokCol),
                (randomPitRow2, randomPitCol2), (randomAmarokRow2,randomAmarokCol2), (randomPitRow3, randomPitCol3), (randomPitRow4, randomPitCol4),
            (randomAmarokRow3,randomAmarokCol3),(randomMaelstrmRow,randomMaelstrmCol), (randomMaelstrmRow2,randomMaelstrmCol2) };

            (int, int)[] coordinates = CheckEquality(coord);

            (randomRow, randomCol) = coordinates[0];
            (randomPitRow, randomPitCol) = coordinates[1];
            (randomAmarokRow, randomAmarokCol) = coordinates[2];
            (randomPitRow2, randomPitCol2) = coordinates[3];
            (randomAmarokRow2, randomAmarokCol2) = coordinates[4];
            (randomPitRow3, randomPitCol3) = coordinates[5];
            (randomPitRow4, randomPitCol4) = coordinates[6];
            (randomAmarokRow3, randomAmarokCol3) = coordinates[7];
            (randomMaelstrmRow, randomMaelstrmCol) = coordinates[8];
            (randomMaelstrmRow2, randomMaelstrmCol2) = coordinates[9];

        }








        public override string DisplayIcon(int row, int col, string o)
        {
            for (int i = 0; i < squares.Count; i++)
            {
                if (squares[i] == P || squares[i] == activeFountain || squares[i] == inActiveFountain)
                    squares[i] = " ";
                else
                    continue;

            }

            return (row, col) switch
            {
                (0, 0) => squares[0] = o,
                (0, 1) => squares[1] = o,
                (0, 2) => squares[2] = o,
                (0, 3) => squares[3] = o,
                (0, 4) => squares[4] = o,
                (0, 5) => squares[5] = o,
                (0, 6) => squares[6] = o,
                (0, 7) => squares[7] = o,

                (1, 0) => squares[8] = o,
                (1, 1) => squares[9] = o,
                (1, 2) => squares[10] = o,
                (1, 3) => squares[11] = o,
                (1, 4) => squares[12] = o,
                (1, 5) => squares[13] = o,
                (1, 6) => squares[14] = o,
                (1, 7) => squares[15] = o,


                (2, 0) => squares[16] = o,
                (2, 1) => squares[17] = o,
                (2, 2) => squares[18] = o,
                (2, 3) => squares[19] = o,
                (2, 4) => squares[20] = o,
                (2, 5) => squares[21] = o,
                (2, 6) => squares[22] = o,
                (2, 7) => squares[23] = o,

                (3, 0) => squares[24] = o,
                (3, 1) => squares[25] = o,
                (3, 2) => squares[26] = o,
                (3, 3) => squares[27] = o,
                (3, 4) => squares[28] = o,
                (3, 5) => squares[29] = o,
                (3, 6) => squares[30] = o,
                (3, 7) => squares[31] = o,

                (4, 0) => squares[32] = o,
                (4, 1) => squares[33] = o,
                (4, 2) => squares[34] = o,
                (4, 3) => squares[35] = o,
                (4, 4) => squares[36] = o,
                (4, 5) => squares[37] = o,
                (4, 6) => squares[38] = o,
                (4, 7) => squares[39] = o,

                (5, 0) => squares[40] = o,
                (5, 1) => squares[41] = o,
                (5, 2) => squares[42] = o,
                (5, 3) => squares[43] = o,
                (5, 4) => squares[44] = o,
                (5, 5) => squares[45] = o,
                (5, 6) => squares[46] = o,
                (5, 7) => squares[47] = o,

                (6, 0) => squares[48] = o,
                (6, 1) => squares[49] = o,
                (6, 2) => squares[50] = o,
                (6, 3) => squares[51] = o,
                (6, 4) => squares[52] = o,
                (6, 5) => squares[53] = o,
                (6, 6) => squares[54] = o,
                (6, 7) => squares[55] = o,

                (7, 0) => squares[56] = o,
                (7, 1) => squares[57] = o,
                (7, 2) => squares[58] = o,
                (7, 3) => squares[59] = o,
                (7, 4) => squares[60] = o,
                (7, 5) => squares[61] = o,
                (7, 6) => squares[62] = o,
                (7, 7) => squares[63] = o,

            };
        }





        public override void GetBoard()
        {

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[0]}  |  {squares[1]}  |  {squares[2]}  |  {squares[3]} |  {squares[4]} |  {squares[5]} |  {squares[6]} |  {squares[7]} |  0");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[8]}  |  {squares[9]}  |  {squares[10]}  |  {squares[11]} |  {squares[12]} |  {squares[13]} |  {squares[14]} |  {squares[15]} |  1");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[16]}  |  {squares[17]}  |  {squares[18]}  |  {squares[19]} |  {squares[20]} |  {squares[21]} |  {squares[22]} |  {squares[23]} |  2");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[24]}  |  {squares[25]}  |  {squares[26]}  |  {squares[27]} |  {squares[28]} |  {squares[29]} |  {squares[30]} |  {squares[31]} |  3");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[32]}  |  {squares[33]}  |  {squares[34]}  |  {squares[35]} |  {squares[36]} |  {squares[37]} |  {squares[38]} |  {squares[39]} |  4");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[40]}  |  {squares[41]}  |  {squares[42]}  |  {squares[43]} |  {squares[44]} |  {squares[45]} |  {squares[46]} |  {squares[47]} |  5");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[48]}  |  {squares[49]}  |  {squares[50]}  |  {squares[51]} |  {squares[52]} |  {squares[53]} |  {squares[54]} |  {squares[55]} |  6");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|  {squares[56]}  |  {squares[57]}  |  {squares[58]}  |  {squares[59]} |  {squares[60]} |  {squares[61]} |  {squares[62]} |  {squares[63]} |  7");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("   0     1     2     3    4    5    6    7");
        }


       



    }
}
