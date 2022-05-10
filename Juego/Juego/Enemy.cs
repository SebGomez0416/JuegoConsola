using System;
using System.Threading;

namespace Juego
{
    class Enemy:Character
    {
        Random rnd = new Random();

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
            Thread.Sleep(200);            
        }        
    }
}
