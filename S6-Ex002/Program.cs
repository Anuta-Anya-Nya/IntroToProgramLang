// 
const int ARRAY_SIZE = 3;
int[] FillArrNumb(int leng) // создает массив заданной длины, с элементами в заданном промежутке
{
    int[] array = new int[leng];
    for (int i = 0; i < leng; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] arr = FillArrNumb(ARRAY_SIZE);
Console.WriteLine($"[{String.Join(", ", arr)}]");
if (arr[0] < arr[1] + arr[2] && arr[1] < arr[0] + arr[2] && arr[2] < arr[1] + arr[0])
{
    Console.WriteLine("Может");
}
else
{
    Console.WriteLine("Не может");
}