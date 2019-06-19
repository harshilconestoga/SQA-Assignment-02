using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_calculator
{
    public static class TriangleSolver
    {
        
        private static int side1, side2, side3;
        private static string ping;

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
            ping = "You have an invalid triangle";
            if (side1 > 0 && side2 > 0 && side3 > 0)
            { 
                if (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2) //Valid triangle checking
                {
                    ping = "You have a valid triangle\n";
                    if (x == y && y == z) //Checking for equality of all sides
                    {
                        ping += "It is an equilateral triangle";
                    }
                    else if (x == y || x == z || y == z) //Checking if 2 sides are same
                    {
                        ping += "It is an isoceles triangle";
                    }
                    else //Declare triangle as Scalene if all fails
                    {
                        ping += "It is a scalene triangle";
                    }
                }
            }
            return ping;
        }
    }
}
