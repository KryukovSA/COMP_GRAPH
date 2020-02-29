using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class SepiyaFiltres : Filtres
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y); // получение цвета исходного пикселя
            double Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
            double k = 100;

            Color resultColor = Color.FromArgb(Clamp((int)(Intensity + 2 * k), 0, 255),
                                               Clamp((int)(Intensity + 0.5 * k), 0, 255),
                                               Clamp((int)(Intensity - 1 * k), 0, 255));

            return resultColor;


        }
    }
}
