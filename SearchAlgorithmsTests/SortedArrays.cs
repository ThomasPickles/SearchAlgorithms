using NUnit.Framework;
using SearchAlgorithms;

namespace SearchAlgorithmsTests
{
    public class SortedArrays
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindElement_ShouldReturnCorrectId()
        {
            Assert.AreEqual(4, SortedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11 }, 8)); // even length
            Assert.AreEqual(-1, SortedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11 }, 7)); // not there
            Assert.AreEqual(-1, SortedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11 }, 12)); // outside bounds
            Assert.AreEqual(4, SortedArray.FindElement(new[] { 1, 2, 5, 6, 8, 9, 10, 11, 12 }, 8)); // odd length
        }
    }
}