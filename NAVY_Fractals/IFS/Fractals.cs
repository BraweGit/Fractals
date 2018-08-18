using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVY_Fractals
{
    public class Fractal
    {
        public List<Matrix> TransformationMatrices { get; set; }
        public float[] rX { get; set; }
        public float[] rY { get; set; }

        public Fractal(string name, int val)
        {
            TransformationMatrices = new List<Matrix>();
            Name = name;
            Value = val;
            rX = new float[2];
            rY = new float[2];
        }

        public List<Matrix> Get()
        {
            return TransformationMatrices;
        }

        public string Name { get; set; }
        public int Value { get; set; }
    }
    public class Fractals
    {
        private List<Fractal> _fractals;
        public List<Fractal> Get()
        {
            return _fractals;
        }

        public Fractals()
        {
            _fractals = new List<Fractal>();

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

            #region Fern
            Matrix fern_1 = new Matrix(new float[,] {
        { 0.0f, 0.0f, },
        { 0.0f, 0.16f}}, 0.0f, 0.0f, 0.01, Color.Green);

            Matrix fern_2 = new Matrix(new float[,] {
        { 0.85f, 0.04f, },
        { -0.04f, 0.85f}}, 0.0f, 1.6f, 0.85, Color.Green);

            Matrix fern_3 = new Matrix(new float[,] {
        { 0.2f, -0.26f, },
        { 0.23f, 0.22f}}, 0.0f, 1.6f, 0.07, Color.Green);

            Matrix fern_4 = new Matrix(new float[,] {
        { -0.15f, 0.28f, },
        { 0.26f, 0.24f}}, 0.0f, 0.44f, 0.07, Color.Green);
            #endregion

            #region Tree
            Matrix tree_1 = new Matrix(new float[,] {
        { 0.05f, 0.0f},
        { 0.0f, 0.4f}}, -0.06f, -0.47f, 0.142, Color.Green);

            Matrix tree_2 = new Matrix(new float[,] {
        { -0.05f, 0.0f},
        { 0.0f, -0.4f}}, -0.06f, -0.47f, 0.142, Color.Green);

            Matrix tree_3 = new Matrix(new float[,] {
        { 0.03f, -0.140f},
        { 0.0f, 0.26f}}, -0.16f, -0.1f, 0.142, Color.Green);

            Matrix tree_4 = new Matrix(new float[,] {
        { -0.03f, 0.14f},
        {  0.0f, -0.26f}}, -0.16f, -0.01f, 0.142, Color.Green);

            Matrix tree_5 = new Matrix(new float[,] {
        { 0.56f, 0.44f},
        { -0.37f, 0.51f}}, 0.3f, 0.15f, 0.142, Color.Green);

            Matrix tree_6 = new Matrix(new float[,] {
        { 0.19f, 0.07f},
        { -0.1f, 0.15f}}, -0.2f, 0.28f, 0.142, Color.Green);

            Matrix tree_7 = new Matrix(new float[,] {
        { -0.33f, -0.340f},
        {  -0.330f, 0.34f}}, -0.54f, 0.39f, 0.142, Color.Green);
            #endregion

            var sierpin = new Fractal("Sierpinski Triangle", 0);
            sierpin.TransformationMatrices.Add(sierpin_1);
            sierpin.TransformationMatrices.Add(sierpin_2);
            sierpin.TransformationMatrices.Add(sierpin_3);
            sierpin.rX = new float[] { -1f, 1f };
            sierpin.rY = new float[] { -1f, 1f };
            _fractals.Add(sierpin);

            var fern = new Fractal("Barnsley fern", 1);
            fern.TransformationMatrices.Add(fern_1);
            fern.TransformationMatrices.Add(fern_2);
            fern.TransformationMatrices.Add(fern_3);
            fern.TransformationMatrices.Add(fern_4);
            //fern.rX = new float[] { -5f, 5f };
            //fern.rY = new float[] { 10.5f, 0f };
            fern.rX = new float[] { -1f, 1f };
            fern.rY = new float[] { -1f, 1f };
            _fractals.Add(fern);

            var tree = new Fractal("Tree", 2);
            tree.TransformationMatrices.Add(tree_1);
            tree.TransformationMatrices.Add(tree_2);
            tree.TransformationMatrices.Add(tree_3);
            tree.TransformationMatrices.Add(tree_4);
            tree.TransformationMatrices.Add(tree_5);
            tree.TransformationMatrices.Add(tree_6);
            tree.TransformationMatrices.Add(tree_7);
            tree.rX = new float[] { -1f, 1f };
            tree.rY = new float[] { -1f, 1f };
            _fractals.Add(tree);

        }
    }
}
