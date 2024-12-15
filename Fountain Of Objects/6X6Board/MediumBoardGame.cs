

using Fountain_Of_Objects.Game;
using Fountain_Of_Objects.GameObjects;
using System.IO.Pipes;

namespace Fountain_Of_Objects._6X6Board
{
    public class MediumBoardGame : MainGame
    {
        

        private List<string> squares = new List<string>() { P, " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", 
            " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

        


        protected override int maxRow { get; set; } = 5;
        protected override int maxCol { get; set; } = 5;
        protected override int minRow { get; set; } = 0;
        protected override int minCol { get; set; } = 0;



        

        public override bool itsMediumBoardGame { get;protected set; } =true;
       



        public override void GetRandomNums()
        {
            
              base.GetRandomNums();

           
            randomPitRow2 = random.Next(maxRow + 1);
            randomPitCol2 = random.Next(maxCol + 1);
            
            randomAmarokRow2=random.Next(maxRow + 1);
            randomAmarokCol2 = random.Next(maxRow + 1);



            (int, int)[] coord = new(int, int)[] { (randomRow, randomCol), (randomPitRow, randomPitCol), (randomAmarokRow, randomAmarokCol),
                (randomPitRow2, randomPitCol2), (randomAmarokRow2,randomAmarokCol2), (randomMaelstrmRow,randomMaelstrmCol) };

            (int, int)[] coordinates= CheckEquality(coord);

            (randomRow, randomCol) = coordinates[0];
            (randomPitRow, randomPitCol) = coordinates[1];
            (randomAmarokRow, randomAmarokCol) = coordinates[2];
            (randomPitRow2, randomPitCol2) = coordinates[3];
            (randomAmarokRow2, randomAmarokCol2) = coordinates[4];
            (randomMaelstrmRow, randomMaelstrmCol) = coordinates[5];


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

                (1, 0) => squares[6] = o,
                (1, 1) => squares[7] = o,
                (1, 2) => squares[8] = o,
                (1, 3) => squares[9] = o,
                (1, 4) => squares[10] = o,
                (1, 5) => squares[11] = o,

                (2, 0) => squares[12] = o,
                (2, 1) => squares[13] = o,
                (2, 2) => squares[14] = o,
                (2, 3) => squares[15] = o,
                (2, 4) => squares[16] = o,
                (2, 5) => squares[17] = o,

                (3, 0) => squares[18] = o,
                (3, 1) => squares[19] = o,
                (3, 2) => squares[20] = o,
                (3, 3) => squares[21] = o,
                (3, 4) => squares[22] = o,
                (3, 5) => squares[23] = o,

                (4, 0) => squares[24] = o,
                (4, 1) => squares[25] = o,
                (4, 2) => squares[26] = o,
                (4, 3) => squares[27] = o,
                (4, 4) => squares[28] = o,
                (4, 5) => squares[29] = o,

                (5, 0) => squares[30] = o,
                (5, 1) => squares[31] = o,
                (5, 2) => squares[32] = o,
                (5, 3) => squares[33] = o,
                (5, 4) => squares[34] = o,
                (5, 5) => squares[35] = o,

            };
        }








        public override void GetBoard()
        {

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"|  {squares[0]}  |  {squares[1]}  |  {squares[2]}  |  {squares[3]} |  {squares[4]} |  {squares[5]} |  0");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"|  {squares[6]}  |  {squares[7]}  |  {squares[8]}  |  {squares[9]} |  {squares[10]} |  {squares[11]} |  1");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"|  {squares[12]}  |  {squares[13]}  |  {squares[14]}  |  {squares[15]} |  {squares[16]} |  {squares[17]} |  2");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"|  {squares[18]}  |  {squares[19]}  |  {squares[20]}  |  {squares[21]} |  {squares[22]} |  {squares[23]} |  3");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"|  {squares[24]}  |  {squares[25]}  |  {squares[26]}  |  {squares[27]} |  {squares[28]} |  {squares[29]} |  4");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"|  {squares[30]}  |  {squares[31]}  |  {squares[32]}  |  {squares[33]} |  {squares[34]} |  {squares[35]} |  5");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("   0     1     2     3    4    5");
        }






    }
}
