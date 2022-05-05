using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Juego
{
    class Game
    {
        Character player;

        public void Init()
        {
            player= new Character(60,25);
            Console.CursorVisible=false;

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
            InputPlayer.Input(player);
        }       
        
        private void Draw()
        {
            player.Draw();
            Thread.Sleep(100);
        }









    }
}
