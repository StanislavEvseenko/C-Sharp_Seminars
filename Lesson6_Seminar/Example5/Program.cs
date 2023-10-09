// копия массива поэлементно

Console.Clear();

int[] numbers = {1, 2, 3, 4, 5, 6, 7};
int[] copy = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    copy[i] = numbers[i];
}
Console.WriteLine(string.Join(", ", copy));
numbers[3] = 10;
Console.WriteLine(string.Join(", ", numbers));