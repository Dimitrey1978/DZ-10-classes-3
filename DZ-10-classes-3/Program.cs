using System;

namespace DZ_10_classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //пробуем треугольник
            //Figure figure = new Figure(new Point(0, 0, "a"), new Point(2, 2, "b"), new Point(2, 0, "c"));
            //пробуем четырехугольник
            //Figure figure = new Figure(new Point(0, 0, "a"), new Point(0, 5, "b"), new Point(5, 5, "c"), new Point(5, 0, "d"));
            //пробуем пятиугольник
            Figure figure = new Figure(new Point(0, 0, "a"), new Point(1, 5, "b"), new Point(5, 6, "c"), new Point(4, 0, "d"), new Point(2, -1, "e"));
            Console.WriteLine($"фигура: { figure.Tip}");
            Console.Write("периметр: ");
            figure.PerimeterCalkulator();

            
        }
    }
}
