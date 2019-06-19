using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Triangle_calculator;

namespace Triangle_Unit_Testing
{
    [TestFixture]
    public class Triangle_unit_Testing
    {
        [Test]
        public void Test_Equilateral() //Testing Equilateral triangle
        {
            int l = 3, w = 3, r = 3;
            String a = "equilateral";
            String d = TriangleSolver.Analyze(l,w,r);
            StringAssert.Contains(a,d);
        }

        [Test]
        public void Test_Isoceles() //Testing Isoceles triangle
        {
            int l = 3, w = 3, r = 2;
            String a = "isoceles";
            String d = TriangleSolver.Analyze(l, w, r);
            StringAssert.Contains(a, d);
        }

        [Test]
        public void Test_Scalene() //Testing Scalene triangle
        {
            int l = 3, w = 4, r = 5;
            String a = "scalene";
            String d = TriangleSolver.Analyze(l, w, r);
            StringAssert.Contains(a, d);
        }

        [Test]
        public void Test_Triangle_invalidation() //Testing if triangle can form
        {
            int l = 1, w = 3, r = 25;
            String a = "invalid";
            String d = TriangleSolver.Analyze(l, w, r);
            StringAssert.Contains(a, d);
        }

        [Test]
        public void Test_Triangle_validation() //Testing if triangle can form
        {
            int l = 3, w = 4, r = 5;
            String a = "valid";
            String d = TriangleSolver.Analyze(l, w, r);
            StringAssert.Contains(a, d);
        }

        [Test]
        public void Test_Zero_input() //Testing zero input
        {
            int l = 0, w = 3, r = 5;
            String a = "invalid";
            String d = TriangleSolver.Analyze(l, w, r);
            StringAssert.Contains(a, d);
        }

        [Test]
        public void Test_Negative_input() //Testing negative input
        {
            int l = -1, w = 3, r = 5;
            String a = "invalid";
            String d = TriangleSolver.Analyze(l, w, r);
            StringAssert.Contains(a, d);
        }

        [Test]
        public void Test_Side_validation() //Testing if side is stored and retrieved properly
        {
            int l = 1, w = 3, r = 25;
            TriangleSolver.Analyze(l, w, r);
            int side1 = TriangleSolver.Side1;
            Assert.AreEqual(side1, l);
        }

    }
}
