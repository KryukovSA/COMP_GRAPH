using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class GrayScaleFiltres : Filtres
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y); // получение цвета исходного пикселя
             double Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
        Color resultColor = Color.FromArgb((int)(Intensity),
                                           (int)(Intensity),
                                           (int)(Intensity));
            return resultColor;
        }
    }
}
