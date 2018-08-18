using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVY_Fractals
{
    public class Matrix
    {
        public float [,] matrix { get; set; }
        public float dx { get; set; }
        public float dy { get; set; }
        public double Probability { get; set; }
        public Color Color { get; set; }

        public Matrix(float[,] mat, float dx, float dy, double prob, Color clr)
        {
            this.matrix = mat;
            this.dx = dx;
            this.dy = dy;
            this.Probability = prob;
            this.Color = clr;
        }
    }
}
