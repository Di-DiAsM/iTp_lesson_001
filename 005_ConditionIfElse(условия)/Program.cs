Console.Clear();
Console.WriteLine("Введите свое имя: ");
string? userName = Console.ReadLine();
if(userName.ToLower() == "дмитрий")
{
    Console.WriteLine("Рад снова Вас видеть Дмитрий!");
}
else
{
    Console.WriteLine("привет " + userName);
}