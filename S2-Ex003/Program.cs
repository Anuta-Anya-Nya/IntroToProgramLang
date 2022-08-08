/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
 34, 5 -> не кратно, остаток 4
16, 4 -> кратно */
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 % number2;
/* if (result == 0)
{
   Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine("Число не кратно. Остаток от деления: " + result + "!");
} */

if (number1 % number2 == 0) 
{
    Console.WriteLine("Число кратно");
} else {
    Console.WriteLine($"Число не кратно. Остаток от деления {number1 % number2}");
}