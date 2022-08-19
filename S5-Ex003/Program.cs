// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-5, 5);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Введите число: ");
int found = Convert.ToInt32(Console.ReadLine());
int countYes = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == found)
    {
        countYes++;
    }
}
if (countYes > 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
