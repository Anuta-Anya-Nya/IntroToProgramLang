// факториал
int factorial(int n)
{
    if (n == 1) //1! = 1 //обязательное условие выхода!!!
    {
        return 1;
    }
    else
    {
        return n * factorial(n - 1);
    }
}
Console.WriteLine(factorial(3));

//Фибоначчи F(1)=1
// F(2)=1
//F(n)=F(n-1) + F(n-2)
int Fibonacci(int n)
{
    if (n == 1 || n == 2) //обязательное условие выхода!!!
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
Console.WriteLine(Fibonacci(4));