using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Game
    {
        Character player;

        public void Init()
        {
             player= new Character(0,0);
        }

        public void GameLoop()
        {
            do
            {
                Input();
                //Update();
                Draw();

            } while (true);
        }

        private void Input()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);

            if (cki.Key == ConsoleKey.D)
            {
                player.X += 1;
            }

        }       
        
        private void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(player.X, player.Y);
            Console.Write(player.MODEL);            
        }









    }
}
