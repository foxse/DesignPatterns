namespace Bridge.Concrete
{
    public class Square : IGeometry
    {
        public Square(double sideLength)
        {
            _sideLength = sideLength;
        }

        private double _sideLength;
        public double SideLength
        {
            set { _sideLength = value; }
            get { return _sideLength; }
        }

        public double Area => _sideLength * _sideLength;
    }
}
