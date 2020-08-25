using System;


namespace Challenges.Test.ArraysTest

{
    public class ArraysTest
    {
        public ArraysTest()
        {
                int[] arrayToReverse = new[] { 1, 2, 3, 4, 5 };
                int[] reversed = ReverseArray(arrayToReverse);
                Console.WriteLine(String.Join(",", reversed));
            }
        
    }
}
