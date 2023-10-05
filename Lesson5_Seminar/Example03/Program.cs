//узнать есть-ли в массиве нужное число

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
        araay[i] = rnd.Next(0, 100);
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

void FindNum(int[] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            count++;
        }
    };
    if (count == 0)
    {
        Console.WriteLine("нет");
    } else
    {
        Console.WriteLine("да");
    }
}

int myNum = InputNum("Введите нужное число от 0 до 100: ");
int[] newArray = new int[12];

FillArray(newArray);
PrintArray(newArray);
FindNum(newArray, myNum);
