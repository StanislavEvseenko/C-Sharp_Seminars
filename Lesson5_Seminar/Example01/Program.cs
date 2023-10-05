//массив из 12ти случайных чисел от -9 до 9 включительно. И сумма отрицательных и положительных чисел.

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FillArray(int[] araay)
{
    Random rnd = new Random();
    for(int i = 0; i < araay.Length; i++)
    {
        araay[i] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    };
    Console.WriteLine();
}

void SumPosNegNums(int[] array) //int[] SumPosNegNums (если нужно вывести результат как массив)
{
    int posSum = 0; //
    int negSum = 0; // int[] sums = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            posSum += array[i]; // sums[0] += array[i];
        else
            negSum += array[i]; // sums[1] += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел равна {posSum}"); //
    Console.WriteLine($"Сумма отрицательных чисел равна {negSum}"); // return sums;
}

int[] newArray = new int[12];

FillArray(newArray);
PrintArray(newArray);
SumPosNegNums(newArray); // int[] result = SumPosNegNums(newArray); PrintArray(result);