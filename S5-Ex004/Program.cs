// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.

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
        array[i] = new Random().Next(numMin, numMax+1);
    }
    return array;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArrNumb(length, 1, 10);
Console.WriteLine("[" + string.Join(", ", arr) + "]");

int newLength = arr.Length/2 + arr.Length%2;
int[] newArr = new int[newLength];
for (int i = 0; i < arr.Length/2; i++)
{
    newArr[i]=arr[i]*arr[arr.Length-1-i];
}
if (arr.Length/2 > 0)
{
    newArr[newLength-1] = arr[arr.Length/2];
}
Console.WriteLine("[" + string.Join(", ", newArr) + "]");
