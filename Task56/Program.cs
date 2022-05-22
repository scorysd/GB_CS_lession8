// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void MinSumRows(int[,] matrix)
{
    int[] mass = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        mass[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            mass[i] = mass[i] + matrix[i, j];
        }
        Console.WriteLine($"Сумма {i+1} строки равна {mass[i]}");
    }
    int min = mass[0];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        if (mass[i] > mass[i + 1])
        {
            min = mass[i + 1];
        }
    }
    Console.WriteLine($"Наименьшая сумма строки равна {min}");
}
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int colomns = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] matrix = new int[rows, colomns];
FillMatrix(matrix);
PrintMatrix(matrix);
MinSumRows(matrix);