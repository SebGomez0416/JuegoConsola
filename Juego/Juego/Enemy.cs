using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Enemy
    {

        private string _model = "O";
        private int _x;
        private int _y;

        public Enemy(int posX, int posY)
        {
            _x = posX;
            _y = posY;
        }

        public void Move()
        {

        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_model);
        }
    }
}
