/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */
int[,] matrix = {{1, 4, 7, 2},
                 {5, 9, 2, 3},
                 {8, 4, 2, 4}};

for (int i = 0; i < matrix.GetLength(1); i++)   
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum += matrix[j, i];
    }
    Console.WriteLine(sum / 3);
}           