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

        // -	Three(3) tests for verifying a zero length for one or more sides
        //Test 10
        [Test]
        public void IdentifyTriangle_ZeroLengthSide_ReturnsZero_deected_1()
        {

            int firstSide = 0;
            int secondSide = 5;
            int thirdSide = 7;

            string expected = "Invalid Triangle - a zero has been detected";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);

        }

        //Test 11
        [Test]
        public void IdentifyTriangle_ZeroLengthSide_ReturnsZero_Detected_2()
        {

            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 7;

            string expected = "Invalid Triangle - a zero has been detected";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);

        }

        //Test 12
        [Test]
        public void IdentifyTriangle_ZeroLengthSide_ReturnsZero_Detected_3()
        {

            int firstSide = 10;
            int secondSide = 5;
            int thirdSide = 0;

            string expected = "Invalid Triangle - a zero has been detected";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);

        }

        //-	Three (3) tests for verifying an invalid response (other than a zero length)

        // Test 13 - Invalid triangle
        [Test]
        public void IdentifyInvalidTriangle_ReturnInvalid_1()
        {
            int firstSide = 8;
            int secondSide = 4;
            int thirdSide = 3;

            string expected = "INVALID!!";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }

        //Test 14 Invalid triangle
        [Test]
        public void IdentifyInvalidTriangle_ReturnInvalid_2()
        {
            int firstSide = 9;
            int secondSide = 3;
            int thirdSide = 6;

            string expected = "INVALID!!";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }

        //Test 15 Invalid triangle
        [Test]
        public void IdentifyInvalidTriangle_ReturnInvalid_3()
        {
            int firstSide = 7;
            int secondSide = 2;
            int thirdSide = 4;

            string expected = "INVALID!!";
            var actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            Assert.AreEqual(expected, actual);
        }

    }
}