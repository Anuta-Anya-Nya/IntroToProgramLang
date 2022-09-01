void FillArray(int[] collection) // заполняет пустой массив рандомными числами от 1 до 10
{
    int length = collection.Length;
    for (int count = 0; count < length; count++)
    {
        collection[count] = new Random().Next(1, 11);
    }
}
int[] FillArrNumb(int leng, int numMin, int numMax) // создает массив заданной длины, с элементами в заданном промежутке
{
    while (leng <= 0)
    {
        Console.WriteLine("Введено неверное значение! Введите другое: ");
        leng = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[leng];
    for (int i = 0; i < leng; i++)
    {
        array[i] = new Random().Next(numMin, numMax + 1);
    }
    return array;
}

void PrintArray(int[] arr) // печатает массив в консоль в строчку
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SortArrayMinMax(int[] array) //сортирует массив от мин к макс
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if (min > array[j])
            {
                array[i] = array[j];
                array[j] = min;
                min = array[i];
            }
        }
    }
}

void SortArrayMaxMin(int[] array) //сортирует массив от макс к мин
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int max = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if (max < array[j])
            {
                array[i] = array[j];
                array[j] = max;
                max = array[i];
            }
        }
    }
}
// создает матрицу m строк на n столбцов из чисел от 0 до 10 и распечатывает
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
// Печатает матрицу:
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

int[] testArr = new int[10];
FillArray(testArr);
PrintArray(testArr);
Console.WriteLine(" ");
SortArrayMinMax(testArr);
PrintArray(testArr);
Console.WriteLine(" ");
SortArrayMaxMin(testArr);
Console.WriteLine(String.Join(", ", FillArrNumb(5, 1, 10)));
Console.WriteLine($"[{String.Join(", ", testArr)}]"); // Массив выводит строкой без запятой в конце!!
PrintMatrix(CreateAndPrintMatrix(3, 4));
