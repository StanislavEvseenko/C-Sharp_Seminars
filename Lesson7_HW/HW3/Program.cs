public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
      }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      int[, ] ints = new int[n, m];
      int firstItem = 1;
      for (int i = 0; i < ints.GetLength(0); i++)
        for (int j = 0; j < ints.GetLength(1); j++)
        {
          ints[i, j] = firstItem;
          firstItem += k;
        }
      return ints;
    }
  
    static void PrintListAvr (double [] list)
    {
      Console.WriteLine("The averages in columns are: ");
      for (int i = 0; i < list.Length; i++)
      {
        if (i == list.Length - 1) {
          Console.Write(string.Format("{0:F2}",list[i]));
        } else {
          Console.Write(string.Format("{0:F2}",list[i]) + "\t"); //Если нужно добавить нули после запятой 1 -> 1.00
        }  
      }
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      int size = matrix.GetLength(1) - 1;
      double[] averageInColumns = new double[size + 1];
      double average = 0.00;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        for (int i = 0; i < matrix.GetLength(0); i++)
          average = average + matrix[i, j];
        average /= size;
        averageInColumns[j] = average;
        average = 0.00;
      }
      return averageInColumns;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}