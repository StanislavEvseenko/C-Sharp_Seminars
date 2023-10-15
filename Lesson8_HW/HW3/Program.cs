// создание двух двумерных массивов. 
// вывод третьего массива -> произведение первого на второй

// Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.  
// Имеет место ещё одна важная особенность произведения матриц относительно числа строк и столбцов: 
// В произведении матриц АВ число строк равно числу строк матрицы А, а число столбцов равно числу столбцов матрицы В
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

int[, ] MultiplicationArray(int[, ] arrayA, int[, ] arrayB)
{
    int [, ] multi = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                multi[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return multi;
}

int rows1 = InputNum("Введите количество строк 1 матрицы: ");
int cols1 = InputNum("Введите количество столбцов 1 матрицы: ");
int rows2 = InputNum("Введите количество строк 2 матрицы: ");
int cols2 = InputNum("Введите количество столбцов 2 матрицы: ");
int min = InputNum("Введите min: ");
int max = InputNum("Введите max: ");

int[,] firstArray = Create2DArray(rows1, cols1);
int[,] secondArray = Create2DArray(rows2, cols2);
Fill2DArray(firstArray, min, max);
Fill2DArray(secondArray, min, max);
Print2DArray(firstArray);
Console.WriteLine();
Print2DArray(secondArray);
Console.WriteLine();
if (firstArray.GetLength(1) == secondArray.GetLength(0))
{
    int[,] multiArray = MultiplicationArray(firstArray, secondArray);
    Print2DArray(multiArray);
} else {
    Console.WriteLine("Невозможно перемножить эти матрицы.");
}