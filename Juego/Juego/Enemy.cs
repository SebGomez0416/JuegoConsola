using System;
using System.Threading;

namespace Juego
{
    class Enemy:Entity , Icollision
    {     

        public Enemy(int posX, int posY, char model):base(posX,posY,model)
        {
            
        }

        public void Move()
        {
            if (rnd.Next(0, 2) == 0)
            {               
                if (rnd.Next(0, 2) == 0)                
                    _x -= 1;                
                else _x += 1;
            }
            else
            {               
                if (rnd.Next(0, 2) == 0)
                    _y -= 1;
                else _y += 1;
            }
            Limit();
            Thread.Sleep(100);            
        }

        public void Collision(Entity  p)
        {
            if (_x == p.X && _y == p.Y)
            {
                p.LIFE -= 1;
                p.Respawn();
            }
        }
    }
}
