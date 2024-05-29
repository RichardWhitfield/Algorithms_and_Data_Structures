bool[] breaksArray = [false, false, false, false, true, true];
int ballCount = 2;
int result = CrystalBallSearch(breaksArray, ballCount);
Console.WriteLine($"The floor at which the ball breaks is {result}");

int CrystalBallSearch(bool[] breaksArray, int ballCount)
{
	Console.WriteLine($"Array length is {breaksArray.Length}");
	int sqrtOffset = (int)Math.Sqrt(breaksArray.Length);
	Console.WriteLine($"Sqrt offset is {sqrtOffset}");
	int searchIndex = sqrtOffset;;
	while (true)
	{
		Console.WriteLine($"Ball count is {ballCount}");
		Console.WriteLine($"Search index is {searchIndex}, value at offset is {breaksArray[searchIndex]}");
		if (breaksArray[searchIndex] == false)
		{
			searchIndex += sqrtOffset;
		}
		else
		{
			ballCount -= 1;
			Console.WriteLine($"Ball broke, {ballCount} remaining");
			searchIndex -= sqrtOffset;
			for (int i = searchIndex; i < (searchIndex + sqrtOffset) + 1; i++)
			{
				Console.WriteLine($"Searching at index {i}");
				if (breaksArray[i] == true)
				{
					ballCount -= 1;
					Console.WriteLine($"Ball broke, {ballCount} remaining");
					return i + 1;
				}
			}
		}
	}
}