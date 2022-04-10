 /* Question 5 */

namespace Question5
{
  abstract class Shape
  {
    public double Width { get; set;}
    public double Height { get; set;}

    public abstract double CalculateSurface(double a, double b);
  }

  class Triangle: Shape
  {
    public override double CalculateSurface(double Height, double Width){
      return (Height * (Width / 2));
    }
  }

  class Rectangle: Shape
  {
    public override double CalculateSurface(double Height, double Width){
      return Height * Width;
    }
  }
}