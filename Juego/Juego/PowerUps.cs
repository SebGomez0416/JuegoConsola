using System;

namespace Juego
{
    class PowerUps:Entity, Icollision
    {
        public PowerUps(int posX, int posY, char model) : base(posX, posY, model)
        {

        }

        public void Collision(Entity p)
        {
            if (_x == p.X && _y == p.Y)
            {
                p.POWERUP = true;
                Active();
            }
        }

        private void Active()
        {
            Console.SetCursorPosition(minX,maxY+1);
            Console.Write("                    Atack");
        }

    }
}
