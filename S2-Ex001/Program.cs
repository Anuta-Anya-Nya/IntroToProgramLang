// Условие задачи: программа выводит случайное число от 10 до 99 и сравнивает первую цифру со второй и выводит большее
int number = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {number}");
int digit1 = number/10; //первая цифра
int digit2 = number % 10; 
if (digit1 > digit2)
{
    Console.WriteLine($"Цифра {digit1} больше");
}
else if (digit1 < digit2)
{
    Console.WriteLine($"Цифра {digit2} больше");
}
else 
{
    Console.WriteLine($"Цифры {digit1} и {digit2} равны");
}


