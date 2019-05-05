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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Preferences p = new Preferences();

        private Image GetViewImage(string path)
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
                    pbSource.Image = GetViewImage(open.FileName);
            }
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            p.grayScale();

            pbDes.Image = GetViewImage("grayImage.jpg");
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            p.negativeForColor();

            pbDes.Image = GetViewImage("negImageForColor.jpg");
        }

        private void btnExtractData_Click(object sender, EventArgs e)
        {
            p.extractData();
        }

        private void btnGreyLevelSlicing_Click(object sender, EventArgs e)
        {
            p.greyLevelSlicing();

            pbDes.Image = GetViewImage("glsImage.jpg");
        }

        private void btnLogTransformation_Click(object sender, EventArgs e)
        {
            p.logTransformation();

            pbDes.Image = GetViewImage("ltImage.jpg");
        }

        private void btnPowerLawTransformation_Click(object sender, EventArgs e)
        {
            p.powerLawTransformation(tBGamma.Value);

            pbDes.Image = GetViewImage("pltImage.jpg");
        }

        private void btnThresHold_Click(object sender, EventArgs e)
        {
            p.thresHold(10);

            pbDes.Image = GetViewImage("thresHoldImage.jpg");
        }

        private void btnGNegative_Click(object sender, EventArgs e)
        {
            p.negativeForGrey();

            pbDes.Image = GetViewImage("negImageForGrey.jpg");
        }

        private void btnArithmeticMean_Click(object sender, EventArgs e)
        {
            p.arithmeticMean();

            pbDes.Image = GetViewImage("arithmeticMeanImage.jpg");
        }

        private void btnGeometricMean_Click(object sender, EventArgs e)
        {
            p.geometricMean();

            pbDes.Image = GetViewImage("geometricMeanImage.jpg");
        }

        private void btnHarmonicMean_Click(object sender, EventArgs e)
        {
            p.harmonicMean();

            pbDes.Image = GetViewImage("harmonicMeanImage.jpg");
        }

        private void btnContraHarmonicMean_Click(object sender, EventArgs e)
        {
            p.contraHarmonicMean(1.5);

            pbDes.Image = GetViewImage("contraHarmonicMeanImage.jpg");
        }

        private void btnMedianFilter_Click(object sender, EventArgs e)
        {
            p.medianFilter();

            pbDes.Image = GetViewImage("medianImage.jpg");
        }

        private void btnMaxFilter_Click(object sender, EventArgs e)
        {
            p.maxFilter();

            pbDes.Image = GetViewImage("maxImage.jpg");
        }

        private void btnMinFilter_Click(object sender, EventArgs e)
        {
            p.minFilter();

            pbDes.Image = GetViewImage("minImage.jpg");
        }
    }
}
