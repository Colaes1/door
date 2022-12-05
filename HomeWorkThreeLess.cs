//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int a = 12821;
string strnum = Convert.ToString(a);
if (strnum[0]==strnum[4] || strnum[1]==strnum[3])
	{
		Console.WriteLine("да");
	}
	else
	{
		Console.WriteLine("нет");
	}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = 3;
int y1 = 6;
int z1 = 8;
int x2 = 2;
int y2 = 1;
int z2 = -7;
double coord(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
				{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
        }
double segLength =  Math.Round (coord(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine(segLength);


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int cube = 2;

void Cube(int[] cube)
{
  int coun = 1;
  int length = cube.Length;
  while (coun <  length){
    cube[coun] = Convert.ToInt32(Math.Pow(coun, 3));
    coun++;
  }
}

void PrintArry(int[] look)
{
  int count = look.Length;
  int index = 1;
  while(index < count){
    Console.Write(look
[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
