using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Examen1parcial
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _ImgInput;
        Image<Gray, byte> _GrayImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres salir?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }


        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _ImgInput = new Image<Bgr, byte>(ofd.FileName);
                    imageBox1.Image = _ImgInput;
                    imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void histogramaRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _ImgInput[2] }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            histogramBox1.AddHistogram("Histograma de color Rojo", Color.Red, m, 256, new float[] { 0, 255 });
            histogramBox1.Refresh();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> _ImgCanny = new Image<Gray, byte>(_ImgInput.Width, _ImgInput.Height, new Gray(0));
            _ImgCanny = _ImgInput.Canny(100, 50);
            imageBox2.Image = _ImgCanny;
            imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
        }
    }
}
