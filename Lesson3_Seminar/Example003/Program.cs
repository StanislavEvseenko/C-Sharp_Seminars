//принимает на вход X & Y не равные нулю, и выдает расстояние между ними

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double PointDistance(int aX, int aY, int bX, int bY)
{
    double dist = 0;
    int aXY = aX - aY;
    int bXY = bX - bY;

    dist = Math.Sqrt(Math.Pow(aXY, 2) + Math.Pow(bXY, 2));
    return dist;
}

int aX = InputNum("Ввести координату aX: ");
int aY = InputNum("Ввести координату aY: ");
int bX = InputNum("Ввести координату bX: ");
int bY = InputNum("Ввести координату bY: ");

Console.WriteLine(Math.Round(PointDistance(aX, aY, bX, bY), 2));