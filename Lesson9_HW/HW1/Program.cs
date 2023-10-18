// РЕКУРСИЯ
// Задайте значение N.
// вывод всех натуральных чисел от N до 1.


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintNumbers(int n)
{
    if(n > 0)
    {
        Console.Write(n + " ");
        PrintNumbers(n - 1);
    }
}

int number = InputNum("Введите число: ");
PrintNumbers(number);