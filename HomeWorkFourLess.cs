//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int a = 2;
int b = 4;
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine(step);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int a = 452;
int sum = 0;

while (a > 0)
{
int num = a % 10;
a = a / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
int [] num ={1, 2, 5, 7, 19};
void PrintArr (int[] num)
{
	int count = num.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{num[i]} ");
	}
	Console.WriteLine();
}
PrintArr(num);
