using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class SecondUPDPolyline
    {
        private List<Point> _points;

        public List<Point> Points
        {
            get { return _points; }
            private set { _points = value; }
        }

        public SecondUPDPolyline()
        {
            _points = new List<Point>();
        }

        public SecondUPDPolyline(IEnumerable<Point> points)
        {
            _points = new List<Point>(points);
        }

        public SecondUPDPolyline(params Point[] points)
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

        public double GetLength()
        {
            if (_points.Count < 2)
            {
                return 0;
            }

            double totalLength = 0;

            for (int i = 1; i < _points.Count; i++)
            {
                totalLength += _points[i].DistanceTo(_points[i - 1]);
            }

            return totalLength;
        }

        public void AddPoint(Point point)
        {
            if (point != null)
            {
                _points.Add(point);
            }
        }

        public void AddPoint(double x, double y)
        {
            _points.Add(new Point(x, y));
        }

        public void AddPoints(Point[] points)
        {
            if (points != null)
            {
                _points.AddRange(points);
            }
        }

        public void AddPoints(IEnumerable<Point> points)
        {
            if (points != null)
            {
                _points.AddRange(points);
            }
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
