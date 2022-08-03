Console.Clear();
Console.Write("Ваше имя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша") 
{
    Console.WriteLine("Ура! Это Маша!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}
