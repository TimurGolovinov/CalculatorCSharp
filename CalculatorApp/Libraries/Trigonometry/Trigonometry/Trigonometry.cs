using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//m228724
//Golovinov Timur
//21/05/2019
//Version 1.0
//This library is designed to perform some trigonometric functions using Math library
namespace Trigonometry
{
    public class Trigonometry
    {
        //Tan
        public static double Tan(double a)
        {
            return Math.Tan(a);
        }

        //Sine
        public static double Sine(double a)
        {
            return Math.Sin(a);
        }

        //Cosine
        public static double Cosine(double a)
        {
            return Math.Cos(a);
        }
    }
}
