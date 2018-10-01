using System;

namespace FiguresArea.Figure
{
    public class Triangle
    {
        private double FirstSide { get; set; }
        private double SecondSide { get; set; }
        private double ThirdSide { get; set; }
        private double Tolerance { get; set; } //погрешность, для определения прямоугольного треугольника

        public Triangle(double tolerance = 0.05)
        {
            Tolerance = tolerance;
            FirstSide = SecondSide = ThirdSide = 0;
        }

        public Triangle(double firstSide, double secondSide, double thirdSide, double tolerance = 0.05)
        {
            Tolerance = tolerance; 
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double Area
        {
            get
            {
                // Формула Герона S=root(p(p−a)(p−b)(p−c))
                double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) 
                                               * (halfPerimeter - SecondSide) 
                                               * (halfPerimeter - ThirdSide));
            }
        }

        public bool RightTriangle() =>    (Math.Abs(FirstSide * FirstSide + SecondSide * SecondSide - ThirdSide * ThirdSide) < Tolerance) 
                                       || (Math.Abs(FirstSide * FirstSide + ThirdSide * ThirdSide - SecondSide * SecondSide) < Tolerance) 
                                       || (Math.Abs(ThirdSide * ThirdSide + SecondSide * SecondSide - FirstSide * FirstSide) < Tolerance);
    }
}
