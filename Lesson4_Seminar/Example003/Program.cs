//количество знаков в числе

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Factorial(int num)
{
    int mul = 1;
    for(int i = 2; i <= num; i++)
        mul *= i;
    return mul;
}

int num = InputNum("Введите число: ");

int fact = Factorial(num);
System.Console.WriteLine(fact);