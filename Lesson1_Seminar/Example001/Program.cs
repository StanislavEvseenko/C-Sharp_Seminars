Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}");