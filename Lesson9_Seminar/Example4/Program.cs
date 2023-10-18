// РЕКУРСИЯ
// Задайте два числа A и B.
// возвести число A в степень B.


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double Powered(int num, int degree)
{
    if (degree == 0)
        return 1;
    if (degree > 0) {
        return num * Powered(num, --degree);
    } else {
        return 1.0 / num * Powered(num, ++degree);
    }
}

int numA = InputNum("Введите число A: ");
int numB = InputNum("Введите число B: ");

Console.WriteLine(Powered(numA, numB));