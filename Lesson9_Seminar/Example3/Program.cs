// РЕКУРСИЯ
// Задайте число M.
// вывод суммы цифр этого числа.


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int SumDigits(int number)
{
    if (number == 0) return 0;
    return SumDigits(number / 10) + number%10;
}

int num = InputNum("Введите число: ");
int sum = SumDigits(num);
Console.WriteLine(sum);