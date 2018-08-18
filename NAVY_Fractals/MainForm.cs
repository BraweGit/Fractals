using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVY_Fractals
{
    public partial class MainForm : Form
    {
        private IFS _ifs;
        private Fractals _fractals;
        public MainForm()
        {
            InitializeComponent();
            _ifs = new IFS();
            _fractals = new Fractals();
            Init();
        }

        private void Init()
        {
            comboFractals.DisplayMember = "Name";
            comboFractals.ValueMember = "Value";
            comboFractals.DataSource = _fractals.Get();
        }
        private void Execute()
        {
            _ifs.fractal = _fractals.Get()[(int)comboFractals.SelectedValue];
            var fract = _ifs.Run((int)numIterations.Value);

            var scalePos = 250;
            var b = new Bitmap(picFractal.Width, picFractal.Height);
            using (var g = Graphics.FromImage(b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                foreach (var p in fract)
                {
                    var x = p.X;
                    var y = p.Y;
                    g.FillRectangle(new SolidBrush(p.Color), p.X * scalePos + picFractal.Width / 2, p.Y * scalePos + picFractal.Height / 2, 1, 1);
                }

                b.RotateFlip(RotateFlipType.Rotate180FlipNone);
                picFractal.Image = b;
            }

        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            Execute();
        }
    }
}
