using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVY_Fractals
{
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Color Color { get; set; }

        public Point() { }

        public Point(float x, float y, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
        }

        public Point Multiply(Matrix m)
        {
            // Boundary check
            if (m.matrix.GetLength(0) != 2 || m.matrix.GetLength(1) != 2)
            {
                return this;
            }

            Point newPoint = new Point();
            newPoint.X = m.matrix[0, 0] * this.X + m.matrix[0, 1] * this.Y + m.dx;
            newPoint.Y = m.matrix[1, 0] * this.X + m.matrix[1, 1] * this.Y + m.dy;

            newPoint.Color = m.Color;

            return newPoint;
        }

    }
}
