using System;

namespace Figures
{
    public class Circle
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new Exception("Radius cannot be negative or null");
            }
        }
        public double ComputeArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle
    {
        private double FirstSide { get; set; }
        private double SecondSide { get; set; }
        private double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0
                    && secondSide <= 0
                    && thirdSide <= 0)
            {
                throw new Exception("Side value cannot be negative");
            }
            else if (firstSide + secondSide < thirdSide
                        && secondSide + thirdSide < firstSide
                        && firstSide + thirdSide < secondSide)
            {
                throw new Exception("There is no triangle with such sides");
            }
            else
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }
        }

        public double ComputeArea()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2; //semi-perimeter
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
    }
    
}
