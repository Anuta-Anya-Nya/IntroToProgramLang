// перевернуть массив.
const int ARRAY_SIZE = 5;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

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
void ReverseArray(int[] collect)
{
    int temp = 0;
    for (int i = 0; i < collect.Length / 2; i++)
    {
        temp = collect[i];
        collect[i] = collect[collect.Length - 1 - i];
        collect[collect.Length - 1 - i] = temp;
    }
}

int[] arr = FillArrNumb(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[{String.Join(", ", arr)}]");
ReverseArray(arr);
Console.WriteLine($"[{String.Join(", ", arr)}]");