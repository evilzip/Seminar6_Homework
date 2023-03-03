// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputDouble(string message)
{
    System.Console.Write(($"{message} "));
    double value;
    bool isCorrectInt32 = double.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32)
    {
        return value;
    }
    System.Console.WriteLine("You entered not a number");
    Environment.Exit(-2);
    return 0;
}

(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        System.Console.WriteLine("Your lines are parallel, thus no a cross point");
        Environment.Exit(-1);
        return (0,0);
    }
    double CrossPointX = (b2 - b1) / (k1 - k2);
    double CrossPointY = k1 * CrossPointX + b1;
    return (CrossPointX, CrossPointY);
}

double k1 = InputDouble("Enter a slope factor of 1st Line:");
double b1 = InputDouble("Enter a b parametr for 1st line:");
double k2 = InputDouble("Enter a slope factor of 2nd Line:");
double b2 = InputDouble("Enter a b parametr for 2nd line:");

(double IntersectionX, double IntersectionY) = CrossPoint(k1, b1, k2, b2);

System.Console.WriteLine($"Intersection point of your lines is ({IntersectionX:f3} , {IntersectionY:f3})");


