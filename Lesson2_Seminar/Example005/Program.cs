//является ли одно число квадратом другого

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void IsSquare(int number1, int number2)
{
    if (number1 * number1 == number2)
    {
        Console.WriteLine("Является");
    }
    else
    {
        Console.WriteLine("Не является");
    }
}

int num1 = InputNum("Введите первое число: ");
int num2 = InputNum("Введите второе число: ");

IsSquare(num1, num2);