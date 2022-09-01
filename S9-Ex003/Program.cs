//Принимает на вход число и выводит сумму цифр
// int n = 453;
// void SumNumbers(int number, int position)
// {
//     string numberStr = Convert.ToString(number);
//     int sum = 0;
//     if (position == numberStr.Length)
//     {
//         return;
//     }
//     else
//     {
//         sum = sum + Convert.ToInt32(numberStr[position].ToString());
//         SumNumbers(number, position + 1);
//     }
//     Console.WriteLine(sum);
// }
// SumNumbers(n, 0);
int n = 111;
int Sum(int n)
{
    if (n == 0) return 0;
    return (n % 10 + Sum(n / 10));
}
Console.WriteLine(Sum(n));

