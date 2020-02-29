using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Wave2 : Filtres
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {

            int x = (int)(i + 20 * Math.Sin(2 * Math.PI * i / 30));
            int y = j;
            Color resultColor = sourceImage.GetPixel(Clamp(x, 0, sourceImage.Width - 1), Clamp(y, 0, sourceImage.Height - 1));
            return resultColor;
        }



    }
}
