using System;

namespace Lab2
{
    internal class Point
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"{{{X};{Y}}}";
        }

        public double DistanceTo(Point other)
        {
            if (other == null)
            {
                return 0;
            }

            double deltaX = X - other.X;
            double deltaY = Y - other.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
