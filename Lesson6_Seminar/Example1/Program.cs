using System;
// разворот одномерного массива [1 2 3 4 5] -> [5 4 3 2 1]


Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double[] CreateDoubleArr(int size)
{
    return new double[size];
}

void FillDoubleArray(double[] araay, int minValue, int maxValue)
{
    Random rnd = new Random();
    //int deviation = 10; 
    for (int i = 0; i < araay.Length; i++)
        //araay[i] = Math.Round(rnd.NextDouble(), 2); //числа от 0 до 1
        //araay[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation, 2); //числа от -deviation до deviation
        //araay[i] = Math.Round(rnd.NextDouble() * maxValue, 2); //числа от 0 до maxValue
        araay[i] = Math.Round(rnd.NextDouble() + rnd.Next(minValue, maxValue), 2); //числа от minValue до maxValue
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void ReverseArray(double[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        double temp = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = temp;

        //(array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]); //короткая запись
    }
    
}

int size = InputNum("Введите размер массива: ");
int min = InputNum("Введите min element массива: ");
int max = InputNum("Введите max element массива: ");
double[] array = CreateDoubleArr(size);
FillDoubleArray(array, min, max);
PrintArray(array);
ReverseArray(array);
PrintArray(array);