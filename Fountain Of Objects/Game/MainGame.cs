

using Fountain_Of_Objects.Colors;
using Fountain_Of_Objects.GameObjects;
using Fountain_Of_Objects.Setup;
using System.Drawing;

namespace Fountain_Of_Objects.Game
{
    public class MainGame
    {
        public int _row { get; protected set; } = 0;
        public int _col { get; protected set; } = 0;

        public int _totalLives { get; protected set; } = 3;

        protected virtual int maxRow { get; set; } = 3;
        protected virtual int maxCol { get; set; } = 3;
        protected virtual int minRow { get; set; } = 0;
        protected virtual int minCol { get; set; } = 0;


        private List<string> squares = new List<string>() { " ", " " , " " , " " , " " , " " , " " , " " , " " , " " , " " , " " , " " , " " , " " , " " } ;
      
       public static string P = "\u2666"; // ♦
        public static string whenDieIcon = "X"; //display where you died!
        public static string pitIcon = "\u03A8"; // Ψ
        public static string amarokIcon = "\u0223"; // ȣ
        public static string activeFountain = "\u01EA";
        public static string inActiveFountain = "\u019F";
        public static string maelstrom = "\u03DF"; // ϟ


        public int randomAmarokRow { get; protected set; }
        public int randomAmarokCol { get; protected set; }

        public int randomPitRow { get; protected set; }
        public int randomPitCol { get; protected set; }

        public int randomRow { get; protected set; }
        public int randomCol { get; protected set; }

        public int randomMaelstrmRow { get; protected set; }
        public int randomMaelstrmCol { get; protected set; }

        public int randomPitRow2 { get; protected set; }
        public int randomPitCol2 { get; protected set; }


        public int randomAmarokRow2 { get; protected set; }
        public int randomAmarokCol2 { get; protected set; }


        public int randomPitRow3 { get; protected set; }
        public int randomPitCol3 { get; protected set; }

        public int randomPitRow4 { get; protected set; }
        public int randomPitCol4 { get; protected set; }


        public int randomAmarokRow3 { get; protected set; }
        public int randomAmarokCol3 { get; protected set; }

        public int randomMaelstrmRow2 { get; protected set; }
        public int randomMaelstrmCol2 { get; protected set; }



        public bool dead=false;
        public bool enteredMaelstromRoom=false;


       public Amaroks amaroks = new Amaroks(); 
       public Pits pits = new Pits();        
       public Random random = new Random();
        public Maelstroms maelstrm = new Maelstroms();
        public FullGame fullGameMain = new FullGame();
        public GettingArmed armory=new GettingArmed();
        public GettingArmed bow = new GettingArmed();


        public bool amarokIsDead = false;
        public bool amarokIsDead2 = false;
        public bool amarokIsDead3 = false;

        public bool maelstromIsDead = false;
        public bool maelstromIsDead2 = false;

        public int totalArrows = 5;




          public bool maelstromsEnabled = true;
        public bool amaroksEnabled;
        public bool pitsEnabled ;
        public bool bowEnabled=true;

        public virtual bool itsMediumBoardGame { get; protected set; } = false;
        public virtual bool itsLargeBoardGame { get; protected set; } = false;




          public void Run()
          {
          
            Fountain fountain = Fountain.disabled;

            fullGameMain.ChooseChallenge(ref pitsEnabled, ref amaroksEnabled);
            fullGameMain.AskToAddMaelstromOrBow( ref maelstromsEnabled, ref bowEnabled);

            GetRandomNums();
            
            DangerousObjects(ref dead);




            Console.WriteLine($"you are in the room at (row={_row} column= {_col}).");
            squares[0] = P;
            GetBoard();
            Coloring.Colorize("You see light in this room coming from outside the cavern. This is the entrance.", ConsoleColor.Yellow);
            if(bowEnabled)
            Coloring.Colorize($"you have {totalArrows} arrows left!", ConsoleColor.Magenta);
            Console.WriteLine("which direction do you want to go?");

            ConsoleKeyInfo result = Console.ReadKey(true);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            




            
            move(ref result,minRow,maxRow,minCol,maxCol);
            DangerousObjects(ref dead);

            if (dead == true)
            {
                GetBoard();                
            }

            ActivationAndMove(ref result, ref fountain, randomRow, randomCol,ref dead);
             



            while (dead==false && _totalLives!=0)
            {

                WinCondition(ref fountain);
                if (fountain == Fountain.enabled && _row == 0 && _col == 0)
                    break;

                Console.WriteLine($"you are in room at (row={_row} column={_col}).");
                if (_row == 0 && _col == 0)
                {
                    Coloring.Colorize("You see light in this room coming from outside the cavern. This is the entrance.", ConsoleColor.Yellow);
                }

                DisplayIcon(_row, _col, P);
                GetBoard();
                if (bowEnabled)
                    Coloring.Colorize($"you have {totalArrows} arrows left!", ConsoleColor.Magenta);
                Console.WriteLine("which direction do you want to go?");
                result = Console.ReadKey(true);
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine();

               
                move(ref result, minRow, maxRow, minCol, maxCol);
                 if (_totalLives == 0)
                { break; }
                
                DangerousObjects(ref dead);

                if (dead == true) 
                {                    
                    GetBoard();
                    break; 
                }



                WinCondition(ref fountain);
                if (fountain == Fountain.enabled && _row == 0 && _col == 0)
                    break;

                                



                ActivationAndMove( ref result, ref fountain, randomRow,randomCol, ref dead);
                if (_totalLives == 0)
                { break; }
                
                if (dead == true)
                {   
                    break;
                }
                
                

            }

        }










        public (int,int)[] CheckEquality((int,int)[] array)
        {
            (int, int)[] newList = new (int, int)[array.Length];


            for(int i = 0; i < array.Length; i++)
            {
                while (array[i]== (0, 0))
                {
                    array[i] = (random.Next(maxRow + 1), random.Next(maxCol + 1));
                }
                newList[i] = array[i];
            }    
           

            for(int i =1; i < array.Length; i++ )
            {
                for (int j = 0; j < i; j++)
                {
                    while (array[i] == array[j] || array[i] == (0, 0) || array[i] == (0, 1) || array[i] == (1, 0))
                    {
                        array[i] = (random.Next(maxRow + 1), random.Next(maxCol + 1));
                    }
                }
                 newList[i] = array[i];  
                                            
            }
            return newList;

        }



        public virtual void GetRandomNums()
        {
          
            randomPitRow = random.Next(maxRow + 1);
            randomPitCol = random.Next(maxCol + 1);

             randomRow = random.Next(maxRow + 1);
            randomCol = random.Next(maxCol + 1);
            
            randomAmarokRow = random.Next(maxRow + 1);
            randomAmarokCol = random.Next(maxCol + 1);

            randomMaelstrmRow=random.Next(maxRow + 1);
            randomMaelstrmCol=random.Next(maxCol + 1);

            (int, int)[] coord = new (int, int)[] { (randomRow,randomCol), (randomPitRow,randomPitCol),(randomAmarokRow,randomAmarokCol),
                (randomMaelstrmRow, randomMaelstrmCol) };

           (int, int)[] newCoord = CheckEquality(coord);

            (randomRow, randomCol) = newCoord[0];
            (randomPitRow, randomPitCol) = newCoord[1];
            (randomAmarokRow, randomAmarokCol)= newCoord[2];
            (randomMaelstrmRow, randomMaelstrmCol)= newCoord[3];
                       

        }

        public bool AdvantageOverMaelstrom()
        {
            if (itsMediumBoardGame == false || itsLargeBoardGame == false)
            {
                (int, int)[] nums = new (int, int)[] { (randomRow,randomCol), (randomPitRow,randomPitCol),(randomAmarokRow,randomAmarokCol),
                (randomMaelstrmRow, randomMaelstrmCol) };
                if (nums[3] == nums[1] || nums[3] == nums[2])
                    return true;
            }

           else if(itsMediumBoardGame)
            {
                (int, int)[] nums2 = new (int, int)[] { (randomRow, randomCol), (randomPitRow, randomPitCol), (randomAmarokRow, randomAmarokCol),
                (randomPitRow2, randomPitCol2), (randomAmarokRow2,randomAmarokCol2), (randomMaelstrmRow,randomMaelstrmCol) };
                if (nums2[5] == nums2[1] || nums2[5] == nums2[2] || nums2[5] == nums2[3] || nums2[5] == nums2[4])
                    return true;
            }

            else if (itsLargeBoardGame)
            {  
                (int, int)[] nums3 = new (int, int)[] {(randomRow, randomCol), (randomPitRow, randomPitCol), (randomAmarokRow, randomAmarokCol),
                (randomPitRow2, randomPitCol2), (randomAmarokRow2,randomAmarokCol2), (randomPitRow3, randomPitCol3), (randomPitRow4, randomPitCol4),
            (randomAmarokRow3,randomAmarokCol3),(randomMaelstrmRow,randomMaelstrmCol), (randomMaelstrmRow2,randomMaelstrmCol2) };

                if (nums3[8] == nums3[1] || nums3[8] == nums3[2] || nums3[8] == nums3[3] || nums3[8] == nums3[4]|| nums3[8] == nums3[5]
                    || nums3[8] == nums3[6]|| nums3[8] == nums3[7])
                    return true;
                else if(nums3[9] == nums3[1] || nums3[9] == nums3[2] || nums3[9] == nums3[3] || nums3[9] == nums3[4] || nums3[9] == nums3[5]
                    || nums3[9] == nums3[6] || nums3[9] == nums3[7])
                    return true;
            }
            return false;
        }




        public void DangerousObjects(ref bool dead)
        {

            DangerousObjDeathCheck(ref dead);
            if(_totalLives!=0)
            DangerousObjWarning(ref dead);
            
            
            if (dead == true)
                DisplayObjects(pitIcon, pitIcon, pitIcon, pitIcon, amarokIcon, amarokIcon, amarokIcon);

        }







        public void DisplayObjects(string pit, string pit2, string pit3, string pit4, string amarok, string amarok2, string amarok3)
        {
            
            if ((_row, _col) == (randomPitRow, randomPitCol))
                pit = whenDieIcon;                            
            else if ((_row, _col) == (randomAmarokRow, randomAmarokCol))
                amarok = whenDieIcon;
           else if ((_row, _col) == (randomPitRow2, randomPitCol2) && (itsMediumBoardGame||itsLargeBoardGame))
                pit2 = whenDieIcon;
            else if ((_row, _col) == (randomPitRow3, randomPitCol3) &&  itsLargeBoardGame)
                pit3 = whenDieIcon;
            else if ((_row, _col) == (randomPitRow4, randomPitCol4) && itsLargeBoardGame)
                pit4 = whenDieIcon;

            else if ((_row, _col) == (randomAmarokRow2, randomAmarokCol2) && (itsMediumBoardGame || itsLargeBoardGame))
                amarok2 = whenDieIcon;
            else if ((_row, _col) == (randomAmarokRow3, randomAmarokCol3) && itsLargeBoardGame)
                amarok3 = whenDieIcon;


            if (pitsEnabled)
            {

                DisplayIcon(randomPitRow, randomPitCol, pit);

                if (itsMediumBoardGame || itsLargeBoardGame)
                    DisplayIcon(randomPitRow2, randomPitCol2, pit2);

                if (itsLargeBoardGame)
                {
                    DisplayIcon(randomPitRow3, randomPitCol3, pit3);
                    DisplayIcon(randomPitRow4, randomPitCol4, pit4);
                }
            }

            if (amarokIsDead==false && amaroksEnabled)
            DisplayIcon(randomAmarokRow, randomAmarokCol, amarok);
           
            if (amaroksEnabled && amarokIsDead2 == false && (itsMediumBoardGame||itsLargeBoardGame))
                DisplayIcon(randomAmarokRow2, randomAmarokCol2, amarok2);

            if (amaroksEnabled && amarokIsDead3 == false && itsLargeBoardGame)
                DisplayIcon(randomAmarokRow3, randomAmarokCol3, amarok3);


            if (AdvantageOverMaelstrom() == false)
            {
                if (maelstromsEnabled && (maelstromIsDead == false))
                    DisplayIcon(randomMaelstrmRow, randomMaelstrmCol, maelstrom);


                if (maelstromsEnabled && (maelstromIsDead2 == false) && itsLargeBoardGame)
                    DisplayIcon(randomMaelstrmRow2, randomMaelstrmCol2, maelstrom);
            }
        }
                
        
        







        public void DangerousObjDeathCheck (ref bool dead)
        {
            if (AdvantageOverMaelstrom() == false)
            {
                if (maelstromsEnabled && (maelstromIsDead == false))
                    MaelstromAction(randomMaelstrmRow, randomMaelstrmCol, _row, _col, ref dead, ref enteredMaelstromRoom);

                if (maelstromsEnabled && maelstromIsDead2 == false && itsLargeBoardGame)
                    MaelstromAction(randomMaelstrmRow2, randomMaelstrmCol2, _row, _col, ref dead, ref enteredMaelstromRoom);
            }

            if (pitsEnabled)
            {
                pits.DeathCheckPit(randomPitRow, randomPitCol, _row, _col, ref dead);

                if (itsMediumBoardGame || itsLargeBoardGame)
                    pits.DeathCheckPit(randomPitRow2, randomPitCol2, _row, _col, ref dead);
               
                if (itsLargeBoardGame)
                {
                    pits.DeathCheckPit(randomPitRow3, randomPitCol3, _row, _col, ref dead);
                    pits.DeathCheckPit(randomPitRow4, randomPitCol4, _row, _col, ref dead);
                }
            }


            if (amarokIsDead==false && amaroksEnabled)
           amaroks.DeathCheckAmarok(randomAmarokRow, randomAmarokCol, _row, _col, ref dead);

            if (amarokIsDead2 == false && amaroksEnabled && (itsMediumBoardGame || itsLargeBoardGame))
                amaroks.DeathCheckAmarok(randomAmarokRow2, randomAmarokCol2, _row, _col, ref dead);

            if (amaroksEnabled && amarokIsDead3 == false && itsLargeBoardGame)
                amaroks.DeathCheckAmarok(randomAmarokRow3, randomAmarokCol3, _row, _col, ref dead);
        }








        public void DangerousObjWarning(ref bool dead)
        {
            
            if (maelstromsEnabled && (maelstromIsDead==false))
                maelstrm.MaelstromRoomWarning(randomMaelstrmRow, randomMaelstrmCol, _row, _col, ref dead, 1, true);
            
            if (maelstromsEnabled && maelstromIsDead2 == false && itsLargeBoardGame)
                maelstrm.MaelstromRoomWarning(randomMaelstrmRow2, randomMaelstrmCol2, _row, _col, ref dead, 1, true);

            if (pitsEnabled)
            {
                pits.PitRoomWarning(randomPitRow, randomPitCol, _row, _col, ref dead, 1, false);

                if(itsMediumBoardGame || itsLargeBoardGame)
                pits.PitRoomWarning(randomPitRow2, randomPitCol2, _row, _col, ref dead, 2, false);

                if(itsLargeBoardGame)
                {
                    pits.PitRoomWarning(randomPitRow3, randomPitCol3, _row, _col, ref dead, 3, false);
                    pits.PitRoomWarning(randomPitRow4, randomPitCol4, _row, _col, ref dead, 4, false);
                }
            }

            if (amarokIsDead == false && amaroksEnabled)
                amaroks.AmarokRoomWarning(randomAmarokRow, randomAmarokCol, _row, _col, ref dead, 1, true);

            if (amarokIsDead2 == false && amaroksEnabled && (itsMediumBoardGame || itsLargeBoardGame))
                amaroks.AmarokRoomWarning(randomAmarokRow2, randomAmarokCol2, _row, _col, ref dead, 2, false);

            if (amaroksEnabled && amarokIsDead3 == false && itsLargeBoardGame)
                amaroks.AmarokRoomWarning(randomAmarokRow3, randomAmarokCol3, _row, _col, ref dead, 3, false);

        }





        public void MaelstromAction(int randomRow, int randomCol, int row, int col, ref bool dead, ref bool maelstromRoom)
        {
            maelstrm.MaelstromCheck(randomRow, randomCol, row, col, ref dead, ref maelstromRoom);
            if(maelstromRoom)
            {
                _row--;
                _col += 2;
                if (_row < minRow)
                   _row = minRow;

                if (_col > maxCol)
                    _col = maxCol;


                randomMaelstrmRow++;
                randomMaelstrmCol -= 2;

                if (randomMaelstrmRow > maxRow)
                    randomMaelstrmRow = maxRow;

                if (randomMaelstrmCol < minCol)
                    randomMaelstrmCol = minCol;
               
                maelstromRoom = false;
            }
        }






          public virtual void DifferentDisplayMethods()
          {
            DisplayObjects(pitIcon, pitIcon, pitIcon, pitIcon, amarokIcon, amarokIcon, amarokIcon);
          }

          


        public void WinCondition(ref Fountain fount)
        {
            if (fount == Fountain.enabled && _row == 0 && _col == 0)
            {
                Console.WriteLine($"you are in room at (row={_row} column={_col}).");
                DisplayIcon(_row, _col, P);
                GetBoard();

                Coloring.Colorize("The Fountain of Objects has been reactivated, and you have escaped with your life!", ConsoleColor.Green);
                Coloring.Colorize("You are winner!", ConsoleColor.Green);
            }
        }

          
        
        




        public void ActivationAndMove( ref ConsoleKeyInfo result, ref Fountain fountain, int randomRow, int randomCol , ref bool dead) 
        {
            while (_row == randomRow && _col == randomCol)
            {
                while (fountain == Fountain.disabled && _row == randomRow && _col == randomCol)

                {
                    if (result.Key != ConsoleKey.Spacebar)
                    {
                        Coloring.Colorize("You hear water dripping in this room. The Fountain of Objects is here!", ConsoleColor.Cyan);
                        DisplayIcon(_row, _col, inActiveFountain);
                        GetBoard();
                        Coloring.Colorize("If you want to activate fountain press on the spacebar!", ConsoleColor.DarkYellow);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        result = Console.ReadKey(true);
                    }

                    while (result.Key == ConsoleKey.Spacebar)
                    {
                        fountain = Fountain.enabled;
                        Console.WriteLine($"you are in room at (row={_row} column={_col}).");

                        Coloring.Colorize("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.Blue);
                        if (bowEnabled)
                            Coloring.Colorize($"you have {totalArrows} arrows left!", ConsoleColor.Magenta);
                        Console.WriteLine("what do you want to do?");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        result = Console.ReadKey(true);

                        if (result.Key == ConsoleKey.Spacebar)
                        {
                            fountain = Fountain.disabled;
                            Console.WriteLine($"you are in room at (row={_row} column={_col}).");
                            Coloring.Colorize("The Fountain Of Objects has been deactivated!", ConsoleColor.DarkYellow);
                            if (bowEnabled)
                                Coloring.Colorize($"you have {totalArrows} arrows left!", ConsoleColor.Magenta);
                            Console.WriteLine("what do you want to do?");
                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                            Console.WriteLine();
                            result = Console.ReadKey(true);
                        }
                    }

                    move(ref result, minRow, maxRow, minCol, maxCol);
                    if (_totalLives == 0)
                    { break; }

                    DangerousObjects(ref dead);
                    if (dead == true)
                    {
                        GetBoard();
                        break;
                    }

                }
                if (_totalLives == 0 || dead==true)
                { break; }
                




                while (fountain == Fountain.enabled && _row == randomRow && _col == randomCol && _totalLives != 0)
                {
                    if (result.Key != ConsoleKey.Spacebar)
                    {
                        Coloring.Colorize("You hear water dripping in this room. The Fountain of Objects is here!", ConsoleColor.Cyan);
                        DisplayIcon(_row, _col, activeFountain);
                        GetBoard();
                        Coloring.Colorize("It has been reactivated! if you want to deactivate it press on spacebar", ConsoleColor.Blue);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        result = Console.ReadKey(true);
                    }

                    while (result.Key == ConsoleKey.Spacebar)
                    {
                        fountain = Fountain.disabled;
                        Console.WriteLine($"you are in room at (row={_row} column={_col}).");

                        Coloring.Colorize("The Fountain Of Objects has been deactivated!", ConsoleColor.DarkYellow);
                        if (bowEnabled)
                            Coloring.Colorize($"you have {totalArrows} arrows left!", ConsoleColor.Magenta);
                        Console.WriteLine("what do you want to do?");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        result = Console.ReadKey(true);

                        if (result.Key == ConsoleKey.Spacebar)
                        {
                            fountain = Fountain.enabled;
                            Console.WriteLine($"you are in room at (row={_row} column={_col}).");
                            Coloring.Colorize("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.Blue);
                            if (bowEnabled)
                                Coloring.Colorize($"you have {totalArrows} arrows left!", ConsoleColor.Magenta);
                            Console.WriteLine("what do you want to do?");
                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                            Console.WriteLine();
                            result = Console.ReadKey(true);
                        }

                    }

                    move(ref result, minRow, maxRow, minCol, maxCol);
                    if (_totalLives == 0)
                        break;


                    DangerousObjects(ref dead);
                    if (dead == true)
                    {
                        GetBoard();
                        break;
                    }

                }
                if (_totalLives == 0 || dead == true)
                { break; }
            }
        }






        public void DeathCheck(ref ConsoleKeyInfo input, int minRow, int maxRow, int minCol, int maxCol )
        {
            if (((_row == minRow && input.Key == ConsoleKey.UpArrow) || (_row == maxRow && input.Key == ConsoleKey.DownArrow)) && _totalLives!=0)
            {
                _totalLives -= 1;
                Coloring.Colorize($"You died because you crossed the maze border! Lives left--> {_totalLives}", ConsoleColor.Red);
                if (_totalLives!=0)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    input =Console.ReadKey(true);
                }
                
                
            }

            else if (((_col == maxCol && input.Key == ConsoleKey.RightArrow) || (_col == minCol && input.Key == ConsoleKey.LeftArrow)) && _totalLives != 0)
            {
                _totalLives -= 1;
                Coloring.Colorize($"You died because you crossed the maze border! Lives left--> {_totalLives}", ConsoleColor.Red);
                if (_totalLives != 0)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    input = Console.ReadKey(true);
                }
            }
                      


        }

        public virtual void DifferentShootMethods(ref ConsoleKeyInfo input)
        {
             bow.shoot(ref input, ref totalArrows, _row, _col, randomAmarokRow, randomAmarokCol,
                 randomAmarokRow2, randomAmarokCol2, randomAmarokRow3, randomAmarokCol3, 
                 randomMaelstrmRow,randomMaelstrmCol, randomMaelstrmRow2, randomMaelstrmCol2,
                 ref amarokIsDead, ref amarokIsDead2, ref amarokIsDead3, ref maelstromIsDead, ref maelstromIsDead2,
                 maelstromsEnabled, amaroksEnabled, itsMediumBoardGame, itsLargeBoardGame);
        }

        







        public void move( ref ConsoleKeyInfo input , int minRow, int maxRow, int minCol, int maxCol)
        {
                       
            while (true)
            {
                if(bowEnabled)                  
                DifferentShootMethods(ref input);

                DeathCheck(ref input, minRow, maxRow, minCol, maxCol);
                if (_totalLives == 0)
                {
                    Console.WriteLine();
                    Coloring.Colorize("you have 0 lives left! you lost!", ConsoleColor.DarkRed);
                    DifferentDisplayMethods();
                    GetBoard();
                    break;
                }

                if(input.Key==ConsoleKey.Spacebar && _row==randomRow && _col == randomCol)                
                    break;
                


                if ((input.Key == ConsoleKey.W || input.Key == ConsoleKey.A || input.Key == ConsoleKey.S || input.Key == ConsoleKey.D) && bowEnabled)
                    continue;

                    if (_row > minRow && input.Key == ConsoleKey.UpArrow)
                {
                    _row--;
                    break;
                }
                else if (_row < maxRow && input.Key == ConsoleKey.DownArrow)
                {
                    _row++;
                    break;
                }
                else if (_col > minCol && input.Key == ConsoleKey.LeftArrow)
                {
                    _col--;
                    break;
                }
                else if (_col < maxCol && input.Key == ConsoleKey.RightArrow)
                {
                    _col++;
                    break;
                }
                else if (input.Key != ConsoleKey.UpArrow && input.Key != ConsoleKey.DownArrow && input.Key != ConsoleKey.LeftArrow && input.Key != ConsoleKey.RightArrow )
                {
                    Coloring.Colorize("invalid move command, try again!", ConsoleColor.DarkGray);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    input = Console.ReadKey(true);
                }
               
            }
        }



        


        


        public virtual string DisplayIcon(int row, int col ,string o)
        {
            for (int i = 0; i < squares.Count; i++)
            {
                if (squares[i] == P || squares[i]==activeFountain || squares[i]==inActiveFountain)
                {
                    squares[i] = " ";
                   
                }
                else
                    continue;

            }

            return (row, col) switch
            {
                
                (0, 0) => squares[0]=o,
                (0, 1) => squares[1]=o,
                (0, 2) => squares[2] = o,
                (0, 3) => squares[3]=o,
                (1, 0) => squares[4] = o,
                (1, 1) => squares[5]=o,
                (1, 2) => squares[6]=o,
                (1, 3) => squares[7]=o,
                (2, 0) => squares[8] = o,
                (2, 1) => squares[9]=o,
                (2, 2) => squares[10] = o,
                (2, 3) => squares[11]=o,
                (3, 0) => squares[12]=o,
                (3, 1) => squares[13]=o,
                (3, 2) => squares[14]=o,
                (3, 3) => squares[15]=o
            } ;


        }

       



        public virtual void GetBoard()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"|  {squares[0]}  |  {squares[1]}  |  {squares[2]}  |  {squares[3]} |  0");
            Console.WriteLine("------------------------");
            Console.WriteLine($"|  {squares[4]}  |  {squares[5]}  |  {squares[6]}  |  {squares[7]} |  1");
            Console.WriteLine("------------------------");
            Console.WriteLine($"|  {squares[8]}  |  {squares[9]}  |  {squares[10]}  |  {squares[11]} |  2");
            Console.WriteLine("------------------------");
            Console.WriteLine($"|  {squares[12]}  |  {squares[13]}  |  {squares[14]}  |  {squares[15]} |  3");
            Console.WriteLine("------------------------");
            Console.WriteLine("   0     1     2     3");

        }





    }
}

