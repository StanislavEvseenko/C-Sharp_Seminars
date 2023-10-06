using System;
//массив вещественных чисел, сумма макс и мин элементов

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FillArray(double[] araay)
{
    int max = 100;
    for(int i = 0; i < araay.Length; i++)
    {
        araay[i] = Math.Round(new Random().NextDouble() + new Random().Next(0, max), 2);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void DifMinMax(double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (min > array[i+1])
            min = array[i+1];
        if (max < array[i+1])
            max = array[i+1];
    }
    Console.WriteLine($"Максимальное: {max}");
    Console.WriteLine($"Минимальное: {min}");
    dif = max - min;
    Console.WriteLine($"Разница между макс и мин: {dif}");
}

int size = InputNum("Введите размер массива: ");
double[] nums = new double[size];
FillArray(nums);
PrintArray(nums);
DifMinMax(nums);