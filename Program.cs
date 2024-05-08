namespace Assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string userInput;
            do
            {
                double shapeBase;
                double shapeHeight;

                do
                {
                    Console.WriteLine("This program calculates the area of a triangle, square, and rectangle. Please select a shape.");
                    Console.WriteLine("Enter T for triangle.");
                    Console.WriteLine("Enter S for square.");
                    Console.WriteLine("Enter R for rectangle.");
                    Console.WriteLine("Enter X to exit the program.");

                    userInput = Console.ReadLine();
                } while (userInput == "");

                switch (userInput)
                {
                    case "T":
                    case "t":
                        shapeBase = GetNumberFromUser("base", "triangle");
                        shapeHeight = GetNumberFromUser("height", "triangle");
                        Console.WriteLine("The area of the triangle is " + AreaOfTriangle(shapeBase, shapeHeight));
                        break;
                    case "S":
                    case "s":
                        shapeBase = GetNumberFromUser("base", "square");
                        Console.WriteLine("The area of the square is " + AreaOfSquare(shapeBase));
                        break;
                    case "R":
                    case "r":
                        shapeBase = GetNumberFromUser("base", "rectangle");
                        shapeHeight = GetNumberFromUser("height", "rectangle");
                        Console.WriteLine("The area of the rectangle is " + AreaOfRectangle(shapeBase, shapeHeight));
                        break;
                    case "X":
                    case "x":
                        break;
                    default:
                        Console.WriteLine("That was not one of the choices.");
                        break;
                }
            } while (userInput != "X" && userInput != "x");
        }

        static int GetNumberFromUser(string location, string shape)
        {
            string input;
            do
            {
                Console.WriteLine("Please enter the " + location + " of the " + shape);
                input = Console.ReadLine();
            } while (input == "");
            return Convert.ToInt32(input);
        }

        static double AreaOfTriangle(double baseNumber, double heightNumber)
        {
            return (baseNumber * heightNumber) / 2;
        }

        static double AreaOfSquare(double baseNumber)
        {
            return baseNumber * baseNumber;
        }

        static double AreaOfRectangle(double baseNumber, double heightNumber)
        {
            return baseNumber * heightNumber;
        }
    }
}
