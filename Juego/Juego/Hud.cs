using System;

namespace Juego
{
     static class Hud
    {
       static public void Draw( Entity p, int x , int y ) 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" Lifes:"+ p.LIFE);
            Console.Write("                       Score:" + p.SCORE);
        }
    }
}
