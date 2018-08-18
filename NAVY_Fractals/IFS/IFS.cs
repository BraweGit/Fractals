using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVY_Fractals
{
    public class IFS
    {
        // a,b,c,d,e,f, p (prob)
        /*
        Sierpinski triangle
        Spiral
        Dragon
        Barnsley fern
        Maple leaf
        Tree
        */

        #region Sierpin
        Matrix sierpin_1 = new Matrix(new float[,] {
        { 0.5f, 0.0f},
        { 0.0f, 0.5f}}, -0.5f, 0.5f, 0.3333, Color.Red);

        Matrix sierpin_2 = new Matrix(new float[,] {
        { 0.5f, 0.0f},
        { 0.0f, 0.5f}}, -0.5f, -0.5f, 0.3333, Color.Green);

        Matrix sierpin_3 = new Matrix(new float[,] {
        { 0.5f, 0.0f},
        { 0.0f, 0.5f}}, 0.5f, -0.5f, 0.3333, Color.Blue);
        #endregion


        // List of used transformations
        public List<Matrix> Transformations { get; set; }
        private Fractal _fractal;
        public Fractal fractal
        {
            get { return _fractal; }
            set
            {
                _fractal = value;
                Transformations = value.TransformationMatrices;

            }
        }
        private Random r;

        // Index of chosen transformation
        private int indexTransformation;

        public IFS(Fractal f = null)
        {
            r = new Random();
            Transformations = new List<Matrix>();
            if (f == null)
            {
                Transformations.Add(sierpin_1);
                Transformations.Add(sierpin_2);
                Transformations.Add(sierpin_3);
            }
            else
            {
                Transformations = f.Get();
            }
        }

        public Point[] Run(int iterations)
        {
            List<Point> res = new List<Point>();

            //body na pocatku - jeden bod stačí
            Point[] points = new Point[] { new Point(0f, 0f, Color.Red) };

            //počítání jednotlivých iterací
            for (int i = 0; i < iterations; i++)
            {
                for (int k = 0; k < points.Length; k++)
                {
                    Point bn = randTransformation(points[k]);

                    points[k] = bn;
                    res.Add(bn);
                }
            }

            return TransformPoints(res.ToArray());
        }

        private Matrix pickTransformation()
        {
            //kontrola vstupu
            if (Transformations == null) { return null; }
            if (Transformations.Count == 0) { return null; }

            double tmp = 0;
            indexTransformation = -1;
            double rnd = r.NextDouble();
            foreach (Matrix m in Transformations)
            {
                if (m.Probability > 0)
                {
                    tmp += m.Probability;
                    indexTransformation++;
                    if (tmp > rnd)
                    {
                        return m;
                    }
                }
            }

            return Transformations.Last();
        }

        private Point randTransformation(Point point, int k = -1)
        {
            Point newPoint = point;
            if (k == -1)
            {
                newPoint = point.Multiply(pickTransformation());
            }
            else
            {
                if (k < Transformations.Count)
                {
                    newPoint = point.Multiply(Transformations.ElementAt(k));
                }
            }

            return newPoint;
        }



        private Point[] TransformPoints(Point[] points)
        {
            if (points.Length == 0) { return points; }
            float xMin = points[0].X, xMax = points[0].X,
                  yMin = points[0].Y, yMax = points[0].Y;

            //nalezeni minima, maxima
            for (int i = 0; i < points.Length; i++)
            {
                xMin = Math.Min(points[i].X, xMin);
                xMax = Math.Max(points[i].X, xMax);

                yMin = Math.Min(points[i].Y, yMin);
                yMax = Math.Max(points[i].Y, yMax);

            }

            //transformace na [rX[0]..rX[1], rY[0]..rY[1]
            for (int i = 0; i < points.Length; i++)
            {
                float xn, yn;
                if (xMax == xMin) { xn = points[i].X; }
                else
                {
                    xn = (fractal.rX[1] - fractal.rX[0]) * (points[i].X - xMin) / (xMax - xMin) + fractal.rX[0];
                }

                if (yMax == yMin) { yn = points[i].Y; }
                else
                {
                    yn = (fractal.rY[1] - fractal.rY[0]) * (points[i].Y - yMin) / (yMax - yMin) + fractal.rY[0];
                }

                points[i] = new Point(xn, yn, points[i].Color);
            }

            return points;
        }



    }
}
