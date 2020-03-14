using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    class Autolevels : Filtres
    {
      
        public override Bitmap processImage(Bitmap sourceImage, System.ComponentModel.BackgroundWorker worker)//Bitmap sourceImage, System.ComponentModel.BackgroundWorker backgroundWorker1
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            float min_yR = 255, min_yB = 255, min_yG = 255, max_yR = 0, max_yG = 0, max_yB = 0;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    if (sourceImage.GetPixel(i, j).R < min_yR)
                    {
                        min_yR = sourceImage.GetPixel(i, j).R;
                    }
                    if (sourceImage.GetPixel(i, j).B < min_yB)
                    {
                        min_yB = sourceImage.GetPixel(i, j).B;
                    }
                    if (sourceImage.GetPixel(i, j).R < min_yG)
                    {
                        min_yG = sourceImage.GetPixel(i, j).R;
                    }

                    if (sourceImage.GetPixel(i, j).R > max_yR)
                    {
                        max_yR = sourceImage.GetPixel(i, j).R;
                    }
                    if (sourceImage.GetPixel(i, j).G > max_yG)
                    {
                        max_yG = sourceImage.GetPixel(i, j).G;
                    }
                    if (sourceImage.GetPixel(i, j).B > max_yB)
                    {
                        max_yB = sourceImage.GetPixel(i, j).B;
                    }
                }
            }


            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color color = Color.FromArgb(
                         Clamp((int)((sourceImage.GetPixel(i, j).R - min_yR) * 255 / (max_yR - min_yR)), 0, 255),
                         Clamp((int)((sourceImage.GetPixel(i, j).G - min_yG) * 255 / (max_yG - min_yG)), 0, 255),
                         Clamp((int)((sourceImage.GetPixel(i, j).B - min_yB) * 255 / (max_yB - min_yB)), 0, 255));
                    resultImage.SetPixel(i, j, color);
                }
            }


            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            return new Color();
        }

    }
}
