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
        Enemy enemy;

        public void Init()
        {
            player= new Character(60,25);
            enemy = new Enemy(20,5);
            Console.CursorVisible=false;

        }

        public void GameLoop()
        {
            do
            {
                Input();
                Update();
                Draw();

            } while (true);
        }

        private void Input()
        {
            InputPlayer.Input(player);
            enemy.Move();
        }
        
        private void Update()
        {

        }
        
        private void Draw()
        {
            Console.Clear();
            player.Draw();
            enemy.Draw();
            Thread.Sleep(200);
        }









    }
}
