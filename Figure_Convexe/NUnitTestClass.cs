using NUnit.Framework;
using System;
namespace Figure_Convexe
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void TestGetArea()
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

            int[,] Boundary = {
                {-1, 2, 1, 1, 2, 2, 3, -1},
                {-1, 4, 5, 5, 5, 4, 4, -1}
            };

            Assert.AreEqual(22, MainClass.GetArea(image));
        }
    }
}
