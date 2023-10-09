using System;
// ввод трех чисел и проверка может ли быть треугольник со сторонами такой длины
// теорема: каждая сторона треуголника меньше суммы двух других сторон


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string BinNum(int num)
{
    string result = "";
    while (num != 0)
    {
        int temp = num % 2;
        result = $"{temp}" + $"{result}";
        num /= 2;
    }
    return result;
}

int number = InputNum("Введите число: ");

Console.WriteLine(BinNum(number));