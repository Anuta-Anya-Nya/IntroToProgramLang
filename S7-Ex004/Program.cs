Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
int result = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == j)
        {
            result += matrix[i, j];
        }
    }
}
Console.WriteLine(result);
