
using System;
using System.Threading;
using System.Collections.Generic;

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
        List<Enemy> enemys = new List<Enemy>();

        PowerUps powerUpAtack;      

        public void Init()
        {
            p_One= new Entity(10,26,(char)199);
            p_Two= new Entity(25,26,(char)229);

            enemy = new Enemy(20,16,(char)245,new HorizontalMove());
            enemy_Two = new Enemy(2, 20, (char)245,new RandMove());
            enemy_Three = new Enemy(35, 10, (char)245,new DiagonalMove());

            enemys.Add(enemy);
            enemys.Add(enemy_Two);
            enemys.Add(enemy_Three);

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
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                InputPlayer.Input(p_One, cki);
                InputPlayer.InputArrows(p_Two, cki);
            }
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

            foreach (Enemy e in enemys)            
                e.Draw();

                if (!p_One.POWERUP && !p_One.POWERUP)
                powerUpAtack.Draw();            
           
            Thread.Sleep(200);
        }

        private void UpdateEnemys()
        {

            foreach (Enemy e in enemys)
            {
                e.Move();
                e.Collision(p_One);
                e.Collision(p_Two);
            }
        }

    }
}
