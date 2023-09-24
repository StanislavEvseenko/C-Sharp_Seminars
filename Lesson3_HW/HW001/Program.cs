//Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void IsPalindrome(int number)
{
    if (number.ToString().Length==5) {
        if (((number / 1000) % 10 == (number % 100) / 10) && (number/10000 == number % 10)) Console.WriteLine("Полиндром");
        else Console.WriteLine("Не полиндром");
    } else {
        Console.WriteLine("Число не пятизначное");
    }
}

int num = InputNum("Введите число: ");

IsPalindrome(num);