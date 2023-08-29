Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

bool Test(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

int num = InputNum("Введите число: ");

Console.WriteLine(Test(num));