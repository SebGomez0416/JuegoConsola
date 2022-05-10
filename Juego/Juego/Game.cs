using System;
using System.Threading;

namespace Juego
{

    // tamaño consola 45 x 30    
    class Game
    {
        Character player;
        Enemy enemy;

        public void Init()
        {
            player= new Character(20,20, 'X');
            enemy = new Enemy(20,4,'O');
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
        }
        
        private void Update()
        {
            player.Limit();
            enemy.Move();
            player.Collision(enemy);           
        }
        
        private void Draw()
        {
            Console.Clear();
            Hud.Draw(player,0,1);
            player.Draw();
            enemy.Draw();
            Thread.Sleep(200);
        }









    }
}
