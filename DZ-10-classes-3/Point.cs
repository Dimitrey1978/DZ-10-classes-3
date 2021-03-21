using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_10_classes_3
{
    class Point
    {
        int x, y;
        string tip;

        //непонятно, зачем передаем string tip -
        // мы с ним ничего не делаем, можно убрать

        // но при отладке помог найти ошибку (в какой точке)
        public Point (int x, int y, string tip)
        {
            this.x = x;
            this.y = y;
            this.tip = tip;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Tip
        {
            get { return tip; }
        }
    }
}
