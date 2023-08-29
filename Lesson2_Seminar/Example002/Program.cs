Console.Clear();

int DelSecondDigit(int number)
{
    int firstDig = number / 100;
    int secondDig = number % 10;

    int result = firstDig * 10 + secondDig;
    return result;
}

int randomNum = new Random().Next(100, 1000);

Console.WriteLine($"{randomNum} --> {DelSecondDigit(randomNum)}");