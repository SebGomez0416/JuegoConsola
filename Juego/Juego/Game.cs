using System;
using System.Threading;

namespace Juego
{

    // tamaño consola 45 x 30 
    //limite y=28;
    //limite x= 44;
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
