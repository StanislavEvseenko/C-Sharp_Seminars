//сумма элементов "случайного" массива, стоящих на нечетных позициях

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
        araay[i] = rnd.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void SumOddNums(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    Console.WriteLine(sum);
}

int size = InputNum("Введите размер массива: ");
int[] nums = CreateArray(size);
FillArray(nums);
PrintArray(nums);
SumOddNums(nums);