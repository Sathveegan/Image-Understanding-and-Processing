using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProgram
{
    public partial class IET : Form
    {
        PreProcess p = new PreProcess();

        public IET()
        {
            InitializeComponent();
        }

        private void IET_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            p.loadOrignalImage();
            Image copyImg = GetCopyImage("apples.jpg");
            spBox.Image = copyImg;
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);

                return bm;
            }
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            p.convertGraceScale();

            Image copyImg = GetCopyImage("apple_gray.jpg");
            cpBox.Image = copyImg;
        }
    }
}
