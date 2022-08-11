Console.Write("Введите номер четверти от 1 до 4: ");
int numb = Convert.ToInt32(Console.ReadLine());
/* if (numb == 1)
{
    Console.WriteLine("x>0; y>0");
}
else if (numb == 2) {
    Console.WriteLine("x<0; y>0");
}
else if (numb == 3) {
    Console.WriteLine("x<0; y<0");
}
else if (numb == 4) {
    Console.WriteLine("x>0; y<0");
}
else {
    Console.WriteLine("Введено неверное число");
} 


switch (numb)
{
    case 1: Console.WriteLine("x>0; y>0");
            break;
    case 2: Console.WriteLine("x<0; y>0");
            break;
    case 3: Console.WriteLine("x<0; y<0");
            break;
    case 4: Console.WriteLine("x>0; y<0");
            break;
    default: 
    Console.WriteLine("Введено неверное число");
            break;  
} */
string[] arr = {"x>0; y>0", "x<0; y>0", "x<0; y<0", "x>0; y<0"};
if (numb >= 1 && numb <=4)
{
    Console.WriteLine(arr[numb-1]);
}
else
{
    Console.WriteLine("Введено неверное число");
}