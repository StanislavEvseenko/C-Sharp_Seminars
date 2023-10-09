// пользователь вводит М чисел, посчитать сколько чисел будет больше 0
Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void CheckForZero(int amount)
{
    int nums = 0;
    for(int i = 0; i < amount; i++)
    {
        if (InputNum("Введите число: ") > 0)
        {
            nums++;
        }
    }
    Console.WriteLine($"Положительных чисел: {nums}");
}

int amount = InputNum("Введите количество чисел: ");
CheckForZero(amount);