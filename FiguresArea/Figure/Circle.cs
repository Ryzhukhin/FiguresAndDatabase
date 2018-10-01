using static System.Math;

namespace FiguresArea.Figure
{
    /*
     * Площадь круга
     * При инициализации с пустыми параметрами => радиус равен 0
     */
    public class Circle:Interface.IFigure
    {
        private int Radius { get; set; }

        public Circle() => Radius = 0;
        public Circle(int radius) => Radius = radius;

        public double Area => PI * Pow(Radius, 2);
    }
}
