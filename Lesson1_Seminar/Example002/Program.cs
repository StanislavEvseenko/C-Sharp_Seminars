Console.Write("Введите число 1: ");
string numA = Console.ReadLine()!;
int a = int.Parse(numA);
Console.Write("Введите число 2: ");
string numB = Console.ReadLine()!;
int b = int.Parse(numB);

if(a == b * b)
    {
        Console.WriteLine($"Число {a} является квадратом числа {b}");
    }
else
    {
        Console.WriteLine($"Число {a} не является квадратом числа {b}");
    }