using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using System.Security.Policy;

namespace TriangleSolver.Tests
{
    [TestFixture]
    public class TriangleTests
    {

        // Test 1:  Equilateral triangle
        [Test]
        public void IdentifyTriangle_EquilateralTriangle_ReturnsTriangle()
        {

            int firstSide = 4;
            int secondSide = 4;
            int thirdSide = 4;

            string expected = "Equilateral triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }



    }
}