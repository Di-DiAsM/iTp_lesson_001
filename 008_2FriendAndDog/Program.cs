int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int time = 0;
bool directionSecondFriend = true;
int count = 0;

while (distance > 10)
{
    if (directionSecondFriend)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        directionSecondFriend = false;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        directionSecondFriend = true;
    }
    distance -= (firstFriendSpeed + secondFriendSpeed) * time;
    Console.WriteLine(distance);
    count++;
}
Console.WriteLine(" ");
Console.WriteLine("Собака пробежит " + count);
