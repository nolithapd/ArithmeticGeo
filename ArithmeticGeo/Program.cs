using System;

namespace ArithmeticGeo
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] testArray = { 1, 2, 3, 5 };
            string arthGeoResults = ArithGeo(testArray);
            Console.WriteLine(arthGeoResults);
        }

        /**
         * Have the function arithGeo(arr) take the array of numbers stored in arr and
         * return the string "Arithmetic" if the sequence follows an arithmetic pattern
         * or return "Geometric" if it follows a geometric pattern. If the sequence
         * doesn't follow either pattern return -1. An arithmetic sequence is one where
         * the difference between each of the numbers is consistent, where as in a
         * geometric sequence, each term after the first is multiplied by some constant
         * or common ratio. Arithmetic example: [2, 4, 6, 8] and Geometric example: [2,
         * 6, 18, 54]. Negative numbers may be entered as parameters, 0 will not be
         * entered, and no array will contain all the same elements.
         */
        public static string ArithGeo(int [] testAray)
        {
            string results = "-1";
            bool arithmetic = true, geometric = true;
            if (testAray.Length == 1 || testAray.Length == 0)
            {
                return results;
            }

            for (int x = 2, diff = testAray[1] - testAray[0]; x < testAray.Length; x++)
            {
                if (testAray[x] - testAray[x - 1] != diff)
                {
                    arithmetic = false;
                }
            }
            if (arithmetic)
            {
                return "Arithmetic";
            }
          
        
            for (int i = 2, divisor = testAray[1] / testAray[0]; i < testAray.Length; i++)
            {
                if (testAray[i] / testAray[i - 1] != divisor)
                {
                    geometric = false;
                }
            }

            if (geometric)
            {
                return "Geometric";
            }

            return results;

        }
    }
}
