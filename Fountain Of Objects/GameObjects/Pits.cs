
using Fountain_Of_Objects.Colors;


namespace Fountain_Of_Objects.GameObjects
{
    public class Pits
    {
       
        
        public void DeathCheckPit(int randomRow, int randomCol, int row, int col, ref bool dead)
        {
            if (row == randomRow && col == randomCol && dead == false)
            {
                dead = true;
                Coloring.Colorize("you died in the pit room, you lost!", ConsoleColor.DarkRed);
            }

        }





        public void PitRoomWarning (int randomRow, int randomCol, int row, int col, ref bool dead, int pitNum, bool onlyOnePit )
        {

            

            if(((row ==randomRow-1 && col ==randomCol) || (row == randomRow + 1 && col == randomCol) || (row == randomRow  && col == randomCol+1) ||
                (row == randomRow && col == randomCol-1) || (row == randomRow - 1 && col == randomCol+1) || (row == randomRow + 1 && col == randomCol+1)||
                (row == randomRow - 1 && col == randomCol-1) || (row == randomRow + 1 && col == randomCol-1)) && dead==false )

            {
                if(onlyOnePit==true)
                    Coloring.Colorize("You feel a draft. There is a pit in a nearby room.", ConsoleColor.DarkCyan);

                else
                    Coloring.Colorize($"You feel a draft. There is a pit N={pitNum} in a nearby room.", ConsoleColor.DarkCyan);
            }

                 

           
          


        }






    }
}
