// перевести в двоичную систему
// string dvoich(int number)
// {
//     string result = String.Empty;
//     if (number == 0)
//     {
//         return result = number % 2 + result;
//     }
//     else
//     {
//         return result = dvoich(number / 2) + result;
//     }
// }


// int x = 28;
// string result = String.Empty;
// while (x != 0)
// {
//     result = (x % 2) + result;
//     x = x / 2;
// }
// Console.WriteLine(result);

// string Dvoich(int N)
// {
//     string result = String.Empty;
//     if (N == 0)
//     {
//         return result;
//     }
//     else
//     {
//         return result = Dvoich(N / 2) + Convert.ToString(N % 2) + result;
//     }
// }
// Console.WriteLine(Dvoich(45));

void PrintBinary(int N)
{
    if (N == 0)
    {
        return;
    }
    PrintBinary(N / 2);
    Console.Write(N % 2);
}
PrintBinary(45);