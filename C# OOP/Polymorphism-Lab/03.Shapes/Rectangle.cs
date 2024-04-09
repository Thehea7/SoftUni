

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double Height { get; init; }
        public double Width { get; init; }

        public override double CalculatePerimeter()
        {
            return 2*(Height + Width);
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}
