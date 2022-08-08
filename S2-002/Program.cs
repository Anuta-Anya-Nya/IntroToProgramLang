// Рандомное трехзначное число, удалить среднюю цифру
int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше рандомное число: {number}");
int digit1 = number / 100; //первая цифра
int digit2 = number % 10; //третья цифра
int result = digit1 * 10 + digit2;
Console.WriteLine(result);   // можно $"{digit1}{digit2}"           

/*string s = new Random().Next(100, 1000).ToString();
int a1=int.Parse(s[0].ToString());
int a2=int.Parse(s[s.Length-1].ToString());
Console.WriteLine($"{digit1}{digit2}");*/