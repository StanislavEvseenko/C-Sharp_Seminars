using System;
// Не используя рекурсию выведите первые N чисел Фибоначчи. Первые два числа 0 и 1
// Если N = 5 -> 0 1 1 2 3


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Fibonachi(int num)
{
    int prevNum = 1;
    int prevPrevNum = 0;
    if (num == 1)
    {
        Console.WriteLine($"При {num} последовательность равно 0");
    }
    else
    {
        Console.Write($"{prevPrevNum} {prevNum}");
        for (int i = 3; i <= num; i++)
        {
            int nextFibo = prevNum + prevPrevNum;
            Console.Write($" {nextFibo}");
            prevPrevNum = prevNum;
            prevNum = nextFibo;
        }
    }
}

int number = InputNum("Введите число: ");

Fibonachi(number);