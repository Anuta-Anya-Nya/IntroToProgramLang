// создать массив из 12 элементов, случайными числами от -9 до 9. Найти сумму отрицательных и положительных элементов.
int[] array = new int[5];
int sumPos = 0;
int sumNeg = 0;
for( int i = 0; i<array.Length; i++)
{
    array[i]=new Random().Next(-9, 10); // можно Random rand = new Random(); array[i]=rand.Next(-9, 10)
    if (array[i] > 0)
    {
        sumPos+=array[i];
    }
    else
    {
        sumNeg +=array[i];
    }
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(sumPos);
Console.WriteLine(sumNeg);
// void function (int[] arr, out in sumP, out int sumN) - возвращает sumP и sumN, можно обращаться к ним дальше по коду

