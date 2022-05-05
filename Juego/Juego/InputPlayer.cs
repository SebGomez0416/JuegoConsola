using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
   static class InputPlayer
    {

        static public void Input(Character player)
        {


            if (!Console.KeyAvailable) return;
            ConsoleKeyInfo cki = Console.ReadKey(true);
            switch (cki.Key)
            {
              case ConsoleKey.A:
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
}
