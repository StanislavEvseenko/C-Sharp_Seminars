//принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
// не доделано

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int SumNums (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
        sum += i;
    return sum;
}

int num = InputNum("Введите число: ");
int sum = SumNums(num);
Console.WriteLine(sum);