//Сортировка массива от мин к макс
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int count = 0; count < length; count++)
    {
        collection[count] = new Random().Next(1, 11);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
void SortArray(int[] array)
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
int[] someNumbers = new int[8];
FillArray(someNumbers);
SortArray(someNumbers);
PrintArray(someNumbers);