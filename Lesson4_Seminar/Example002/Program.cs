//количество знаков в числе

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = InputNum("Введите число: ");
int i;
for (i = 0; num != 0; i++)
    num /= 10;

Console.WriteLine(i);