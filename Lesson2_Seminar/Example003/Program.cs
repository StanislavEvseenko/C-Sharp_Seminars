int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return  num;
}

bool Multiplicity(int firstNum, int secondNum)
{
    /* if (firstNum % secondNum == 0)
        return true;
    else
        return false; */
    return firstNum % secondNum == 0;
}

/* string DivisionRemainder(int number1, int number2)
{
    if (number1 % number2 == 0)
    {
        string result = "Кратно";
        return result;
    }
    else
    {
        string result = $"Не кратно, остаток {number1 % number2}";
        return result;
    } 
} 
Console.WriteLine(DivisionRemainder(firstNum, secondNum));
*/

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

bool check = Multiplicity(firstNum, secondNum);
Console.WriteLine(check);