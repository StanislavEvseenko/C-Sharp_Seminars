//массив из 123 случайных чисел, найти колличество элементов в массиве, которые от 10 до 99.

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
        araay[i] = rnd.Next(0, 200);
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

void FindNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

int[] newArray = new int[123];

FillArray(newArray);
PrintArray(newArray);
FindNums(newArray);