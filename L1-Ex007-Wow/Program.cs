Console.Clear();
int ax = 15, ay = 0,
    bx = 0, by = 10,
    cx = 30, cy = 10;

int x = ax, y = ay; // обозначаем просто точку

int count = 0;

Console.SetCursorPosition(ax, ay);
Console.WriteLine("A");
Console.SetCursorPosition(bx, by);
Console.WriteLine("B");
Console.SetCursorPosition(cx, cy);
Console.WriteLine("C");
while (count < 10000) 
{
    int what = new Random().Next(0, 3); // выбираем любое число 0, 1, 2 для выбора рандомной вершины треугольника

    if (what == 0) 
    {
        x = (x + ax) / 2; // вычисляем координаты середины отрезка ПОЧЕМУ СУММА?? НИПАНЯТНА 
        y = (y + ay) / 2;
    }

    if (what == 1) 
    {
        x = (x + bx) / 2;
        y = (y + by) / 2;
    }

    if (what == 2) 
    {
        x = (x + cx) / 2;
        y = (y + cy) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
