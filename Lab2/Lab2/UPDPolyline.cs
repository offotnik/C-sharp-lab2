using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class UPDPolyline
    {
        public List<Point> Points { get; set; }

        public UPDPolyline()
        {
            Points = new List<Point>();
        }

        public UPDPolyline(IEnumerable<Point> points)
        {
            Points = new List<Point>(points);
        }

        public UPDPolyline(params Point[] points)
        {
            Points = new List<Point>(points);
        }

        public override string ToString()
        {
            if (Points == null || Points.Count == 0)
            {
                return "Линия []";
            }

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

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public void AddPoint(double x, double y)
        {
            Points.Add(new Point(x, y));
        }

    }
}
