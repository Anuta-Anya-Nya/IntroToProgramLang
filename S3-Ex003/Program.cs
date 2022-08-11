/* Console.WriteLine("Введите координаты точки А:");
double ax = Convert.ToInt32(Console.ReadLine());
double ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
double bx = Convert.ToInt32(Console.ReadLine());
double by = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt((ax - bx)*(ax - bx) + (ay-by)*(ay-by));
Console.WriteLine(distance); */

double[] a = new double [2];
Console.WriteLine("Введите координаты точки А:");
a[0] = Convert.ToInt32(Console.ReadLine());
a[1] = Convert.ToInt32(Console.ReadLine());
double[] b = new double [2];
Console.WriteLine("Введите координаты точки B:");
b[0] = Convert.ToInt32(Console.ReadLine());
b[1] = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt((a[0] - b[0])*(a[0] - b[0]) + (a[1]-b[1])*(a[1]-b[1])); // Math.Pow((a[0]-b[0]), 2) возведение в степень 2
Console.WriteLine(distance);
// Math.Sqrt() - корень квадратный