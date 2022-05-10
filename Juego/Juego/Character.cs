using System;

namespace Juego
{
    class Character
    {
        protected Random rnd = new Random();
        protected char _model;
        protected int _x;
        protected int _y;
        protected int life = 5;
        protected int score;

        private int minX = 0;
        private int maxX = 44;
        private int minY = 3;
        private int maxY = 28;

        public Character(int posX, int posY, char model)
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

        public void Collision(Enemy e)
        {
            if(_x == e.X && _y == e.Y)
            {
                LIFE -= 1;
                Respawn();
            }
        }

        private void Respawn()
        {
            _x = rnd.Next(minX,maxX);
            _y = rnd.Next(minY, maxY);
        }
    }
}
