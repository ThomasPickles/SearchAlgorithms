using NUnit.Framework;
using SearchAlgorithms;

namespace SearchAlgorithmsTests
{
    public class RotatedArrays
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RotatedArrays_FindElement_ShouldReturnCorrectId()
        {
            // Should work without rotation (rotation could be on last element)
            Assert.AreEqual(4, RotatedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11 }, 8)); // even length
            Assert.AreEqual(-1, RotatedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11 }, 7)); // not there
            Assert.AreEqual(-1, RotatedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11 }, 12)); // outside bounds
            Assert.AreEqual(4, RotatedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11, 12 }, 8)); // odd length

            // Rotation
            Assert.AreEqual(7, RotatedArray.FindElement(new[] { 10, 11, 1, 2, 5, 6, 8, 9 }, 8)); // even length
            Assert.AreEqual(-1, RotatedArray.FindElement(new[] { 10, 11, 1, 2, 5, 6, 8, 9 }, 7)); // not there
            Assert.AreEqual(-1, RotatedArray.FindElement(new[] { 10, 11, 1, 2, 5, 6, 8, 9 }, 12)); // outside bounds
            Assert.AreEqual(8, RotatedArray.FindElement(new[] { 10, 11, 12, 1, 2, 5, 6, 8, 9 }, 8)); // odd length

            // Tests to include 
            Assert.AreEqual(1, RotatedArray.FindElement(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1)); // odd length
        }
    }
}