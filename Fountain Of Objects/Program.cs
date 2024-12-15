

using Fountain_Of_Objects.Colors;
using Fountain_Of_Objects.Setup;

Console.SetWindowSize(130, 55);

Console.Title=("Fountain Of Objects");

Console.OutputEncoding = System.Text.Encoding.Unicode;




FullGame game = new FullGame();



Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Game rules!");
Console.WriteLine();
Console.WriteLine("You enter the Cavern of Objects, a maze of rooms filled with dangerous objects in search\nof the Fountain of Objects.\n" +
    "Light is visible only in the entrance, and no other light is seen anywhere in the caverns.\r\nYou must navigate the Caverns with your other senses.\n" +
    "Find the Fountain of Objects, activate it, and return to the entrance.\n"+
    "***\n"+
    "There are 3 size of boards you can choose. 4 x 4, 6 x 6, 8 x 8.\n"+
    "***\n" +
    "There are several challenges! \n" +
    "\n" +
    "Pits Challege -- Look out for pits. You will feel a breeze if a pit is in an adjacent room.\n" +
    "If you enter a room with a pit, you will die.\n"+
    "***\n" +
    "Amaroks Challenge -- Amaroks roam the caverns. Encountering one is certain death,\n" +
    "but you can smell their rotten stench in nearby rooms.\n" +
    "***\n" +
    "Full Game Challenge--Contains both Pits and Amaroks!\n" +
    "***\n" +
    "You can add bonus Maelstrom challenge to each of above!\n" +
    "\n"+
    "Maelstroms challenge -- Maelstroms are violent forces of sentient wind.\n" +
    "Entering a room with one could transport you to 1 room up and 2 room right.\n" +
    "Maelstrom will move itself 1 room bottom and 2 room left in the caverns.\n" +
    "If the player will sweep away to another dangerous location, such as a pit,\n" +
    "that room’s effects will happen upon landing in that room.\n" +
    "If Maelstrom effect will move the player or maelstrom beyond the map’s edge, they stay on the map.\n" +
    "You will be able to hear their growling and groaning in nearby rooms.\n"+
    "***\n" +
    "If you want to carry weapon you can take bow with 5 arrows. You can kill Melstroms and Amaroks in nearby rooms.\n"+
    "***\n" +
    "Keep in mind don't try to move beyond maze borders, you will lose 1 life for each attempt.\n" +
    "You have 3 lives! If you lose all of them you lose!\n"+
    "Your missions is to find Fountain of objects, activate it and get back to the entrance!"
    );
Console.WriteLine();


Console.WriteLine("                                Commands                           \n" +
    "\n" +
"         Move                        Shoot                    Activate/Deactivate\n"+
"RIGHT arrow key--move east      W key--shoot north                 SPACEBAR\n"+
"LEFT arrow key---move west      A key--shoot west                          \n"+
"UP arrow key-----move north     S key--shoot south                         \n"+
"DOWN arrow key---move south     D key--shoot east                          \n" 

);



Console.ResetColor();


game.FullGameRun();


Console.WriteLine();
Console.WriteLine("press on ENTER to start again !");
Console.WriteLine();
Console.WriteLine("press on ESC to quit!");
Console.WriteLine();
ConsoleKeyInfo newKey = Console.ReadKey(true);

while (true)
{
    if (newKey.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        game.FullGameRun();
        Console.WriteLine();
        Console.WriteLine("press on ENTER to start again !");
        Console.WriteLine();
        Console.WriteLine("press on ESC to quit!");
        Console.WriteLine();
        newKey = Console.ReadKey(true);
    }

    else if (newKey.Key == ConsoleKey.Escape)
    {
        break;
    }
    else
    {
        Coloring.Colorize("invalid choice try again!", ConsoleColor.DarkGray);
        newKey = Console.ReadKey(true);
    }
}



public enum Fountain { enabled, disabled };


