using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Dilation : MatrixFilter
    {
       // public void creatDilation(int radius)//unsafe
        //{
        //    int size = 2 * radius + 1;
        //    kernel = new float[size, size];
        //    for (int i = -radius; i <= radius; i++)
        //    {
        //        for (int j = -radius; j <= radius; j++)
        //        {
        //            bool flag = true;
        //            for (int zi = Math.Max(i - 1, 0); zi <= Math.Min(i + 1, radius - 1); zi++)
        //            {
        //                for (int zj = Math.Max(i - 1, 0); zj <= Math.Min(i + 1, radius - 1); zj++)
        //                    if ((!(zi == i && zj == j)) && (kernel[zi, zj] == 0))
        //                        flag = false;
        //            }



        //            if (flag)
        //                kernel[i, j] = 255;
        //            else
        //                kernel[i, j] = 0;
        //        }


        //    }
        // }


        //public Dilation()
        //{
        //    creatDilation(3);
        //}

        public Dilation()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];


            kernel[0, 0] = 0;
            kernel[0, 1] = 1;
            kernel[0, 2] = 0;
            kernel[1, 0] = 1;
            kernel[1, 1] = 1;
            kernel[1, 2] = 1;
            kernel[2, 0] = 0;
            kernel[2, 1] = 1;
            kernel[2, 2] = 0;



        }
    }
}
