

using Fountain_Of_Objects.Game;
using Fountain_Of_Objects._6X6Board;
using Fountain_Of_Objects._8X8Board;
using Fountain_Of_Objects.Colors;

namespace Fountain_Of_Objects.Setup
{
    public class FullGame
    {
        
       


        



        public void FullGameRun()
        {

          

        Console.WriteLine("Please choose size of the board : ");
            Console.WriteLine("1) 4 x 4");
            Console.WriteLine("2) 6 x 6");
            Console.WriteLine("3) 8 x 8");
            Console.WriteLine();
            ConsoleKeyInfo choice = Console.ReadKey(true);

           



            while (true)
            {
                if ((choice.Key == ConsoleKey.NumPad1 || choice.Key == ConsoleKey.D1) ||
                    (choice.Key == ConsoleKey.NumPad2 || choice.Key == ConsoleKey.D2) ||
                    (choice.Key == ConsoleKey.NumPad3 || choice.Key == ConsoleKey.D3))
                {
                    if (choice.Key == ConsoleKey.NumPad1 || choice.Key == ConsoleKey.D1)
                    {                                          
                        Coloring.Colorize("You chose 4 x 4 board game! Choose challenge for it!", ConsoleColor.DarkCyan);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Board(1);
                        break;
                    }

                    else if (choice.Key == ConsoleKey.NumPad2 || choice.Key == ConsoleKey.D2)
                    {
                        Coloring.Colorize("You chose 6 x 6 board game! Choose challenge for it!", ConsoleColor.DarkCyan);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Board(2);
                        break;
                    }

                    else if (choice.Key == ConsoleKey.NumPad3 || choice.Key == ConsoleKey.D3)
                    {
                        Coloring.Colorize("You chose 8 x 8 board game! Choose challenge for it!", ConsoleColor.DarkCyan);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Board(3);
                        break;
                    }

                    Console.WriteLine();
                                       
                }

                else
                {
                    Coloring.Colorize("invalid choice try again!", ConsoleColor.DarkGray);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    choice = Console.ReadKey(true);
                }

            }

        }




        public void Board( int boardSize)
        {
          
            MainGame mainGame = new MainGame();
            MediumBoardGame mediumGame = new MediumBoardGame();
            LargeBoardGame largeGame = new LargeBoardGame();

          
                if (boardSize == 1)
                    mainGame.Run();

                else if(boardSize == 2)
                mediumGame.Run();

                else if( boardSize == 3)
                largeGame.Run();
            
            
        }




        public void ChooseChallenge(ref bool pits, ref bool amaroks)
        {
            Console.WriteLine();
            Console.WriteLine("1) Full Game challenge");
            Console.WriteLine("2) Only Pits challenge");
            Console.WriteLine("3) Only Amaroks Challenge");
            ConsoleKeyInfo choice = Console.ReadKey(true);
            Console.WriteLine();
            while (true)
            {
                if ((choice.Key == ConsoleKey.NumPad1 || choice.Key == ConsoleKey.D1) ||
               (choice.Key == ConsoleKey.NumPad2 || choice.Key == ConsoleKey.D2) ||
               (choice.Key == ConsoleKey.NumPad3 || choice.Key == ConsoleKey.D3))
                {
                    Console.WriteLine();
                    if (choice.Key == ConsoleKey.NumPad1 || choice.Key == ConsoleKey.D1)
                    {
                        Coloring.Colorize("you chose Full Game challenge.", ConsoleColor.DarkCyan);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        pits = true;
                        amaroks= true;
                        break;
                    }
                    else if (choice.Key == ConsoleKey.NumPad2 || choice.Key == ConsoleKey.D2)
                    {
                        Coloring.Colorize("you chose Only Pits challenge.", ConsoleColor.DarkCyan);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        pits = true;
                        amaroks = false;
                        break;
                    }
                    else if (choice.Key == ConsoleKey.NumPad3 || choice.Key == ConsoleKey.D3)
                    {
                        Coloring.Colorize("you chose Only Amaroks challenge.", ConsoleColor.DarkCyan);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        pits = false;
                        amaroks = true;
                        break;
                    }                  


                }

                else
                {
                    Coloring.Colorize("invalid choice try again!", ConsoleColor.DarkGray);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    choice = Console.ReadKey(true);
                }

            }

        }



        public void AskToAddMaelstromOrBow(ref bool maelstrom, ref bool bow)
        {


            Console.WriteLine();
            Console.WriteLine("Do you want Maelstroms to be enabled?");
            Console.WriteLine("1) yes");
            Console.WriteLine("2) no");
            ConsoleKeyInfo input = Console.ReadKey(true);
            Console.WriteLine();

            while (true)
            {
                if (input.Key == ConsoleKey.NumPad1 || input.Key == ConsoleKey.D1)
                {
                    maelstrom = true;
                    Console.WriteLine() ;
                    Coloring.Colorize("Maelstroms enabled for current challenge!", ConsoleColor.DarkCyan);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    break;
                }
                else if (input.Key == ConsoleKey.NumPad2 || input.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Coloring.Colorize("Maelstroms disabled for current challenge!", ConsoleColor.DarkCyan);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    maelstrom = false;
                    break;
                }

                else
                {
                    Coloring.Colorize("invalid choice try again!", ConsoleColor.DarkGray);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    input = Console.ReadKey(true);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Do you want to carry a BOW as a weapon?");
            Console.WriteLine("1) yes");
            Console.WriteLine("2) no");
            input = Console.ReadKey(true);
            Console.WriteLine();

            while (true)
            {
                if (input.Key == ConsoleKey.NumPad1 || input.Key == ConsoleKey.D1)
                {
                    bow = true;
                    Console.WriteLine();
                    Coloring.Colorize("You are carrying a BOW as a weapon for current challenge!", ConsoleColor.DarkCyan);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    break;
                }
                else if (input.Key == ConsoleKey.NumPad2 || input.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Coloring.Colorize("Weapon is disabled for current challenge!", ConsoleColor.DarkCyan);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    bow = false;
                    break;
                }

                else
                {
                    Coloring.Colorize("invalid choice try again!", ConsoleColor.DarkGray);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    input = Console.ReadKey(true);
                }
            }

            Console.WriteLine();
            Coloring.Colorize("Loading the game!", ConsoleColor.DarkYellow);
            Console.WriteLine();
            Thread.Sleep(2000);
        }






















    }
}
