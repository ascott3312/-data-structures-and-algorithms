using System;
using Challenges.Arrays;
using Xunit;


namespace Challenges.Test.ArraysTest

{
    public class ArraysTest
    {
        [Fact]
        public static void CanReverseArrayTest()

        {
            //Arrange
                int[] arrayToReverse = new[] { 1, 2, 3, 4, 5 };

            //Act

                int[] reversed = Reverse.ReverseArray(arrayToReverse);

            //Assert

                Assert.Equal(new int[] {5, 4, 3, 2, 1 }, reversed);
            }
        
    }
}
