//произведения пар чисел 1+последний, 2+предпоследний

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

void FillArray(int[] araay, int minValue, int maxValue)
{
    Random rnd = new Random();
    for(int i = 0; i < araay.Length; i++)
    {
        araay[i] = rnd.Next(minValue, maxValue + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] MultPairs(int[] array)
{
    int size = array.Length / 2 + array.Length % 2;
    int[] newArr = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
        newArr[i] = array[i] * array[array.Length - 1 - i];
    
    if (array.Length % 2 == 1)
        newArr[size - 1] = array[array.Length / 2];
    return newArr;
}

int size = InputNum("Введите размер массива: ");
int[] ints = CreateArray(size);
int min = InputNum("Введите min element массива: ");
int max = InputNum("Введите max element массива: ");

FillArray(ints, min, max);
PrintArray(ints);

int[] result = MultPairs(ints);
PrintArray(result);