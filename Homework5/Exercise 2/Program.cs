using Domain.NewClasses;

//Shape
Shape shape = new Shape("Shape", "Red", new int[] { 0, 0 });
shape.Move(shape);
shape.GetArea();
shape.GetPerimeter();
Console.WriteLine("=====================================");

//Rectangle
Rectangle rectangle = new Rectangle("Rectangle", "Green", new int[] { -5, 1 }, 6, 5);
shape.Move(rectangle);
rectangle.GetArea();
rectangle.GetPerimeter();
Console.WriteLine("=====================================");

//Circle
Circle circle = new Circle("Circle", "Blue", new int[] { -2, 5 }, 8);
shape.Move(circle);
circle.GetArea();
circle.GetPerimeter();
Console.WriteLine("=====================================");