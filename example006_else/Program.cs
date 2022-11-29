int a= 1;
int b= 4;
int c= 10;
int d= 7;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.WriteLine("max = ");
Console.WriteLine(max);