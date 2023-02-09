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
        [Test]
        // Only one (1) test for a valid equilateral triangle
        public void AnalyzeTriangle_EquilateralCheck_Valid()
        {
            string actual; 
            string expected;
            expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            Triangle t1 = new Triangle();
            actual = t1.AnalyzeTriangle(4, 4, 4); //Act

            Assert.AreEqual(expected, actual); //Assert
        }
    }
}
