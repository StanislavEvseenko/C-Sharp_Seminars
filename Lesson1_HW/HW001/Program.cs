Console.Clear();
Console.Write("Введите первое число: ");
string num1 = Console.ReadLine()!;
int number1 = int.Parse(num1);
Console.Write("Введите второе число: ");
string num2 = Console.ReadLine()!;
int number2 = int.Parse(num2);

if (number1 > number2)
{
    Console.WriteLine($"{number1} больше чем {number2}");
}
else
{
    Console.WriteLine($"{number2} больше чем {number1}");
};