using System;
using System.Threading;

namespace Juego
{
    class Enemy:Entity , Icollision
    {
        public bool Direction { get; set; }
        private EnemyMovement _movement;

        public Enemy(int posX, int posY, char model,EnemyMovement movement):base(posX,posY,model)
        {
            _movement = movement;
        }   
       
        public void Move()
        {
            _movement.Move(this);
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
