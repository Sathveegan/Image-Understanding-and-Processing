using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class PreProcess
    {
        IplImage ipl, gray;
        public void loadOrignalImage()
        {
            ipl = Cv.LoadImage("apples.jpg", LoadMode.Color);
            Cv.SaveImage("apple_orginal.jpg", ipl);

        }

        public void convertGraceScale()
        {
            gray = Cv.CreateImage(ipl.Size, BitDepth.U8, 1);
            Cv.CvtColor(ipl, gray, ColorConversion.RgbToGray);

            Cv.SaveImage("apple_gray.jpg", gray);

        }
    }
}
