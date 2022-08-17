// Программа принимает число А и выводит сумму от 1 до А
Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int sum=0;
for (int i=1; i<=number; i++)
{
    sum = sum+i;
}
Console.Write(sum);