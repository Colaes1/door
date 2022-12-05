//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Задача 10 ");
int a = 321;
string strnum = Convert.ToString(a);
Console.WriteLine("вторая цифра этого числа - "+strnum[1]);

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

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int a=7;

void check (int a)
{
	if (a==6||a==7) 
	{
		Console.WriteLine("Этот день выходной");
	}
	else if (a<1 || a >7)
	{
		Console.WriteLine("Это не день недели");
	}
	else
	{
		Console.WriteLine("Это не выходной день");
	}
}

check(a);
