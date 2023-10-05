//цикл в котором А в степени В

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int a = InputNum("Введите число A: ");
int b = InputNum("Введите число B: ");

//for (int i = 0; i < b; i++)
//    a *= a;
//Console.WriteLine(i);

void Exponentiation(int a, int b)
{
    int constA = a;
    for(int i = 1; i < b; i++)
    {
        a *= constA;
    }
    Console.WriteLine(a);
}

Exponentiation(a, b);