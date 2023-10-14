// создание двумерного массива размера m на n. 
// удаление строки и столбца на пересечении которых расположен наименьший элемент
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

int [,] CutArray(int[,] array, int [] indexes)
{
    int [,] arr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == indexes[0])
            continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == indexes[1])
                continue;
            arr[row, column] = array[i, j];
            column++;
        }
        row++;
        column = 0;
    }
    return arr;
}

int [] GetIndex(int[,] array)
{
    int min = array[0, 0];
    int [] indexes = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

// void Frequecy(int[] array)
// {
//     int count = 1;
//     int element = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] == element)
//         {
//             count++;
//         } else {
//             Console.WriteLine($"{element} встречается {count} раз");
//             element = array[i];
//             count = 1;
//         }
//     }
//     Console.WriteLine($"{element} встречается {count} раз");
// }

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите min: ");
int max = InputNum("Введите max: ");

int[,] anyArray = Create2DArray(rows, cols);
Fill2DArray(anyArray, min, max);
Print2DArray(anyArray);
Console.WriteLine();

int[] coord = GetIndex(anyArray);
int [,] cutArray = CutArray(anyArray, coord);
Print2DArray(cutArray);