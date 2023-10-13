using System.ComponentModel;
using System;
// создание двумерного массива размера m на n. 
// вывод сколько раз встречается каждое число в массиве
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

int[ ] Convert2DArrTo1D(int[,] array)
{
    int[] newArray = new int[array.Length];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    } 
    return newArray;
}

void SortArray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                max = array[j];
                array[j] = array[j + 1];
                array[j + 1] = max;
            }
        }
    }
}

void Frequecy(int[] array)
{
    int count = 1;
    int element = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            count++;
        } else {
            Console.WriteLine($"{element} встречается {count} раз");
            element = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{element} встречается {count} раз");
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите min: ");
int max = InputNum("Введите max: ");

int[,] anyArray = Create2DArray(rows, cols);
Fill2DArray(anyArray, min, max);
Print2DArray(anyArray);
Console.WriteLine();

int[] sortArray = Convert2DArrTo1D(anyArray);
Console.WriteLine(string.Join(" ", sortArray));
Console.WriteLine();
SortArray(sortArray);
Console.WriteLine(string.Join(" ", sortArray));
Console.WriteLine();
Frequecy(sortArray);