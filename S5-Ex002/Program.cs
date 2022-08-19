// Напишите программу замены элемента: положительные на отрицательные и наоборот
int[] array = new int[5];
int[] newArray = new int[5];
for( int i = 0; i<array.Length; i++)
{
    array[i]=new Random().Next(-10, 11); 
    newArray[i]=array[i] * -1;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("[" + string.Join(", ", newArray) + "]");

