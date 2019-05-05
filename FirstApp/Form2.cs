using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form2 : Form
    {
        Preferences p = new Preferences();

        public Form2()
        {
            InitializeComponent();
        }

        private Image getViewImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);

                return bm;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select the Image File";
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (p.loadImage(open.FileName))
                    pbInput.Image = getViewImage(open.FileName);
            }
        }

        private void btnSlobel_Click(object sender, EventArgs e)
        {
            p.slobelOperator();

            pbOutput1.Image = getViewImage("sx.jpg");

            pbOutput2.Image = getViewImage("sy.jpg");

        }

        private void btnLaplacian_Click(object sender, EventArgs e)
        {
            p.laplacianOperator();

            pbOutput1.Image = getViewImage("laplace.jpg");

            pbOutput2.Image = null;
        }

        private void btnLaplacianWithoutNoise_Click(object sender, EventArgs e)
        {
            p.laplacianWithoutNoiseOperator();

            pbOutput1.Image = getViewImage("laplaceWithoutNoise.jpg");

            pbOutput2.Image = null;
        }
    }
}
