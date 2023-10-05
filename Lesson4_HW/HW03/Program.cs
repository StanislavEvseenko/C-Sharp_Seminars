//задает массив и петает его

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
        araay[i] = new Random().Next(0, 1000);
    }
}

void PrintArray (int[] array)
{
    Console.Write("[");
    int i = 0;
    foreach (int value in array)
    {
        if (i != 0) Console.Write(", ");
        i++;
        Console.Write(value);
    }
    Console.Write("]");
}
int size = 8;
int[] arr = new int[size];

FillArray(arr);
PrintArray(arr);