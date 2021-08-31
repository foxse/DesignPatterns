using System;

namespace Bridge.Concrete
{
    class Program
    {
        static void Main(string[] args)
        {
            FigurePainter figurePainter = new FigurePainter();
            var paintedCircle = new PaintedFigure(Circle.FromRadius(5));
            var paintedSqare = new PaintedFigure(new Square(15));

            figurePainter.PaintFigure(paintedCircle, ConsoleColor.Green);
            figurePainter.PaintFigure(paintedSqare, ConsoleColor.Red);
        }
    }
}
