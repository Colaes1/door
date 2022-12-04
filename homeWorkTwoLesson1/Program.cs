// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Задача 13 ");
int a = 32;
string strnum = Convert.ToString(a);

if (strnum.Length > 2)
{
	Console.WriteLine(strnum[2]);
}
else
{
	Console.WriteLine("Третьей цифры нет");
}