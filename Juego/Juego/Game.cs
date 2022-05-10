using System;
using System.Threading;

namespace Juego
{

    // tamaño consola 45 x 30    
    class Game
    {
        Entity player;
        Enemy enemy;
        PowerUps powerUpAtack;

        public void Init()
        {
            player= new Entity(20,20, 'X');
            enemy = new Enemy(20,4,'O');
            powerUpAtack = new PowerUps(20,10, '$');
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
            enemy.Collision(player);
            powerUpAtack.Collision(player);
        }
        
        private void Draw()
        {
            Console.Clear();
            Hud.Draw(player,0,1);
            player.Draw();
            enemy.Draw();
            powerUpAtack.Draw();
            Thread.Sleep(200);
        }









    }
}
