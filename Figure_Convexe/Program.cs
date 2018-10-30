using System;

namespace Figure_Convexe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] image = {
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 0},
                {0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            };
        }

        /*
        * @pre image != null
        * image only contains 0’s and 1’s and the set of 1’s is a convex image
        * @post The returned value contains the area of the image as the number of pixels
        */
        public static int GetArea(int[,] image)
        {
            int count = 0;
            foreach (int elem in image)
            {
                count += elem;
            }
            return count;
        }

        public static int[,] GetBoundary(int[,] image)
        {
            return null;
        }
    }
}
