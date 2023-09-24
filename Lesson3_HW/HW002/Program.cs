//принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
// не доделано

Console.Clear();

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double PointDistance(int[] pointA, int[] pointB)
{
    double dist = 0;
    int aXY = aX - aY;
    int bXY = bX - bY;

    dist = Math.Sqrt(Math.Pow(aXY, 2) + Math.Pow(bXY, 2));
    return dist;
}

int aX = InputNum("Ввести координату aX: ");
int aY = InputNum("Ввести координату aY: ");
int aZ = InputNum("Ввести координату aZ: ");
int bX = InputNum("Ввести координату bX: ");
int bY = InputNum("Ввести координату bY: ");
int bZ = InputNum("Ввести координату bZ: ");

Console.WriteLine(Math.Round(PointDistance(aX, aY, bX, bY), 2));