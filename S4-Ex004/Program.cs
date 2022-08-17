// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] array = new int[8];
for (int i=0; i < 7; i++)
{
    array[i]=new Random().Next(0, 2);
    Console.Write($"{array[i]}, ");
}
array[7]=new Random().Next(0, 2); //чтобы после последнего элемента в консоль не выводилась запятая
Console.Write($"{array[7]}");
Console.WriteLine(" ");
Console.WriteLine(String.Join(", ", array));