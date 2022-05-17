using System.Threading;

namespace Juego
{
    class RandMove:EnemyMovement
    {

        public override void Move(Enemy enemy)
        {
            if (enemy.rnd.Next(0, 2) == 0)
            {
                if (enemy.rnd.Next(0, 2) == 0)
                    enemy.X -= 1;
                else enemy.X += 1;
            }
            else
            {
                if (enemy.rnd.Next(0, 2) == 0)
                    enemy.Y -= 1;
                else enemy.Y += 1;
            }
            enemy.Limit();
            Thread.Sleep(100);
        }
    }
}
