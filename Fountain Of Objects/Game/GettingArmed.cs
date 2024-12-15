using Fountain_Of_Objects.Colors;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_Of_Objects.Game
{
    public class GettingArmed 
    {




        // terrible example! insane amount of parameters. good thing is, not using this method multiple times or places. it will be called only once.
        public void shoot(ref ConsoleKeyInfo direction, ref int arrows, int row, int col,
            int randomAmarokRow, int randomAmarokCol, int randomAmarokRow2, int randomAmarokCol2, int randomAmarokRow3, int randomAmarokCol3,
            int randomMaelstRow,int randomMaelstCol, int randomMaelstRow2,int randomMaelstCol2,
            ref bool deathAmarok1, ref bool deathAmarok2, ref bool deathAmarok3, ref bool deathMaelst1, ref bool deathMaelst2,
            bool Maelstromsenabled, bool amaroksenabled, bool itsmediumboard, bool itslargeboard)
        {
            
            if (direction.Key == ConsoleKey.W || direction.Key == ConsoleKey.A || direction.Key == ConsoleKey.S || direction.Key == ConsoleKey.D)
            {
                while (true)
                {

                    if (direction.Key == ConsoleKey.W)
                    {
                        if (arrows == 0)
                        {
                            OutOfArrows(ref direction);
                        }

                        else if (arrows > 0)
                        {
                            if (row - 1 == randomAmarokRow && col == randomAmarokCol && amaroksenabled)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok1);
                            }

                            else if (row - 1 == randomAmarokRow2 && col == randomAmarokCol2 && amaroksenabled && (itsmediumboard || itslargeboard))
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok2);
                            }
                            else if (row - 1 == randomAmarokRow3 && col == randomAmarokCol3 && amaroksenabled && itslargeboard)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok3);
                            }

                            else if (row - 1 == randomMaelstRow && col == randomMaelstCol && Maelstromsenabled)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst1);
                            }
                            else if (row - 1 == randomMaelstRow2 && col == randomMaelstCol2 && Maelstromsenabled && itslargeboard)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst2);
                            }
                            else
                            {
                                MissedArrow(ref direction, ref arrows);
                            }
                        }
                    }
                    


                  else if (direction.Key == ConsoleKey.A)
                    {
                        if (arrows == 0)
                        {
                            OutOfArrows(ref direction);
                        }

                        else if (arrows > 0)
                        {
                            if (row == randomAmarokRow && col - 1 == randomAmarokCol && amaroksenabled)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok1);
                            }

                            else if (row == randomAmarokRow2 && col - 1 == randomAmarokCol2 && amaroksenabled && (itsmediumboard || itslargeboard))
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok2);
                            }
                            else if (row == randomAmarokRow3 && col - 1 == randomAmarokCol3 && amaroksenabled && itslargeboard)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok3);
                            }

                            else if (row == randomMaelstRow && col - 1 == randomMaelstCol && Maelstromsenabled)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst1);
                            }
                            else if (row == randomMaelstRow2 && col - 1 == randomMaelstCol2 && Maelstromsenabled && itslargeboard)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst2);
                            }
                            else
                            {
                                MissedArrow(ref direction, ref arrows);
                            }
                        }

                    }


                  else  if (direction.Key == ConsoleKey.S)
                    {
                        if (arrows == 0)
                        {
                            OutOfArrows(ref direction);
                        }

                        else if (arrows > 0)
                        {

                            if (row + 1 == randomAmarokRow && col == randomAmarokCol && amaroksenabled)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok1);
                            }

                            else if (row + 1 == randomAmarokRow2 && col == randomAmarokCol2 && amaroksenabled && (itsmediumboard || itslargeboard))
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok2);
                            }
                            else if (row + 1 == randomAmarokRow3 && col == randomAmarokCol3 && amaroksenabled && itslargeboard)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok3);
                            }

                            else if (row + 1 == randomMaelstRow && col == randomMaelstCol && Maelstromsenabled)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst1);
                            }
                            else if (row + 1 == randomMaelstRow2 && col == randomMaelstCol2 && Maelstromsenabled && itslargeboard)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst2);
                            }
                            else
                            {
                                MissedArrow(ref direction, ref arrows);
                            }
                        }

                    }


                    else if (direction.Key == ConsoleKey.D)
                    {
                        if (arrows == 0)
                        {
                            OutOfArrows(ref direction);
                        }

                        else if (arrows > 0)
                        {

                            if (row == randomAmarokRow && col + 1 == randomAmarokCol && amaroksenabled)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok1);
                            }

                            else if (row == randomAmarokRow2 && col + 1 == randomAmarokCol2 && amaroksenabled && (itsmediumboard || itslargeboard))
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok2);
                            }
                            else if (row == randomAmarokRow3 && col + 1 == randomAmarokCol3 && amaroksenabled && itslargeboard)
                            {
                                KillAmarok(ref direction, ref arrows, ref deathAmarok3);
                            }

                            else if (row == randomMaelstRow && col + 1 == randomMaelstCol && Maelstromsenabled)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst1);
                            }
                            else if (row == randomMaelstRow2 && col + 1 == randomMaelstCol2 && Maelstromsenabled && itslargeboard)
                            {
                                KillMaelstrom(ref direction, ref arrows, ref deathMaelst2);
                            }
                            else
                            {
                                MissedArrow(ref direction, ref arrows);
                            }
                        }


                    }


                    else if (direction.Key == ConsoleKey.LeftArrow || direction.Key == ConsoleKey.RightArrow
                     || direction.Key == ConsoleKey.DownArrow || direction.Key == ConsoleKey.UpArrow || direction.Key==ConsoleKey.Spacebar)
                    {
                        break;
                    }

                    else
                    {
                        Coloring.Colorize("invalid action, try again!", ConsoleColor.DarkGray);
                        direction = Console.ReadKey(true);
                        Console.WriteLine();
                    }


                }


            }

        }



       





        public void KillAmarok(ref ConsoleKeyInfo answer, ref int arrows, ref bool checkDeath)
        {
            

             if(checkDeath == true)
            {
                MissedArrow(ref answer, ref arrows);
            }


            if (checkDeath == false && arrows>0)
            {
                checkDeath = true;
                arrows--;
                Coloring.Colorize("you killed Amarok!", ConsoleColor.DarkGreen);
                Coloring.Colorize($"you have {arrows} arrows left!", ConsoleColor.Magenta);
                Console.WriteLine("what do you want to do?");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                answer = Console.ReadKey(true);
            }

           
             
        }
        public void KillMaelstrom(ref ConsoleKeyInfo answer, ref int arrows, ref bool checkDeath)
        {
            if (checkDeath == true)
            {
                MissedArrow(ref answer, ref arrows);
            }


            if (checkDeath == false)
            {
                checkDeath = true;
                arrows--;
                Coloring.Colorize("you killed Maelstrom!", ConsoleColor.DarkGreen);
                Coloring.Colorize($"you have {arrows} arrows left!", ConsoleColor.Magenta);
                Console.WriteLine("what do you want to do?");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                answer = Console.ReadKey(true);
            }
           
        }

        public void MissedArrow(ref ConsoleKeyInfo answer, ref int arrows)
        {
            arrows--;
            Coloring.Colorize($"you missed the arrow! you have {arrows} arrows left!", ConsoleColor.Magenta);
            Console.WriteLine("what do you want to do?");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            answer = Console.ReadKey(true);
        }


        public void OutOfArrows(ref ConsoleKeyInfo answer)
        {
            Coloring.Colorize("you can't shoot. You have 0 arrows!", ConsoleColor.Magenta);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            answer = Console.ReadKey(true);
        }



    }
}
