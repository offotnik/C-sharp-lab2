using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class UPDPolyline
    {
        private List<Point> _points;

        public List<Point> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public UPDPolyline()
        {
            _points = new List<Point>();
        }

        public UPDPolyline(IEnumerable<Point> points)
        {
            _points = new List<Point>(points);
        }

        public UPDPolyline(params Point[] points)
        {
            _points = new List<Point>(points);
        }

        public override string ToString()
        {
            if (_points == null || _points.Count == 0)
            {
                return "Линия []";
            }

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

        public void AddPoint(Point point)
        {
            _points.Add(point);
        }

        public void AddPoint(double x, double y)
        {
            _points.Add(new Point(x, y));
        }
    }
}
