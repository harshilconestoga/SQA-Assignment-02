using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_calculator
{
    static class TriangleSolver
    {
        
        private static int side1, side2, side3;
        private static string demo;


        public static int Side1
        {
            get { return side1; }
            set { side1 = value; }
        }

        public static int Side2
        {
            get { return side2; }
            set { side2 = value; }
        }

        public static int Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

        public static string Analyze(int x, int y, int z) {
            Side1 = x;
            Side2 = y;
            Side3 = z;
            if (x == y && y == z)
            {
                demo = "It is an equilateral triangle";
            }
            else if (x==y || x==z || y==z)
            {
                demo = "It is an isoceles triangle";
            }
            else
            {
                demo = "It is a scalene triangle";
            }
            return demo;
        }
    }
}
