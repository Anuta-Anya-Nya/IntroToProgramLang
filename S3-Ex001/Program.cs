int[] point = new int [2];
Console.Write("Введите координату X");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y");
point[1] = Convert.ToInt32(Console.ReadLine());
if (point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Четвертая четверть");
}
else
{
    Console.WriteLine("Точка лежит на оси");
}