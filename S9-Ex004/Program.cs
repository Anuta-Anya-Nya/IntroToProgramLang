


int Stepen(int a, int b)
{
    if (b == 0) return 1;
    return a * Stepen(a, b - 1);
}
Console.WriteLine(Stepen(3, 5));
