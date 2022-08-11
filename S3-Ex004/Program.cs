Console.Write("Введите число N: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] result = new int[number];
if (number == 0)
{
    Console.WriteLine("0 вводить нельзя!");
}
else 
{
    for (int i = 1; i <=number; i++)
    {
        result[i-1] = i * i;
    }
    for (int j=0; j < result.Length; j++)
    {
        Console.WriteLine(result[j]);
    }
}

