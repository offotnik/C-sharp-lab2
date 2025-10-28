using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class SecondUPDPolyline
    {
        public List<Point> Points { get; private set; }

        public SecondUPDPolyline()
        {
            Points = new List<Point>();
        }

        public SecondUPDPolyline(IEnumerable<Point> points)
        {
            Points = new List<Point>(points);
        }

        public SecondUPDPolyline(params Point[] points)
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

        public double GetLength()
        {
            if (Points.Count < 2)
                return 0;

            double totalLength = 0;
            for (int i = 1; i < Points.Count; i++)
            {
                totalLength += Points[i].DistanceTo(Points[i - 1]);
            }
            return totalLength;
        }

        public void AddPoint(Point point)
        {
            if (point != null)
                Points.Add(point);
        }

        public void AddPoint(double x, double y)
        {
            Points.Add(new Point(x, y));
        }

        public void AddPoints(Point[] points)
        {
            if (points != null)
                Points.AddRange(points);
        }

        public void AddPoints(IEnumerable<Point> points)
        {
            if (points != null)
                Points.AddRange(points);
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
