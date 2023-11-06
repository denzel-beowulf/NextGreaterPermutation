using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PermutationTests
{


    [TestClass]
    public class PermutationTests
    {
        [TestMethod]
        public void ArrayLengthTest()
        {
            //Arrange
            int[] nums = { 1, 5, 8, 4, 7, 6, 5, 3, 1 };
            var real = string.Empty;
            var expected = "Good";

            //Act
            if (1 > nums.Length || nums.Length > 100)
                real = "Bad";
            else 
                real = "Good";

            //Assert
            Assert.AreEqual(expected, real, "The Array Length is incorrect.");
        }

        [TestMethod]
        public void TestPermutationSortedArray()
        {
            //Arrange
            int[] nums = { 8, 5, 3, 1};
            int[] expected = { 1, 3, 5, 8 };

            //Act

            //Assert
            //Assert.AreEqual(expected, , "The Array Length is incorrect.");

        }
    }
}