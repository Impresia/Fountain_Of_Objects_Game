
using Fountain_Of_Objects.Colors;





namespace Fountain_Of_Objects.GameObjects
{

    
    public class Maelstroms
    {
        


       public void MaelstromCheck(  int randomRow, int randomCol, int row, int col,ref bool dead, ref bool maelstromRoom)
        {
            if (row == randomRow && col == randomCol && dead == false)
            {
                maelstromRoom = true;
                Coloring.Colorize("you entered in the room where Maelstrom was and swept away 1 room north and 2 room east!", ConsoleColor.Red);
                               
            }      
        }








        public void MaelstromRoomWarning(int randomRow, int randomCol, int row, int col, ref bool dead, int maelstromNum, bool onlyOneMaelstrom)
        {

            if (((row == randomRow - 1 && col == randomCol) || (row == randomRow + 1 && col == randomCol) || (row == randomRow && col == randomCol + 1) ||
                (row == randomRow && col == randomCol - 1) || (row == randomRow - 1 && col == randomCol + 1) || (row == randomRow + 1 && col == randomCol + 1) ||
                (row == randomRow - 1 && col == randomCol - 1) || (row == randomRow + 1 && col == randomCol - 1)) && dead == false)
            {
                if (onlyOneMaelstrom == true)
                    Coloring.Colorize($"You hear the growling and groaning of a Maelstrom nearby.", ConsoleColor.DarkCyan);

                else
                    Coloring.Colorize($"You hear the growling and groaning of a Maelstrom N={maelstromNum} in a nearby room.", ConsoleColor.DarkCyan);
            }




        }







    }
}
