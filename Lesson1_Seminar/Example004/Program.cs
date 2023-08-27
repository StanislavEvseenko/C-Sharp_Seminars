Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);
int count = number * (-1);

 while(count <= number)
 {
    if (count % 2 == 0)
    {
       Console.WriteLine(count);
    };
    count++;
};