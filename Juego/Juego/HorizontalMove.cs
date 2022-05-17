using System.Threading;

namespace Juego
{
    class HorizontalMove:EnemyMovement
    {
        public override void Move(Enemy enemy)
        {
            if (enemy.X == Entity.maxX)
                enemy.Direction = true;
            if (enemy.X == Entity.minX)
                enemy.Direction = false;

            if (enemy.Direction)
                enemy.X -= 1;
            else enemy.X += 1;
            Thread.Sleep(100);
        }
    }
}
