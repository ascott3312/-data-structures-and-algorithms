using System;

namespace Challenges
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] arrayToReverse = new[] { 1, 2, 3, 4, 5 };
            int[] reversed = ReverseArray(arrayToReverse);
            Console.WriteLine(String.Join(",", reversed));
        }
        public static int[] ReverseArray(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 1; i < array.Length + 1; i++)
            {
                result[i-1] = array[array.Length - i];
            }

            return result;
        }
    } 
}
