//количество знаков в числе

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FillArray(int[] araay)
{
    for(int i = 0; i < araay.Length; i++)
    {
        araay[i] = new Random().Next(0, 2);
    }
}

void PrintArray (int[] array)
{
    foreach (int value in array)
    {
        Console.Write(value + " ");
    }
}
void Dell(int a)
{
    a/=2;
};
int size = InputNum("Введите размер массива: ");
int[] arr = new int[size];

FillArray(arr);
PrintArray(arr);
Dell(size);
Console.WriteLine(size);