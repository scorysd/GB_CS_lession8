// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите ширину массива:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту массива:");
int z = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,,] matrix = new int[x, y, z];
void FillMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(9, 99);
            }
        }
    }
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + " ");
                Console.Write($"({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
void SortRowsMatrix (int[,,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            for (int l = 0; l < matrix.GetLength(2) - 1; l++)
            {
                if (matrix[i, j, k] < matrix[i, j, l])
                {
                    int temp = matrix[i, j, k];
                    matrix[i, j, k] = matrix[i, j, l];
                    matrix[i, j, l] = temp;
                }
            }
        }
    }
}
}
FillMatrix(matrix);
PrintMatrix(matrix);
SortRowsMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);