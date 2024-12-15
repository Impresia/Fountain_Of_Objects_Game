using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects.Colors
{
    public class Coloring
    {


        public static void Colorize (string input, ConsoleColor color )
        {
            Console.ForegroundColor = color;
            Console.WriteLine( input );
            Console.ResetColor();


        }
            









    }
}
