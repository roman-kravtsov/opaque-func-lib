﻿using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            double mx;
            double X1 = CL00_58_1_arctg_arcctg.Body(1);
            mx = X1;
            double X2 = CL00_58_1_arctg_arcctg.Body(0.53);
            if (X2 > mx) mx = X2;
            double X3 = CL00_58_1_arctg_arcctg.Body(0.0001);
            if (X3 > mx) mx = X3;
            double X4 = CL00_58_1_arctg_arcctg.Body(360);
            if (X4 > mx) mx = X4;
            double X5 = CL00_58_1_arctg_arcctg.Body(1547.547921);
            if (X5 > mx) mx = X5;
            double X6 = CL00_58_1_arctg_arcctg.Body(12);
            if (X6 > mx) mx = X6;
            double X7 = CL00_58_1_arctg_arcctg.Body(6641);
            if (X7 > mx) mx = X7;
            double X8 = CL00_58_1_arctg_arcctg.Body(0.00000614);
            if (X8 > mx) mx = X8;
            double X9 = CL00_58_1_arctg_arcctg.Body(897);
            if (X9 > mx) mx = X9;
            double X10 = CL00_58_1_arctg_arcctg.Body(92);
            if (X10 > mx) mx = X10;

            double mid = (X1 + X2 + X3 + X4 + X5 + X6 + X7 + X8 + X9 + X10) / 10;
            Console.WriteLine(mx);
            Console.ReadKey();
        }
    }
}
