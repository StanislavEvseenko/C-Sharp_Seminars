// РЕКУРСИЯ
// Задайте значение M и N.
// вывод всех натуральных чисел от M до N.


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write(m + " ");
        return;
    }
    PrintNumbers(m, n - 1);
    Console.Write(n + " ");
}

int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");
PrintNumbers(m, n);