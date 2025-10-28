using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Polyline
    {
        public List<Point> Points { get; set; }

        public Polyline()
        {
            Points = new List<Point>();
        }

        public Polyline(IEnumerable<Point> points)
        {
            Points = new List<Point>(points);
        }

        public override string ToString()
        {
            var pointsString = string.Join(",", Points.Select(p => p.ToString()));
            return $"Линия [{pointsString}]";
        }

        public void Shift(double deltaX, double deltaY)
        {
            foreach (var point in Points)
            {
                point.X += deltaX;
                point.Y += deltaY;
            }
        }

        public void ShiftStart(double newX, double newY)
        {
            if (Points.Count > 0)
            {
                var firstPoint = Points[0];
                double deltaX = newX - firstPoint.X;
                double deltaY = newY - firstPoint.Y;
                Shift(deltaX, deltaY);
            }
        }
    }
}
