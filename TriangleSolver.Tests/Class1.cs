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

        // Test 2: Isosceles triangle 
        [Test]
        public void IdentifyTriangle_IsoscelesTriangle_ReturnsIsosceles_1()
        {
            int firstSide = 4;
            int secondSide = 6;
            int thirdSide = 4;

            string expected = "Isosceles triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }

        // Test 3: Isosceles triangle
        [Test]
        public void IdentifyTriangle_IsoscelesTriangle_ReturnsIsosceles_2()
        {
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 7;

            string expected = "Isosceles triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }

        // Test 4: Isosceles triangle
        [Test]
        public void IdentifyTriangle_IsoscelesTriangle_ReturnsIsosceles_3()
        {
            int firstSide = 5;
            int secondSide = 2;
            int thirdSide = 5;

            string expected = "Isosceles triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }


        //-	Five (5) tests for a valid scalene triangle


        // Test 5: Scalene triangle
        [Test]
        public void IdentifyTriangle_ScaleneTriangle_ReturnsScalene_1()
        {
            int firstSide = 5;
            int secondSide = 8;
            int thirdSide = 10;

            string expected = "Scalene triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }

        // Test 6: Scalene triangle
        [Test]
        public void IdentifyTriangle_ScaleneTriangle_ReturnsScalene_2()
        {

            int firstSide = 999;
            int secondSide = 1000;
            int thirdSide = 1002;

            string expected = "Scalene triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }
        // Test 7: Scalene triangle
        [Test]
        public void IdentifyTriangle_ScaleneTriangle_ReturnsScalene_3()
        {
            int firstSide = 5;
            int secondSide = 2;
            int thirdSide = 4;

            string expected = "Scalene triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }
        // Test 8: Scalene triangle
        [Test]
        public void IdentifyTriangle_ScaleneTriangle_ReturnsScalene_4()
        {
            int firstSide = 20;
            int secondSide = 13;
            int thirdSide = 26;

            string expected = "Scalene triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }
        // Test 9: Scalene triangle
        [Test]
        public void IdentifyTriangle_ScaleneTriangle_ReturnsScalene_5()
        {
            int firstSide = 90;
            int secondSide = 4;
            int thirdSide = 93;

            string expected = "Scalene triangle";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }

    }
}