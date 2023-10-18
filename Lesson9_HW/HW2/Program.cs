// РЕКУРСИЯ
// Задайте значение M и N.
// вывод суммы всех натуральных чисел от M до N.


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int SumDigits(int m, int n)
{
    if (m == n) return m;
    return SumDigits(m + 1, n) + m;
}

int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");
int sum = SumDigits(m, n);
Console.WriteLine(sum);