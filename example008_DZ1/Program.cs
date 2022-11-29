int a = 1;
int b = 5;

int max = a;
int min =b;
if (a>b) max = a; 
if (a>b) min = b;
if (b>a) max = b; 
if (b>a) min = a; 

Console.Write("Максимальное число ");
Console.WriteLine(max);
Console.Write("Минимальное число ");
Console.WriteLine(min);
