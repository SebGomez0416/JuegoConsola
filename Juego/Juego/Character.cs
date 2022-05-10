using System;

namespace Juego
{
    class Character
    {
        protected char _model;
        protected int _x;
        protected int _y;
        private int minX= 0;
        private int maxX= 44;
        private int minY=3;
        private int maxY=28;

        public Character(int posX , int posY, char model)
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
    }
}
