//for (int i=2; i<=10; i++)
//{
//	for (int j=2; j<=10; j++)
//	{
//		Console.WriteLine($"{i}x{j}={i*j}");
//	}
//	Console.WriteLine();
//}

string text ="– Я думаю, – сказал князь, улыбаясь, – что, "
	+ "ежели бы вас послали вместо нашего милого Винценгероде, "
	+ "вы бы взяли приступом согласие прусского короля. "
	+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldVal, char newVal)
{
	string result = String.Empty;

	int length = text.Length;
	for (int i=0; i< length; i++)
	{
		if(text[i]==oldVal) result= result+$"{newVal}";
		else result= result+$"{text[i]}";
	}

	return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText,'к','К');
Console.WriteLine(newText);
