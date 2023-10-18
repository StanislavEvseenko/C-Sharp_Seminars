// РЕКУРСИЯ
// Задайте значение N.
// вывод всех натуральных чисел от 1 до N.


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// void PrintNumbers(int n)
// {
//     if(n > 0)
//     {
//         PrintNumbers(n - 1);
//         Console.Write(n + " ");
//     }
// }

string PrintNumbers(int n, int start)
{
    if(start == n)
        return n.ToString();
    return start + " " + PrintNumbers(n, start + 1);
}

int number = InputNum("Введите число: ");
Console.WriteLine(PrintNumbers(number, 1));
// PrintNumbers(number);