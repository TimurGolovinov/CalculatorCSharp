using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//m228724
//Golovinov Timur
//21/05/2019
//Version 1.0
//This library is designed to perform simple arithmetic functions
namespace BasicMath
{
    public class Arithmetic
    {
        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static int Sub(int a, int b)
        {
            return (a - b);
        }
        public static double Div(int a, int b)
        {
            return ((double)a / b);
        }
        public static int Mult(int a, int b)
        {
            return (a * b);
        }
    }
}
