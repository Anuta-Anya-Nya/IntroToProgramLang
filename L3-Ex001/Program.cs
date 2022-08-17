// вывод таблицы умножения на экран
void Method(int a, int b)
{
    for (int i = a; i < 10; i++)
    {
        for (int j = b; j < 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine("");
    }
}
int num1 = 2;
Method(num1, num1+2);