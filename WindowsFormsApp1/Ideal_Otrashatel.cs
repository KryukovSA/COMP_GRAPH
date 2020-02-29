using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Ideal_Otrashatel : Filtres
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double maxsourseColorR = 0;
            double maxsourseColorG = 0;
            double maxsourseColorB = 0;
            Color sourceColor = sourceImage.GetPixel(x, y); // получение цвета исходного пикселя

            if (sourceColor.R > maxsourseColorR)
                maxsourseColorR = sourceColor.R;
            if (sourceColor.G > maxsourseColorG)
                maxsourseColorG = sourceColor.G;
            if (sourceColor.B > maxsourseColorB)
                maxsourseColorB = sourceColor.B;
            Color resultColor = Color.FromArgb(Clamp((int)(sourceColor.R *255 / maxsourseColorR), 0, 255),
                                               Clamp((int)(sourceColor.G * 255 / maxsourseColorG), 0, 255),
                                               Clamp((int)(sourceColor.B * 255 / maxsourseColorB), 0, 255));
            return resultColor;
        }
    }
}
