using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Turn : Filtres
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            double angle = 0.2;
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2;
            int x = (int)((i - x0) * Math.Cos(angle) - (j - y0) * Math.Sin(angle) + x0);
            int y = (int)((i - x0) * Math.Sin(angle) + (j - y0) * Math.Cos(angle) + y0);
            Color resultColor = sourceImage.GetPixel(Clamp(x, 0, sourceImage.Width - 1), Clamp(y, 0, sourceImage.Height - 1));
            return resultColor;


        }
    }
}
