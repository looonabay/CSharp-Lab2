using System;

namespace Lab2
{
    internal class Line
    {
        private Point _start = new Point(0, 0);
        private Point _end = new Point(0, 0);

        public Point Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }

        public Point End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }

        public Line(Point start, Point end)
        {
            this._start = start;
            this._end = end;
        }

        public Line(double x1, double y1, double x2, double y2)
        {
            this._start = new Point(x1, y1);
            this._end = new Point(x2, y2);
        }

        public int Length()
        {
            double dx = this._end.X - this._start.X;
            double dy = this._end.Y - this._start.Y;

            double sum = dx * dx + dy * dy;

            int result = 0;

            while ((result + 1.0) * (result + 1.0) <= sum)
            {
                result++;
            }

            double mid= result + 0.5;

            if (sum >= mid * mid)
            {
                result++;
            }

            return result;
        }

        public override string ToString()
        {
            return "Линия от " + this._start + " до " + this._end;
        }
    }
}
