double distance = 10;
int speedFriend1 = 2;
int speedFriend2 = 4;
int speedDog = 5;
int friend = 2;
int count = 0;

while ( distance > 1)
{
    double time = 0;
    if (friend == 1) 
    {
        time = distance / (speedFriend1 + speedDog);
        friend = 2;
    }
    else 
    {
        time = distance / (speedFriend2 + speedDog);
        friend = 1;
    }
    distance = distance - (speedFriend1 + speedFriend2) / time;
    count++;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз!");
