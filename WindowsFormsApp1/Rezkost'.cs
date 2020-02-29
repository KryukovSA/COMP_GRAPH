﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rezkost_ : MatrixFilter
    {
        public Rezkost_()
        { 
        int sizeX = 3;
        int sizeY = 3;
        kernel = new float[sizeX, sizeY];

       
                kernel[0, 0] = 0;
                kernel[0, 1] = -1;
                kernel[0, 2] = 0;
                kernel[1, 0] = -1;
                kernel[1, 1] = 5;
                kernel[1, 2] = -1;
                kernel[2, 0] = 0;
                kernel[2, 1] = -1;
                kernel[2, 2] = 0;

            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)  //нормировка
                {
                    kernel[i, j] += 255;
                    kernel[i, j] /= 2;
                }
        }
    }
}