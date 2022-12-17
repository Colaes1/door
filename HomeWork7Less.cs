Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,]matrix = new double [3,4];

void PrintArray(double [,] matrix)
{
	for (int i =0; i < matrix.GetLength(0);i++)
	{
		for (int j =0; j <matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]} ");
		}
	Console.WriteLine();
	}
}

void FillArray (double [,] matrix)
{
	{
	for (int i =0; i < matrix.GetLength(0);i++)
	
		for (int j =0; j <matrix.GetLength(1); j++)
		{
			matrix[i,j]=Convert.ToDouble(new Random().Next(1,10))/10;
		}
	
	
}
}

FillArray(matrix);
PrintArray(matrix);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [4,4];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] numbers = new int[3, 3];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double average = 0;
	
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        average = (average + numbers[i, j]);
    }
    average = average / 3;
	
    Console.Write(average - average%0.01 + ";     ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
