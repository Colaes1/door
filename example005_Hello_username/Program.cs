Console.WriteLine("Введи имя пользователя");
string user = Console.ReadLine();
if (user.ToLower()=="маша")
{
	Console.WriteLine("О, Маша привет!");
}
else
{
	Console.Write("Привет,");
	Console.Write(user);
}