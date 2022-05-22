// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
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
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int colomns = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] matrix1 = new int[rows, colomns];
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = new int[rows, colomns];
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] multply = new int[rows, colomns];
for (int k = 0; k < multply.GetLength(0); k++)
{
    for (int l = 0; l < multply.GetLength(1); l++)
    {
        multply[k,l] = matrix1[k,l] * matrix2[k,l];
        Console.Write(multply[k, l] + " ");
    }
    Console.WriteLine();
}