using System;

namespace Juego
{
   static class InputPlayer
    {
       
        static public void Input(Entity player)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.A :
                        player.X -= 1;
                        break;
                    case ConsoleKey.D:
                        player.X += 1;
                        break;
                    case ConsoleKey.W:
                        player.Y -= 1;
                        break;
                    case ConsoleKey.S:
                        player.Y += 1;
                        break;
                }
            }            
            
        }


        static public void InputArrows(Entity player)
        {
            if (Console.KeyAvailable) 
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        player.X -= 1;
                        break;
                    case ConsoleKey.RightArrow:
                        player.X += 1;
                        break;
                    case ConsoleKey.UpArrow:
                        player.Y -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        player.Y += 1;
                        break;
                }
            }

        }
    }
}
