using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTesting
{
    [TestFixture]
    public class Class1
    {
        // Only one (1) test for a valid equilateral triangle

        [Test]
        
        public void AnalyzeTriangle_EquilateralCheck_Valid()
        {
            string actual; 
            string expected;
            expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(4, 4, 4); //Act
            Assert.AreEqual(expected, actual); //Assert
        }

        // Three (3) tests for a valid isosceles triangle

        [Test]
        public void AnalyzeTriangle_IsoscelesCheck_Valid1()
        {
            string actual;
            string expected;
            expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(6, 4, 6); //Act
            Assert.AreEqual(expected, actual); //Assert
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesCheck_Valid2()
        {
            string actual;
            string expected;
            expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(6, 6, 4); //Act
            Assert.AreEqual(expected, actual); //Assert
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesCheck_Valid3()
        {
            string actual;
            string expected;
            expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(4, 6, 6); //Act
            Assert.AreEqual(expected, actual); //Assert
        }

        // Five (5) tests for a valid scalene triangle

        [Test]
        public void AnalyzeTriangle_ScaleneCheck_Valid1()
        {
            string actual;
            string expected;
            expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(6, 4, 5); //Act
            Assert.AreEqual(expected, actual); //Assert
        }

        [Test]
        public void AnalyzeTriangle_ScaleneCheck_Valid2()
        {
            string actual;
            string expected;
            expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(5, 6, 7); //Act
            Assert.AreEqual(expected, actual); //Assert
        }

        [Test]
        public void AnalyzeTriangle_ScaleneCheck_Valid3()
        {
            string actual;
            string expected;
            expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(5, 6, 2); //Act
            Assert.AreEqual(expected, actual); //Assert
        }


        [Test]
        public void AnalyzeTriangle_ScaleneCheck_Valid4()
        {
            string actual;
            string expected;
            expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(7, 6, 3); //Act
            Assert.AreEqual(expected, actual); //Assert
        }


        [Test]
        public void AnalyzeTriangle_ScaleneCheck_Valid5()
        {
            string actual;
            string expected;
            expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(5, 6, 3); //Act
            Assert.AreEqual(expected, actual); //Assert
        }
    }
}
