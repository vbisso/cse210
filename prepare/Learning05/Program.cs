using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("pink",5);
    

        Rectangle rectangle = new Rectangle("blue",5,6);
      

        Circle circle = new Circle("green",5);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());

        }

       
    }
}