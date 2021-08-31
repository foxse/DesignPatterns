using System;

namespace Bridge.Concrete
{
    class PaintedFigure
    {
        protected IGeometry _figure;
        protected ConsoleColor _color;

        public ConsoleColor FigureColor => _color;
        public IGeometry Figure => _figure;

        public PaintedFigure(IGeometry figure)
        {
            _figure = figure;
            _color = Console.BackgroundColor;
        }

        public PaintedFigure(IGeometry figure, ConsoleColor color)
        {
            _figure = figure;
            _color = color;
        }

        public double GetArea()
        {
            return _figure.Area;
        }

        public void Paint(ConsoleColor color)
        {
            _color = color;
        }
    }
}
