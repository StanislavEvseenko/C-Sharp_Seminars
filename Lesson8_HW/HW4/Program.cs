// создание трехмерный массив из неповторяющихся двузначных чисел. 
// вывод построчно с добавлением индекса каждого элемента

// Массив размером 2х2х2:
// 66(0,0,0) 25(0,1,0)
// 66(1,0,0) 25(1,1,0)
// 66(0,0,1) 25(0,1,1)
// 66(1,0,1) 25(1,1,1)

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] Create1DArray(int x)
{
    return new int[x];
}

void Fill1DArray(int[] array)
{
    int min = 10;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        {
            min += rnd.Next(1, 5);
            array[i] = min;
        }
}

int[,,] Create3DArray(int x, int y, int z)
{
    return new int[x, y, z];
}

void Fill3DArray(int[,,] array, int[] numbersArray)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = numbersArray[count];
                count++;
            }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[j, k, i] + $"({j}, {k}, {i})" + "\t");
            Console.WriteLine();
        }
            
}

int xDimension = InputNum("Введите размерность X массива: ");
int yDimension = InputNum("Введите размерность Y массива: ");
int zDimension = InputNum("Введите размерность Z массива: ");

int[,,] firstArray = Create3DArray(xDimension, yDimension, zDimension);
int[] numbersArray = Create1DArray(firstArray.Length);
Fill1DArray(numbersArray);
Console.WriteLine(string.Join(" ", numbersArray));
Fill3DArray(firstArray, numbersArray);
Print3DArray(firstArray);
