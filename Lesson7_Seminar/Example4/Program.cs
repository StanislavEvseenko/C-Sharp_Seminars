// создание двумерного массива размера m на n. 
// найти сумму элементов главной диагонали

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] ints, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.GetLength(0); i++)
        for (int j = 0; j < ints.GetLength(1); j++)
            ints[i, j] = rnd.Next(minValue, maxValue);
}

void Print2DArray(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
            Console.Write(ints[i, j] + "\t");
        Console.WriteLine();
    }
}

int SumMainDiag(int[,] array)
{
    int minLength = array.GetLength(0);
    if (minLength > array.GetLength(1))
        minLength = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < minLength; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите min: ");
int max = InputNum("Введите max: ");

int[,] anyArray = Create2DArray(rows, cols);
Fill2DArray(anyArray, min, max);
Print2DArray(anyArray);
int number = SumMainDiag(anyArray);
Console.WriteLine(number);