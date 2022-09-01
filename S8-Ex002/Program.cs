// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] CreateAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void PrintMatrix(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            Console.Write(anyMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число m - количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n - количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateAndPrintMatrix(m, n);
int[,] newMatrix = new int[n, m];
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        newMatrix[j, i] = matrix[i, j];
    }
}
PrintMatrix(newMatrix);