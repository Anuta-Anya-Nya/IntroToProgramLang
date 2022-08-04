Console.Write("Введите порядковый номер дня недели от 1 до 7: ");

if (!int.TryParse(Console.ReadLine(), out int result))
{
    Console.WriteLine("Введено говно!");
    return;
}

if (result == 1) Console.Write("Понедельник");
if (result == 2) Console.Write("Вторник");
if (result == 3) Console.Write("Среда");
if (result == 4) Console.Write("Четверг");
if (result == 5) Console.Write("Пятница");
if (result == 6) Console.Write("Суббота");
if (result == 7) Console.Write("Воскресенье");
if (result < 1 || result > 7) Console.WriteLine("Введено неверное число");