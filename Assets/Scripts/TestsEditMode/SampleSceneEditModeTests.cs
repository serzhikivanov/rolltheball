using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace Tests
{
    [TestFixture]
    public class SampleSceneTestScript
    {
        TestTargetScript _sut;

        [SetUp]
        public void Setup() 
        {
            _sut = new TestTargetScript();
        }

        // A Test behaves as an ordinary method
        [TestCase(0, 0)]
        [TestCase(100, 100)]
        [TestCase(1000, 1000)]
        [TestCase(9999, -1)]
        public void MethodOne_ValidParameterPassed_CorrectValueReturned(int param, int expectedResult)
        {
            // Arrange

            // Act
            var ret = _sut.MethodOne(param);

            // Assert
            Assert.AreEqual(ret, expectedResult, $"Method 'MethodOne' returned unexpected value. Expected: {expectedResult}, actual: {ret}");
        }

        // A Test behaves as an ordinary method
        [Test]
        public void MethodOne_InvalidParameterPassed_ExceptionThrown()
        {
            // Arrange
            void localTestMethod() 
            {
                _sut.MethodOne(-1);
            }

            // Act

            // Assert
            Assert.Throws<ArgumentException>(localTestMethod, "SUT method didn't throw an ArgumentException an invalid parameter");
        }
    }
}
