using Fountain_Of_Objects.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects.GameObjects
{
    public class Amaroks
    {
        
        public void DeathCheckAmarok(int randomRow, int randomCol, int row, int col, ref bool dead)
        {
            if (row == randomRow && col == randomCol && dead==false)
            {
                dead = true;
                Coloring.Colorize("you died beacause there is an amarok in the room, you lost!", ConsoleColor.DarkRed);
            }
        }






        public void AmarokRoomWarning(int randomRow, int randomCol, int row, int col, ref bool dead, int amarokNum, bool onlyOneAmarok)
        {


            if (((row == randomRow - 1 && col == randomCol) || (row == randomRow + 1 && col == randomCol) || (row == randomRow && col == randomCol + 1) ||
                (row == randomRow && col == randomCol - 1) || (row == randomRow - 1 && col == randomCol + 1) || (row == randomRow + 1 && col == randomCol + 1) ||
                (row == randomRow - 1 && col == randomCol - 1) || (row == randomRow + 1 && col == randomCol - 1)) && dead==false )

            {
                if (onlyOneAmarok == true)
                    Coloring.Colorize($"You can smell the rotten stench of an amarok in a nearby room.", ConsoleColor.DarkCyan);

                else
                    Coloring.Colorize($"You can smell the rotten stench of an amarok N={amarokNum} in a nearby room.", ConsoleColor.DarkCyan);
            }


        }
    }
}
