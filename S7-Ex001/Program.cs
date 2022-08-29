// Создать двумерный массив m на n рандомными числами
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n]; //если трехмерный массив, то [,,] и т.д.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(-100, 101);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}