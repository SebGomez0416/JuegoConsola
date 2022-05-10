using System;

namespace Juego
{
    class Entity 
    {
        protected Random rnd = new Random();
        protected char _model;
        protected int _x;
        protected int _y;
        protected int life = 5;
        protected int score;
        private bool powerUp;


        protected int minX = 0;
        protected int maxX = 44;
        protected int minY = 3;
        protected int maxY = 27;

        public Entity(int posX, int posY, char model)
        {
            _x = posX;
            _y = posY;
            _model = model;
        }

        public int X
        {
            set { _x = value; }
            get { return _x; }

        }

        public int Y
        {
            set { _y = value; }
            get { return _y; }
        }

        public int LIFE
        {
            set { life = value; }
            get { return life; }
        }

        public int SCORE
        {
            set { score = value; }
            get { return score; }
        }

        public bool POWERUP
        {
            set { powerUp = value; }
            get { return powerUp; }
        }


        public void Limit()
        {
            if (_x < minX) _x = minX;
            if (_x > maxX) _x = maxX;
            if (_y < minY) _y = minY;
            if (_y > maxY) _y = maxY;
        }

        public void Draw()
        {            
            Console.SetCursorPosition(_x, _y);
            Console.Write(_model);              
        }       

        public void Respawn()
        {
            _x = rnd.Next(minX,maxX);
            _y = rnd.Next(minY, maxY);
        }
    }
}
