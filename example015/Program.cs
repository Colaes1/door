int [] arr= {1,5,3,4,7,6,8,9,1,3};

void PrintArr (int[] arr)
{
	int count = arr.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{arr[i]} ");
	}
	Console.WriteLine();
}
 
void SelectionSort(int[] arr)
{
	for (int i = 0; i < arr.Length-1; i++)
	{
		int minPosition = i;

		for (int j = i+1; j < arr.Length; j++)
		{
			if(arr[j]<arr[minPosition]) minPosition=j;
		}

		int temprary = arr[i];
		arr[i]= arr[minPosition];
		arr[minPosition]= temprary;


	}
}


PrintArr(arr);
SelectionSort(arr);
PrintArr(arr);