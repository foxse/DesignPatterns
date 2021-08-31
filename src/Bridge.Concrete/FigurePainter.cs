using System;

namespace Bridge.Concrete
{
    class FigurePainter
    {
        public void PaintFigure(PaintedFigure paintedFigure, ConsoleColor color)
        {
            paintedFigure.Paint(color);
            
            var oldForeground = Console.ForegroundColor;
            Console.ForegroundColor = paintedFigure.FigureColor;
            Console.WriteLine(paintedFigure.Figure.GetType().Name);
            Console.ForegroundColor = oldForeground;
        }
    }
}
