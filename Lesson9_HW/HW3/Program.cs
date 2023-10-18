// РЕКУРСИЯ
// Функция Аккермана. 
// Даны два неотрицательных числа M и N.

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else {
        if ((m != 0) && (n == 0)){
            return Akkerman(m - 1, 1);
        } else {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
        
    }
}

int numM = InputNum("Введите число M: ");
int numN = InputNum("Введите число N: ");

Console.WriteLine(Akkerman(numM, numN));