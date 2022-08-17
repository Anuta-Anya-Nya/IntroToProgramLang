//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string numStr = number.ToString();
int N = numStr.Length;
Console.WriteLine($"Количество цифр числа {number} равно {N}");*/

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count=1;
while(number>10)
{
    count++;
    number=number/10;
}
Console.WriteLine($"Количество цифр числа равно {count}");