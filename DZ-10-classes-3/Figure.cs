using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_10_classes_3
{
    class Figure
    {
        Point[] point;
        string tip;

        public string Tip
        {
            get { return tip; }
        }

        public Figure (Point a, Point b, Point c)
        {
            point = new Point[3];
            point[0] = a;
            point[1] = b;
            point[2] = c;
            tip = "Треугольник";
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            point = new Point[4];
            point[0] = a;
            point[1] = b;
            point[2] = c;
            point[3] = d;
            tip = "Четырехугольник";
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            point = new Point[5];
            point[0] = a;
            point[1] = b;
            point[2] = c;
            point[3] = d;
            point[4] = e;
            tip = "Пятиугольник";
        }

        //по теореме Пифагора
        // длина = sqr ((x2-x1)^2 + (y2-y1)^2)

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.Y - A.Y, 2) + Math.Pow(B.X - B.X, 2));
        }

        //думаю, лучше было бы если бы метод возвращал double perimetr
        //а не просто выводил в консоль.
        // но в условиях - должен быть void

        public void PerimeterCalkulator()
           
        {
            double perimeter = 0;

            for (int i = 0; i<point.Length-1; i++)
            {
                perimeter += LengthSide(point[i], point[i + 1]);
            }

            perimeter += LengthSide(point[point.Length - 1], point[0]);            

            Console.Write(perimeter);
        }


    }
}
