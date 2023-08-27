Console.Clear();

int MaxDigit(int num)
{
    if (num / 10 > num % 10)
        return num / 10;
    else
        return num % 10;
}

int number = new Random().Next(10, 100); // [a, b)
int res = MaxDigit(number);
Console.WriteLine($"В числе {number} максимальная цифра {res}");