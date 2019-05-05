using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Preferences
    {
        IplImage srcImage, grayImage;

        public Boolean loadImage(String fileName)
        {
            srcImage = Cv.LoadImage(fileName, LoadMode.Color);
            Cv.SaveImage("orgImage.jpg", srcImage);

            if (srcImage != null)
                return true;

            return false;
        }

        public void grayScale()
        {
            grayImage = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            Cv.CvtColor(srcImage, grayImage, ColorConversion.RgbToGray);
            Cv.SaveImage("grayImage.jpg", grayImage);
        }

        public void thresHold(double t)
        {
            grayScale();
            IplImage binary = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);
            Cv.Threshold(grayImage, binary, t, 255, ThresholdType.Binary);
            Cv.SaveImage("thresHoldImage.jpg", binary);
        }

        public void negativeForColor()
        {
            IplImage negImage = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Not(srcImage, negImage);
            Cv.SaveImage("negImageForColor.jpg", negImage);
        }

        public void negativeForGrey()
        {
            grayScale();
            //since we are taking the colour image we are giving 1 
            IplImage negImage = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);
            Cv.Not(grayImage, negImage);
            Cv.SaveImage("negImageForGrey.jpg", negImage);
        }

        public void extractData()
        {
            int h = srcImage.Height ;
            int w = srcImage.Width ;
            int c = srcImage.NChannels;

            System.Windows.Forms.MessageBox.Show("Height: " + h + "\nWidth: " + w + "\nNo of Channels: " + c);

        }

        public void greyLevelSlicing()
        {
            IplImage oRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            IplImage rRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            Cv.Split(srcImage, oRed, oGreen, oBlue, null);

            int A = 50;
            int B = 200;

            double getRed = 0;
            double getGreen = 0;
            double getBlue = 0;

            for (int y = 1; y < srcImage.Height - 1; y++)
            {
                for (int x = 1; x < srcImage.Width - 1; x++)
                {
                    getRed = Cv.GetReal2D(oRed, y, x);
                    getGreen = Cv.GetReal2D(oGreen, y, x);
                    getBlue = Cv.GetReal2D(oBlue, y, x);

                    if ((getRed >= A) && (getRed <= B))
                        getRed = 255;

                    if ((getGreen >= A) && (getGreen <= B))
                        getGreen = 255;

                    if ((getBlue >= A) && (getBlue <= B))
                        getBlue = 255;

                    Cv.SetReal2D(rRed, y, x, getRed);
                    Cv.SetReal2D(rGreen, y, x, getGreen);
                    Cv.SetReal2D(rBlue, y, x, getBlue);

                }
            }

            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Merge(rRed, rGreen, rBlue, null, dst);

            Cv.SaveImage("glsImage.jpg", dst);

        }

        //It helps us to reduce the dynamic range.
        //So we will be having a high dynamic range and we are going to reduce the dynamic range.
        //So the lower intensity value will be suppressed and the high dynamic instensity value will be displayed.
        public void logTransformation()
        {
            IplImage oRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            IplImage rRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            Cv.Split(srcImage, oRed, oGreen, oBlue, null);

            double getRed = 0;
            double getGreen = 0;
            double getBlue = 0;

            double c = 105.886;

            for (int y = 1; y < srcImage.Height - 1; y++)
            {
                for (int x = 1; x < srcImage.Width - 1; x++)
                {
                    getRed = Cv.GetReal2D(oRed, y, x);
                    getGreen = Cv.GetReal2D(oGreen, y, x);
                    getBlue = Cv.GetReal2D(oBlue, y, x);

                    getRed = c * Math.Log(1 + getRed);
                    getGreen = c * Math.Log(1 + getGreen);
                    getBlue = c * Math.Log(1 + getBlue);

                    Cv.SetReal2D(rRed, y, x, getRed);
                    Cv.SetReal2D(rGreen, y, x, getGreen);
                    Cv.SetReal2D(rBlue, y, x, getBlue);

                }
            }

            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Merge(rRed, rGreen, rBlue, null, dst);

            Cv.SaveImage("ltImage.jpg", dst);
        }

        public void powerLawTransformation(double gamma)
        {
            IplImage oRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            IplImage rRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            Cv.Split(srcImage, oRed, oGreen, oBlue, null);

            double getRed = 0;
            double getGreen = 0;
            double getBlue = 0;

            double c = 1;

            for (int y = 1; y < srcImage.Height - 1; y++)
            {
                for (int x = 1; x < srcImage.Width - 1; x++)
                {
                    getRed = Cv.GetReal2D(oRed, y, x);
                    getGreen = Cv.GetReal2D(oGreen, y, x);
                    getBlue = Cv.GetReal2D(oBlue, y, x);

                    getRed = c * Math.Pow(getRed, gamma);
                    getGreen = c * Math.Pow(getGreen, gamma);
                    getBlue = c * Math.Pow(getBlue, gamma);

                    Cv.SetReal2D(rRed, y, x, getRed);
                    Cv.SetReal2D(rGreen, y, x, getGreen);
                    Cv.SetReal2D(rBlue, y, x, getBlue);

                }
            }

            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Merge(rRed, rGreen, rBlue, null, dst);

            Cv.SaveImage("pltImage.jpg", dst);
        }

        //good for removing gaussian noise
        public void arithmeticMean()
        {
            IplImage oRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            IplImage rRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            Cv.Split(srcImage, oRed, oGreen, oBlue, null);

            double getRed = 0;
            double getGreen = 0;
            double getBlue = 0;

            for (int y = 1; y < srcImage.Height - 1; y++)
            {
                for (int x = 1; x < srcImage.Width - 1; x++)
                {
                    getRed += Cv.GetReal2D(oRed, y - 1, x - 1);
                    getRed += Cv.GetReal2D(oRed, y, x - 1);
                    getRed += Cv.GetReal2D(oRed, y + 1, x - 1);
                    getRed += Cv.GetReal2D(oRed, y - 1, x);
                    getRed += Cv.GetReal2D(oRed, y, x);
                    getRed += Cv.GetReal2D(oRed, y + 1, x);
                    getRed += Cv.GetReal2D(oRed, y - 1, x + 1);
                    getRed += Cv.GetReal2D(oRed, y, x + 1);
                    getRed += Cv.GetReal2D(oRed, y + 1, x + 1);

                    getGreen += Cv.GetReal2D(oGreen, y - 1, x - 1);
                    getGreen += Cv.GetReal2D(oGreen, y, x - 1);
                    getGreen += Cv.GetReal2D(oGreen, y + 1, x - 1);
                    getGreen += Cv.GetReal2D(oGreen, y - 1, x);
                    getGreen += Cv.GetReal2D(oGreen, y, x);
                    getGreen += Cv.GetReal2D(oGreen, y + 1, x);
                    getGreen += Cv.GetReal2D(oGreen, y - 1, x + 1);
                    getGreen += Cv.GetReal2D(oGreen, y, x + 1);
                    getGreen += Cv.GetReal2D(oGreen, y + 1, x + 1);

                    getBlue += Cv.GetReal2D(oBlue, y - 1, x - 1);
                    getBlue += Cv.GetReal2D(oBlue, y, x - 1);
                    getBlue += Cv.GetReal2D(oBlue, y + 1, x - 1);
                    getBlue += Cv.GetReal2D(oBlue, y - 1, x);
                    getBlue += Cv.GetReal2D(oBlue, y, x);
                    getBlue += Cv.GetReal2D(oBlue, y + 1, x);
                    getBlue += Cv.GetReal2D(oBlue, y - 1, x + 1);
                    getBlue += Cv.GetReal2D(oBlue, y, x + 1);
                    getBlue += Cv.GetReal2D(oBlue, y + 1, x + 1);


                    getRed = getRed / 9.0;
                    getGreen = getGreen / 9.0;
                    getBlue = getBlue / 9.0;
           

                    Cv.SetReal2D(rRed, y, x, getRed);
                    Cv.SetReal2D(rGreen, y, x, getGreen);
                    Cv.SetReal2D(rBlue, y, x, getBlue);

                }
            }

            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Merge(rRed, rGreen, rBlue, null, dst);

            Cv.SaveImage("arithmeticMeanImage.jpg", dst);

        }

        //good for removing gaussian noise
        //better than arithmetic mean
        public void geometricMean()
        {
            IplImage oRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            IplImage rRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            Cv.Split(srcImage, oRed, oGreen, oBlue, null);

            double getRed = 0;
            double getGreen = 0;
            double getBlue = 0;

            for (int y = 1; y < srcImage.Height - 1; y++)
            {
                for (int x = 1; x < srcImage.Width - 1; x++)
                {
                    getRed = Cv.GetReal2D(oRed, y - 1, x - 1);
                    getRed *= Cv.GetReal2D(oRed, y, x - 1);
                    getRed *= Cv.GetReal2D(oRed, y + 1, x - 1);
                    getRed *= Cv.GetReal2D(oRed, y - 1, x);
                    getRed *= Cv.GetReal2D(oRed, y, x);
                    getRed *= Cv.GetReal2D(oRed, y + 1, x);
                    getRed *= Cv.GetReal2D(oRed, y - 1, x + 1);
                    getRed *= Cv.GetReal2D(oRed, y, x + 1);
                    getRed *= Cv.GetReal2D(oRed, y + 1, x + 1);

                    getGreen = Cv.GetReal2D(oGreen, y - 1, x - 1);
                    getGreen *= Cv.GetReal2D(oGreen, y, x - 1);
                    getGreen *= Cv.GetReal2D(oGreen, y + 1, x - 1);
                    getGreen *= Cv.GetReal2D(oGreen, y - 1, x);
                    getGreen *= Cv.GetReal2D(oGreen, y, x);
                    getGreen *= Cv.GetReal2D(oGreen, y + 1, x);
                    getGreen *= Cv.GetReal2D(oGreen, y - 1, x + 1);
                    getGreen *= Cv.GetReal2D(oGreen, y, x + 1);
                    getGreen *= Cv.GetReal2D(oGreen, y + 1, x + 1);

                    getBlue = Cv.GetReal2D(oBlue, y - 1, x - 1);
                    getBlue *= Cv.GetReal2D(oBlue, y, x - 1);
                    getBlue *= Cv.GetReal2D(oBlue, y + 1, x - 1);
                    getBlue *= Cv.GetReal2D(oBlue, y - 1, x);
                    getBlue *= Cv.GetReal2D(oBlue, y, x);
                    getBlue *= Cv.GetReal2D(oBlue, y + 1, x);
                    getBlue *= Cv.GetReal2D(oBlue, y - 1, x + 1);
                    getBlue *= Cv.GetReal2D(oBlue, y, x + 1);
                    getBlue *= Cv.GetReal2D(oBlue, y + 1, x + 1);


                    getRed = (double) Math.Pow(getRed, (1 / 9.0));
                    getGreen = (double) Math.Pow(getGreen, (1 / 9.0));
                    getBlue = (double) Math.Pow(getBlue, (1 / 9.0));


                    Cv.SetReal2D(rRed, y, x, getRed);
                    Cv.SetReal2D(rGreen, y, x, getGreen);
                    Cv.SetReal2D(rBlue, y, x, getBlue);

                }
            }

            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Merge(rRed, rGreen, rBlue, null, dst);

            Cv.SaveImage("geometricMeanImage.jpg", dst);

        }

        //good for removing salt noise
        public void harmonicMean()
        {
            IplImage oRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            IplImage rRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            Cv.Split(srcImage, oRed, oGreen, oBlue, null);

            double getRed = 0;
            double getGreen = 0;
            double getBlue = 0;

            for (int y = 1; y < srcImage.Height - 1; y++)
            {
                for (int x = 1; x < srcImage.Width - 1; x++)
                {
                    getRed += 1 / Cv.GetReal2D(oRed, y - 1, x - 1);
                    getRed += 1 / Cv.GetReal2D(oRed, y, x - 1);
                    getRed += 1 / Cv.GetReal2D(oRed, y + 1, x - 1);
                    getRed += 1 / Cv.GetReal2D(oRed, y - 1, x);
                    getRed += 1 / Cv.GetReal2D(oRed, y, x);
                    getRed += 1 / Cv.GetReal2D(oRed, y + 1, x);
                    getRed += 1 / Cv.GetReal2D(oRed, y - 1, x + 1);
                    getRed += 1 / Cv.GetReal2D(oRed, y, x + 1);
                    getRed += 1 / Cv.GetReal2D(oRed, y + 1, x + 1);

                    getGreen += 1 / Cv.GetReal2D(oGreen, y - 1, x - 1);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y, x - 1);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y + 1, x - 1);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y - 1, x);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y, x);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y + 1, x);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y - 1, x + 1);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y, x + 1);
                    getGreen += 1 / Cv.GetReal2D(oGreen, y + 1, x + 1);

                    getBlue += 1 / Cv.GetReal2D(oBlue, y - 1, x - 1);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y, x - 1);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y + 1, x - 1);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y - 1, x);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y, x);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y + 1, x);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y - 1, x + 1);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y, x + 1);
                    getBlue += 1 / Cv.GetReal2D(oBlue, y + 1, x + 1);


                    getRed = (double) 9.0 / getRed;
                    getGreen = (double) 9.0 / getGreen;
                    getBlue = (double) 9.0 / getBlue;


                    Cv.SetReal2D(rRed, y, x, getRed);
                    Cv.SetReal2D(rGreen, y, x, getGreen);
                    Cv.SetReal2D(rBlue, y, x, getBlue);

                }
            }

            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Merge(rRed, rGreen, rBlue, null, dst);

            Cv.SaveImage("harmonicMeanImage.jpg", dst);

        }

        //good for removing salt & pepper noise
        //but not simaltaneously
        public void contraHarmonicMean(double q)
        {
            IplImage oRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage oBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            IplImage rRed = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rGreen = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);
            IplImage rBlue = Cv.CreateImage(srcImage.Size, BitDepth.U8, 1);

            Cv.Split(srcImage, oRed, oGreen, oBlue, null);

            double getRed = 0; double getRed1 = 0; double getRed2 = 0;
            double getGreen = 0; double getGreen1 = 0; double getGreen2 = 0;
            double getBlue = 0; double getBlue1 = 0; double getBlue2 = 0;

            for (int y = 1; y < srcImage.Height - 1; y++)
            {
                for (int x = 1; x < srcImage.Width - 1; x++)
                {
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y - 1, x - 1), q+1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y, x - 1), q + 1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y + 1, x - 1), q + 1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y - 1, x), q + 1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y, x), q + 1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y + 1, x), q + 1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y - 1, x + 1), q + 1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y, x + 1), q + 1);
                    getRed1 += (double) Math.Pow(Cv.GetReal2D(oRed, y + 1, x + 1), q + 1);

                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y - 1, x - 1), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y, x - 1), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y + 1, x - 1), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y - 1, x), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y, x), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y + 1, x), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y - 1, x + 1), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y, x + 1), q);
                    getRed2 += (double) Math.Pow(Cv.GetReal2D(oRed, y + 1, x + 1), q);

                    getRed = (double) getRed1 / (double) getRed2;

                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y - 1, x - 1), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y, x - 1), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y + 1, x - 1), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y - 1, x), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y, x), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y + 1, x), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y - 1, x + 1), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y, x + 1), q + 1);
                    getGreen1 += (double) Math.Pow(Cv.GetReal2D(oGreen, y + 1, x + 1), q + 1);

                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y - 1, x - 1), q);
                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y, x - 1), q);
                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y + 1, x - 1), q);
                    getGreen2 += (double )Math.Pow(Cv.GetReal2D(oGreen, y - 1, x), q);
                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y, x), q);
                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y + 1, x), q);
                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y - 1, x + 1), q);
                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y, x + 1), q);
                    getGreen2 += (double) Math.Pow(Cv.GetReal2D(oGreen, y + 1, x + 1), q);

                    getGreen = (double) getGreen1 / (double) getGreen2;

                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y - 1, x - 1), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y, x - 1), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y + 1, x - 1), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y - 1, x), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y, x), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y + 1, x), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y - 1, x + 1), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y, x + 1), q + 1);
                    getBlue1 += (double) Math.Pow(Cv.GetReal2D(oBlue, y + 1, x + 1), q + 1);

                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y - 1, x - 1), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y, x - 1), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y + 1, x - 1), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y - 1, x), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y, x), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y + 1, x), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y - 1, x + 1), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y, x + 1), q);
                    getBlue2 += (double) Math.Pow(Cv.GetReal2D(oBlue, y + 1, x + 1), q);

                    getBlue = (double) getBlue1 / (double) getBlue2;


                    Cv.SetReal2D(rRed, y, x, getRed);
                    Cv.SetReal2D(rGreen, y, x, getGreen);
                    Cv.SetReal2D(rBlue, y, x, getBlue);

                }
            }

            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Merge(rRed, rGreen, rBlue, null, dst);

            Cv.SaveImage("contraHarmonicMeanImage.jpg", dst);

        }

        //good for removing salt & pepper noise
        public void medianFilter()
        {
            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Smooth(srcImage, dst, SmoothType.Median, 3, 3);
            Cv.SaveImage("medianImage.jpg", dst);
        }

        //good for removing pepper noise
        public void maxFilter()
        {
            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Dilate(srcImage, dst, null, 1);
            Cv.SaveImage("maxImage.jpg", dst);
        }

        //good for removing salt noise
        public void minFilter()
        {
            IplImage dst = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Erode(srcImage, dst, null, 1);
            Cv.SaveImage("minImage.jpg", dst);
        }

        public void slobelOperator()
        {
            grayScale();

            IplImage slobelX = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);
            IplImage slobelY = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);

            //create temp images
            IplImage tempX = Cv.CreateImage(grayImage.Size, BitDepth.S16, 1);
            IplImage tempY = Cv.CreateImage(grayImage.Size, BitDepth.S16, 1);

            //slobel in x direction
            Cv.Sobel(grayImage, tempX, 1, 0, ApertureSize.Size3);

            //slobel in y direction
            Cv.Sobel(grayImage, tempY, 0, 1, ApertureSize.Size3);

            //convert signed to unsigned
            Cv.ConvertScaleAbs(tempX, slobelX);
            Cv.ConvertScaleAbs(tempY, slobelY);

            Cv.SaveImage("sx.jpg", slobelX);
            Cv.SaveImage("sy.jpg", slobelY);

        }

        public void laplacianOperator()
        {
            grayScale();

            IplImage laplace = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);

            IplImage temp = Cv.CreateImage(grayImage.Size, BitDepth.S16, 1);

            Cv.Laplace(grayImage, temp, ApertureSize.Size3);
            Cv.ConvertScaleAbs(temp, laplace);

            Cv.SaveImage("laplace.jpg", laplace);
        }

        public void laplacianWithoutNoiseOperator()
        {
            grayScale();

            //to remove Gaussian noise
            Cv.Smooth(grayImage, grayImage, SmoothType.Gaussian);

            IplImage laplace = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);

            IplImage temp = Cv.CreateImage(grayImage.Size, BitDepth.S16, 1);

            Cv.Laplace(grayImage, temp, ApertureSize.Size3);
            Cv.ConvertScaleAbs(temp, laplace);

            Cv.SaveImage("laplaceWithoutNoise.jpg", laplace);
        }

    }
}
