Console.Clear();
int ax = 15, ay = 0,
    bx = 0, by = 10,
    cx = 30, cy = 10;

int x = ax, y = ay; // обозначаем просто точку

int count = 0;

Console.SetCursorPosition(ax, ay);
Console.WriteLine("+");
Console.SetCursorPosition(bx, by);
Console.WriteLine("+");
Console.SetCursorPosition(cx, cy);
Console.WriteLine("+");
while (count < 10000) 
{
    int what = new Random().Next(0, 3); // выбираем любое число 0, 1, 2 для выбора рандомной вершины треугольника

    if (what == 0) 
    {
        x = (x + ax) / 2; // вычисляем координаты середины отрезка т.к. координата х = ax + (cx - ax)/2 = (2ax+cx-ax)/2=(ax+cx)/2 
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

    Console.SetCursorPosition(x, y); // задаем координаты найденной точки середины
    Console.WriteLine("+");
    count++;
}
