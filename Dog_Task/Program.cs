int count = 0;
int friend = 2;
int time = 0;
Console.Write("Введите дистанцию: ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость 1-го друга: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость 2-го друга: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());


while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");


