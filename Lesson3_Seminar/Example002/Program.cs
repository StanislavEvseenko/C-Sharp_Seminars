//принимает на вход X & Y не равные нулю, и выдает номер четверти плоскости в которой эта точка

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void QuarterAvaliable(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else {
        System.Console.WriteLine("Такой четверти нет");
    }
}

int quarter = InputNum("Ввести номер четверти: ");
QuarterAvaliable(quarter);