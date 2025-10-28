using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Point
    {
        private double x;
        private double y;


        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y 
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{{{X};{Y}}}";
        }

        public double DistanceTo(Point other)
        {
            if (other == null) return 0;
            double deltaX = X - other.X;
            double deltaY = Y - other.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
