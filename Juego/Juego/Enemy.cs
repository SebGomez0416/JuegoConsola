using System;
using System.Threading;

namespace Juego
{
    class Enemy:Entity , Icollision
    {
        private bool direction;

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

        public void DiagonalMove()
        {
            if (rnd.Next(0, 2) == 0)
                _x -= 1;
            else _x += 1;

            if (rnd.Next(0, 2) == 0)
                _y -= 1;
            else _y += 1;

            Limit();
            Thread.Sleep(100);
        }
        public void HorizontalMove()
        {           

            if (_x == maxX)
                direction = true;
            if (_x == minX)
                direction = false;               

            if(direction)
                _x -= 1;
            else _x += 1;
            Thread.Sleep(100);
        }



        public void Collision(Entity  p)
        {
            if (_x == p.X && _y == p.Y)
            {
                if (p.POWERUP) 
                { 
                    p.POWERUP=false;
                    p.SCORE+=1;
                    Respawn();                
                }
                else
                {
                     p.LIFE -= 1;
                     p.Respawn();
                }
               
            }
        }
    }
}
