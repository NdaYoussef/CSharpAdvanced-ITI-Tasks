namespace Day1P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
          //  circle.ColorName = "red";

            IColor circle2 = new Circle("red");

            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Console.WriteLine($"Circle Color: {circle2.GetColor()}");

            Console.WriteLine("-------------------------------------------------------");

            IShape square = new Square(4);
            IColor square2 = new Square("blue");
            Console.WriteLine($"Square Perimeter: {square.CalculatePerimeter()}");
            Console.WriteLine($"Square Area: {square.CalculateArea()}");

            Console.WriteLine($"Square Color: {square2.GetColor()}");
            Console.WriteLine("-------------------------------------------------------");

            IShape rectangle = new Rectangle( 5, 4);
            IColor rectangle2 = new Rectangle("black");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

            Console.WriteLine($"Rectangle Color: {rectangle2.GetColor()}");

        }
    }
}
