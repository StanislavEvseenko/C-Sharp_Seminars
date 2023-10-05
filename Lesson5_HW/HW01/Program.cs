//количество четных чисел в массиве из случайных положительных трехзначных

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] araay)
{
    Random rnd = new Random();
    for(int i = 0; i < araay.Length; i++)
    {
        araay[i] = rnd.Next(99, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void EvenNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine(count);
}

int size = InputNum("Введите размер массива: ");
int[] nums = CreateArray(size);
FillArray(nums);
PrintArray(nums);
EvenNums(nums);