using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//m228724
//Golovinov Timur
//21/05/2019
//Version 1.0
//This library is designed to perform some algebra functions
namespace Algebra
{
    public class Algebra
    {
        //Square Root
        public static double Sqrt(double d)
        {
            double root = 1;
            int i = 0;
            //The Babylonian Method for Computing Square Roots
            while (true)
            {
                i = i + 1;
                root = (d / root + root) / 2;
                if (i == d + 1)
                {
                    break;
                }
            }
            return root;
        }
        //Cube Root
        // Returns cube root of a no. n 
        public static double CubicRoot(double n)
        {
            double i, precision = 0.000001;

            for (i = 1; (i * i * i) <= n; ++i) ;         //Integer part

            for (--i; (i * i * i) < n; i += precision) ;  //Fractional part

            return i;
        }

        //Inverse
        public static int Inverse(int a)
        {
            return a = a * -1;
        }
    }
}
