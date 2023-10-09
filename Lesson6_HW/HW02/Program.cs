// нахождение точки пересечения двух прямых
Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Intersection(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения заданных прямых ({x}, {y})");
    } else
    {
        Console.WriteLine("Заданные прямые параллельны");
    }
}

double b1 = InputNum("Введите точку B1: ");
double k1 = InputNum("Введите точку K1: ");
double b2 = InputNum("Введите точку B2: ");
double k2 = InputNum("Введите точку K2: ");
Intersection(b1, k1, b2, k2);