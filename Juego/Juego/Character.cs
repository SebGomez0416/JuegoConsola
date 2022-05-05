using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Character
    {
        private string _model = "X";
        private int _x;
        private int _y;

        public Character(int posX , int posY)
        {
            _x = posX;
            _y = posY;
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

        public void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(_x, _y);
            Console.Write(_model);
            
        }
    }
}
