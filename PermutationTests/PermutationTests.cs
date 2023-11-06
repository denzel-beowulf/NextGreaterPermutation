using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextGreaterPermutation;


namespace PermutationTests
{


    [TestClass]
    public class PermutationTests
    {
        [TestMethod]
        public void ArrayLengthTest()
        {
            //Arrange
            Permutation perm = new Permutation();
            int[] nums = { 1, 5, 8, 4, 7, 6, 5, 3, 1 };

            //Act and Assert
            Assert.IsTrue(perm.CheckArrayLength(nums), "The Array Length is incorrect.");
        }
        
        [TestMethod]
        public void ArrayItemsTest()
        {
            //Arrange
            Permutation perm = new Permutation();
            int[] nums = { 1, 5, 8, 85, 78, 6, 5, 65, 1, 15, 7 };

            //Act and Assert
            Assert.IsTrue(perm.CheckArrayItems(nums), "At least one item is out of permissible range.");
        }

        [TestMethod]
        public void TestPermutation1()
        {
            //Arrange
            Permutation perm = new Permutation();
            int[] nums = { 1, 2, 3};
            int[] expected = { 1, 3, 2};

            //Act
            perm.NextPermutation(nums);

            //Assert
            CollectionAssert.AreEqual(expected, nums, "The permutation failed.");

        }

        [TestMethod]
        public void TestPermutation2()
        {
            //Arrange
            Permutation perm = new Permutation();
            int[] nums = { 3, 2, 1};
            int[] expected = { 1, 2, 3};

            //Act
            perm.NextPermutation(nums);

            //Assert
            CollectionAssert.AreEqual(expected, nums, "The permutation failed.");

        }
        [TestMethod]
        public void TestPermutation3()
        {
            //Arrange
            Permutation perm = new Permutation();
            int[] nums = { 1, 1, 5};
            int[] expected = { 1, 5, 1};

            //Act
            perm.NextPermutation(nums);

            //Assert
            CollectionAssert.AreEqual(expected, nums, "The permutation failed.");

        }
    }
}