int[] array = [1,2,3,4,5];
var target = 4;
var result = LinearSearch(array, target);
Console.WriteLine(result);

int LinearSearch(int[] array, int target)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine($"Searching at index {i}");
		Console.WriteLine($"Current value is {array[i]}");
		Console.WriteLine($"Target value is {target}");
		
		if (array[i] == target)
		{
			return i;
		}
	}
	return -1;
}
