// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int multipl=1;
if (number == 0)
{
    Console.Write("Невозможно найти произведение чисел от 1 до 0!");
}
else
{
    for (int i=1; i<=number; i++)
    {
        multipl = multipl * i;
    }
    Console.Write(multipl);
}
