using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestingAssignment1;

namespace UnitTesting
{
    [TestFixture]
    public class TestCases
    {
        [TestCase]
        //Testing Equilateral triangle
        public void TestEquilateral()
        {
            Assert.AreEqual("Equilateral Triangle", TriangleSolver.Analyze(1, 1, 1));
        }
        //Testing Isosceles triangle
        [TestCase]
        public void TestIsosceles()
        {
            Assert.AreEqual("Isosceles Triangle", TriangleSolver.Analyze(3,3,2));
        }
        //Testing Scalene triangle
        [TestCase]
        public void TestScalene()
        {
            Assert.AreEqual("Scalene Triangle", TriangleSolver.Analyze(3,4,5));
        }
        //Testing Not a Triangle 
        [TestCase]
        public void TestNotATriangle()
        {
            Assert.AreEqual("Not a Triangle", TriangleSolver.Analyze(-1,1,0));
        }
        //Testing Not a Triangle
        [TestCase]
        public void TestZeros()
        {
            Assert.AreEqual("Not a Triangle", TriangleSolver.Analyze(0,0,0));
        }
        //Testing Not a Triangle
        [TestCase]
        public void TestNegativeAllValues()
        {
            Assert.AreEqual("Not a Triangle", TriangleSolver.Analyze(-1,-9,-7));
        }
        //Testing Not a Triangle
        [TestCase]
        public void TestOneNegativeValue()
        {
            Assert.AreEqual("Not a Triangle", TriangleSolver.Analyze(-21, 0, 3));
        }
        //Testing Not a Triangle
        [TestCase]
        public void TestTwoNegativeValues()
        {
            Assert.AreEqual("Not a Triangle", TriangleSolver.Analyze(-3,-2, 8));
        }
    }
}
