using System;
using System.Threading;

namespace Juego
{

    // tamaño consola 45 x 30    
    class Game
    {
        Entity  p_One;
        Entity  p_Two;

        Enemy enemy;
        Enemy enemy_Two;
        Enemy enemy_Three;

        PowerUps powerUpAtack;      

        public void Init()
        {
            p_One= new Entity(10,26,(char)199);
            p_Two= new Entity(25,26,(char)229);

            enemy = new Enemy(20,16,(char)245);
            enemy_Two = new Enemy(2, 20, (char)245);
            enemy_Three = new Enemy(35, 10, (char)245);

            powerUpAtack = new PowerUps(20,8, (char)169);           
            Console.CursorVisible=false;
        }

        public void GameLoop()
        {
            do
            {
                Input();
                Update();
                Draw();

            } while ( p_One.LIFE>0);
        }

        private void Input()
        {           
            InputPlayer.Input( p_One);
            //InputPlayer.InputArrows(p_Two);
        }
        
        private void Update()
        {
            p_One.Limit();
            p_Two.Limit();

            UpdateEnemys();

            powerUpAtack.Collision( p_One);
            powerUpAtack.Collision(p_Two);
        }
        
        private void Draw()
        {
            Console.Clear();

            Hud.Draw( p_One,0,1);
            Hud.Draw(p_Two, 0, 2);

            p_One.Draw();
            p_Two.Draw();

            enemy.Draw();
            enemy_Two.Draw();
            enemy_Three.Draw();

            if (!p_One.POWERUP && !p_One.POWERUP)
                powerUpAtack.Draw();            
           
            Thread.Sleep(200);
        }

        private void UpdateEnemys()
        {
            enemy.Move();
            enemy.Collision(p_One);
            enemy.Collision(p_Two);

            enemy_Two.DiagonalMove();
            enemy_Two.Collision(p_One);
            enemy_Two.Collision(p_Two);

            enemy_Three.HorizontalMove();
            enemy_Three.Collision(p_One);
            enemy_Three.Collision(p_Two);

        }

    }
}
