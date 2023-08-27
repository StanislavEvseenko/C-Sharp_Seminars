Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);


if ((number % 2) == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
};