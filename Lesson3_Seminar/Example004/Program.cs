// принимает на вход число N не равные нулю, и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string SquaresFrom1ToNum(int num)
{
    int count = 1;
    string res = "";
    while (count <= num)
    {
        res += Math.Pow(count, 3);
        if (count < num) res += ",";
        else res += ".";
        count++;
    }
    return res;
}

int number = InputNum("Ввести число: ");
Console.WriteLine(SquaresFrom1ToNum(number));