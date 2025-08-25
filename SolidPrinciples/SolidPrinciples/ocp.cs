// WITHOUT OCP

//using System;
//public enum ShapeType
//{
//    Rectangle,
//    Circle
//}
//public class AreaCalculator
//{
//    public double CalculateArea(ShapeType type, double value1, double value2 = 0)
//    {
//        if (type == ShapeType.Rectangle)
//        {
//            return value1 * value2;
//        }
//        else if (type == ShapeType.Circle)
//        {
//            return Math.PI * value1 * value1;
//        }
//        return 0;
//    }
//}

//-------------------------------------------------------------------------------------------------------

// WITH OCP

//using System;
//using System.Collections.Generic;

//public abstract class Shape
//{
//    public abstract double CalculateArea();
//}

//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

//public class Circle : Shape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override double CalculateArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//public class AreaCalculator
//{
//    public double CalculateArea(Shape shape)
//    {
//        return shape.CalculateArea();
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        AreaCalculator calculator = new AreaCalculator();

//        Shape rectangle = new Rectangle(10, 5);
//        Shape circle = new Circle(2);

//        Console.WriteLine("Rectangle Area: " + calculator.CalculateArea(rectangle));
//        Console.WriteLine("Circle Area: " + calculator.CalculateArea(circle));
//    }
//}
