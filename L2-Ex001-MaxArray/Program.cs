int Max(int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    return max;
}

int a1 = 4;
int b1 = 500;
int c1 = 6;
int a2 = 4;
int b2 = 15;
int c2 = 6;
int a3 = 4;
int b3 = 50;
int c3 = 6;

//int maximum1 = Max(a1, b1, c1);
//int maximum2 = Max(a2, b2, c2);
//int maximum3 = Max(a3, b3, c3);
//int maximum = Max(maximum1, maximum2, maximum3);
int maximum = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(maximum);
