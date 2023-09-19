//принимает на вход X & Y не равные нулю, и выдает номер четверти плоскости в которой эта точка

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Quarter(int axisX, int axisY)
{
    int num = 0;
    if (axisX > 0 && axisY > 0)
        num = 1;
    else if (axisX < 0 && axisY > 0)
        num = 2;
    else if (axisX < 0 && axisY < 0)
        num = 3;
    else if (axisX > 0 && axisY < 0)
        num = 4;
    return num;
}

int x = InputNum("Ввести координату x: ");
int y = InputNum("Ввести координату y: ");

int res = Quarter(x, y);
if (res == 0) Console.WriteLine("Точка лежит на границе четвертей");
else Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в четверти {res}");