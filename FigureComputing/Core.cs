using Figures;
namespace FiguresComputing
{
    public class FigureAreaComputing
    {
        //Circle
        public static double Compute(double radius)
        {

            Circle circle = new Circle(radius);
            return circle.ComputeArea();
        }

        //Triangle
        public static double Compute(double firstSide, double secondSide, double thirdSide)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            return triangle.ComputeArea();
        }

        public static bool IsRectangular(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide)
                || (firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide)
                || (thirdSide * thirdSide + secondSide * secondSide == firstSide * firstSide))
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
