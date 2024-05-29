int[] array = [1, 2, 3, 4, 5];
var target = 4;
var result = BinarySearch(array, target);
Console.WriteLine(result);

int BinarySearch(int[] array, int target)
{
	int start = 0;
	int end = array.Length;
	int mid;
	while (true)
	{
		Console.WriteLine($"Searching between {start} and {end}");
		mid = start + (end - start) / 2;
		Console.WriteLine($"Mid index is {mid}, value is {array[mid]}");
		Console.WriteLine($"Target value is {target}");
		if (mid == target)
		{
			return mid;
		}
		else if (mid < target)
		{
			start = mid + 1;
		}
		else end = mid - 1;
	}
}
