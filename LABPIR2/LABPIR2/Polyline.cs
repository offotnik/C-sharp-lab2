using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class Polyline
    {
        private List<Point> _points;

        public List<Point> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public Polyline()
        {
            _points = new List<Point>();
        }

        public Polyline(IEnumerable<Point> points)
        {
            _points = new List<Point>(points);
        }

        public override string ToString()
        {
            var pointsString = string.Join(", ", _points.Select(p => p.ToString()));
            return $"Линия [{pointsString}]";
        }

        public void Shift(double deltaX, double deltaY)
        {
            foreach (var point in _points)
            {
                point.X += deltaX;
                point.Y += deltaY;
            }
        }

        public void ShiftStart(double newX, double newY)
        {
            if (_points.Count == 0)
            {
                return;
            }

            var firstPoint = _points[0];
            double deltaX = newX - firstPoint.X;
            double deltaY = newY - firstPoint.Y;

            Shift(deltaX, deltaY);
        }
    }
}
