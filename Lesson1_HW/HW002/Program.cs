Console.Clear();
Console.Write("Введите первое число: ");
string num1 = Console.ReadLine()!;
int number1 = int.Parse(num1);
Console.Write("Введите второе число: ");
string num2 = Console.ReadLine()!;
int number2 = int.Parse(num2);
Console.Write("Введите третье число: ");
string num3 = Console.ReadLine()!;
int number3 = int.Parse(num3);
int max = 0;

if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
};
if (number3 > max)
{
    max = number3;
}

Console.WriteLine(max);