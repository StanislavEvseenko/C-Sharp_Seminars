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

bool IsTriangle(int a, int b, int c)
{
    return (a + b > c && b + c > a && a + c > b);
}

int firstSide = InputNum("Введите длину стороны А: ");
int secondSide = InputNum("Введите длину стороны B: ");
int thirdSide = InputNum("Введите длину стороны C: ");
Console.WriteLine($"Возможность существования такого треугольника: {IsTriangle(firstSide, secondSide, thirdSide)}");