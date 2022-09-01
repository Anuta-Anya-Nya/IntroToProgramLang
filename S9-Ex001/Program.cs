// Напишите программу, которая выведет все натуральные числа от 1 до N

int N = 5;
void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }

    PrintNumbers(number - 1);
    Console.Write($"{number} ");

}
PrintNumbers(N);