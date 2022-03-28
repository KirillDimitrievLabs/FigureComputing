using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresComputing;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Circle
        [TestMethod]
        public void Compute_Circle_InvalidInput_NegativeRadius()
        {
            // Arrange
            double radius = -999;
            string expected = "Radius cannot be negative or null";
            //act
            try
            {
                FigureAreaComputing.Compute(radius);
            }
            catch (System.Exception e)
            {
                //Assert   
                StringAssert.Contains(e.Message, expected);
            }
        }

        [TestMethod]
        public void Compute_Circle_ValidInput()
        {
            // Arrange
            double radius = 5;
            double expected = 78.53981633974483;
            //act

            double actual = FigureAreaComputing.Compute(radius);
            //assert

            Assert.AreEqual(expected, actual);

        }
        //Triangle
        [TestMethod]
        public void Compute_Triangle_InvalidInput_NegativeSide()
        {
            // Arrange
            double Side1 = -54;
            double Side2 = 5;
            double Side3 = 7;
            string expected = "Side value cannot be negative";

            //act
            try
            {
                FigureAreaComputing.Compute(Side1, Side2, Side3);
            }
            catch (System.Exception e)
            {
                //Assert   
                StringAssert.Contains(e.Message, expected);
            }
        }
        [TestMethod]
        public void Compute_Triangle_InvalidInput_DegenerateTriangle()
        {
            // Arrange
            double Side1 = 1;
            double Side2 = 2;
            double Side3 = 3;
            string expected = "There is no triangle with such sides";

            //act
            try
            {
                FigureAreaComputing.Compute(Side1, Side2, Side3);
            }
            catch (System.Exception e)
            {
                //Assert   
                StringAssert.Contains(e.Message, expected);
            }
        }
        [TestMethod]
        public void Compute_Triangle_ValidInput()
        {
            // Arrange
            double Side1 = 8;
            double Side2 = 12;
            double Side3 = 5;
            double expected = 14.523687548277813;

            //act
            double actual = FigureAreaComputing.Compute(Side1, Side2, Side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Compute_Triangle_ValidInput_IsRectangular()
        {
            // Arrange
            double Side1 = 4;
            double Side2 = 5;
            double Side3 = 3;
            bool expected = true;

            //act
            bool actual = FigureAreaComputing.IsRectangular(Side1, Side2, Side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
