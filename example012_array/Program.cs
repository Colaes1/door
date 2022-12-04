int [] array ={1,12,31,4,44,15,16,17,15};

int n=array.Length;
int find = 15;

int index=0;

while(index<n)
{
	if(array[index]==find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}
