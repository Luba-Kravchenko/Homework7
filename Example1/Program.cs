// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

/*Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");*/

double[,] array = new double[3, 4];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
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
