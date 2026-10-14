using System;

namespace Lab2
{
    internal class Line
    {
        private Point start;
        private Point end;

        public Point Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public Point End
        {
            get { return this.end; }
            set { this.end = value; }
        }

       
        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        
        public Line(double x1, double y1, double x2, double y2)
        {
            this.start = new Point(x1, y1);
            this.end = new Point(x2, y2);
        }

        
        public int Length()
        {
            double dx = this.end.X - this.start.X;
            double dy = this.end.Y - this.start.Y;

            double sum = dx * dx + dy * dy;

            int result = 0;

            while ((result + 1.0) * (result + 1.0) <= sum)
            {
                result++;
            }

            double middle = result + 0.5;

            if (sum >= middle * middle)
            {
                result++;
            }

            return result;
        }

        public override string ToString()
        {
            return "Линия от " + this.start + " до " + this.end;
        }
    }
}