using System;
using System.Text;

namespace HW_Inheritance
{
    public abstract class Figure
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }   
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
           return Width * Height;
        }
    }

    public class Circle : Figure
    {

        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }

    public class RectangularTriangle : Figure
    {
      public Tuple<double, double> Legs { get; private set; }
   
      public RectangularTriangle(double a, double b)
      {
          Legs = new Tuple<double, double>(a, b);
      }
   
      public override double CalculateArea()
      {
          return Legs.Item1* Legs.Item2 * .5;
      }
    }

    public class Trapeze : Figure
    {
        public double Top { get; set; }
        public double Bottom { get; set; }
        public double Height { get; set; }

        public Trapeze(double top, double bottom, double height)
        {
            Top = top;
            Bottom = bottom;
            Height = height;
        }

        public override double CalculateArea()
        {
            return (Top + Bottom) * Height * 0.5;
        }

    }
}
