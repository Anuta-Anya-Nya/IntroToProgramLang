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
        Console.WriteLine(arr[i]);
    }
}

int FindNumberIndex(int[] arr, int find)
{
    int position = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            position = i;
            break;            //если не написать break, цикл прокрутится до конца и будет перезаписывать position на последний найденный элемент
        }
    }
    return position; //если искомого числа нет в массиве, выведется -1
}

Console.Write("Какой длины массив? "); //все ломается, если ввести отрицательное число
int arrayLength = Convert.ToInt32(Console.ReadLine());
while (arrayLength <= 0) //Заставляю пользователя ввести верное число для длины массива
{
    Console.Write("введено неверное число!");
    Console.Write("Еще раз, какой длины массив? ");
    arrayLength = Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);

Console.Write("Индекс какого числа найти в массиве? ");
int numbForFind = Convert.ToInt32(Console.ReadLine());
int indexOf = FindNumberIndex(array, numbForFind);
if (indexOf == -1) 
{ 
    Console.WriteLine("Такого числа в массиве не найдено!"); 
}
else 
{ 
    Console.WriteLine("Индекс равен: " + indexOf); 
}

