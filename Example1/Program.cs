// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.


void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().NextDouble() * 10;
    }
  }
}

void WriteArray (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
  {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
double[,] array = new double[3, 4];
CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();
