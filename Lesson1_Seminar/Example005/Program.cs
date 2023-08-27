Console.Clear();
Console.Write("Введите трехзначное число: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);
int lastNum = (number % 10);
Console.WriteLine(lastNum);