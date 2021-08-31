using System;

namespace Bridge.Concrete
{
    public class Circle : IGeometry
    {
        private double _radius;
        public double Radius
        { 
            get { return _radius; } 
            set 
            {
                _radius = value;
                _diameter = _radius * 2;
            } 
        }

        private double _diameter;
        public double Diameter
        {
            get { return _diameter; }
            set 
            {
                _diameter = value;
                _radius = value / 2;
            }
        }

        public double Area => Math.PI * _diameter * _diameter / 4;

        public static Circle FromDiameter(double diameter)
        {
            return new Circle() { Diameter = diameter };
        }

        public static Circle FromRadius(double radius)
        {
            return new Circle() { Radius = radius };
        }
    }
}
