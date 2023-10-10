// создание двумерного массива размера m на n. 
// найти элементы с двумя четными индексами и заменить эти элементы на их квадраты

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

void Change2DArrayItem(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i += 2)
    {
        for (int j = 0; j < ints.GetLength(1); j += 2)
            ints[i, j] = ints[i, j] * ints[i, j];
        // if (currentJ = 0)
        //     ints[i, j] = ints[i, j] * ints[i, j];
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите min: ");
int max = InputNum("Введите max: ");

int[,] anyArray = Create2DArray(rows, cols);
Fill2DArray(anyArray, min, max);
Print2DArray(anyArray);
Change2DArrayItem(anyArray);
Console.WriteLine();
Print2DArray(anyArray);