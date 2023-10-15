// создание двумерного прямоугольного массива размера m на n. 
// вывести номер строки с наименьшей суммой
Console.Clear();

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

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

int [] RowsSums(int[,] array)
{
    int rowSum = 0;
    int [] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        sums[i] = rowSum;
        rowSum = 0;
    }
    return sums;
}

void SearchMinSum(int[] array)
{
    int min = array[0];
    int rowNum = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            rowNum = i;
        }
    }
    Console.WriteLine($"{rowNum + 1} строка");
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите min: ");
int max = InputNum("Введите max: ");

int[,] anyArray = Create2DArray(rows, cols);
Fill2DArray(anyArray, min, max);
Print2DArray(anyArray);
Console.WriteLine();

int[] rowsSums = RowsSums(anyArray);
Console.WriteLine(string.Join(" ", rowsSums));
SearchMinSum(rowsSums);