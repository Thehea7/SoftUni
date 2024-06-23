using System.Diagnostics.CodeAnalysis;

namespace Database.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16)]
        [TestCase (1,2,3,4,5,6,7,8)]
        [TestCase (-1,-2,-3,-4,-5,-6,-7,-8)]
        [TestCase (0)]
        public void WhenCreatingAnInstance_ArrayLenghtShouldBe16(params int[] input)
        {
            Database database = new Database (input);
            int actualArrayCount = database.Fetch().Length;

            Assert.AreEqual(16, actualArrayCount);
        }
    }
}
