using System;

namespace Lab2
{
    internal class Point
    {
        private double x;
        private double y;

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "{" + this.x + ";" + this.y + "}";
        }
    }
}

