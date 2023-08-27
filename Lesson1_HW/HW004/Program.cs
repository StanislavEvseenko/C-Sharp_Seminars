Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);
int count = 1;

 if (count < number)
 {
    while(count <= number)
    {
        if (count % 2 == 0)
        {
        Console.WriteLine(count);
        };
    count++;
    };
 }
 else
 {
    while(number <= count)
    {
        if (number % 2 == 0)
        {
        Console.WriteLine(number);
        };
    number++;
    };
 }