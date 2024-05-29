int[] array = [2, 4, 6, 7, 2, 3];
BubbleSort(array);

void BubbleSort(int[] array)
{
	int searchLength = array.Length - 1;
	int tmp;
	while (searchLength > 0)
	{
		for (int i = 0; i < searchLength; i++)
		{
			if (array[i] > array[i + 1])
			{
				tmp = array[i];
				array[i] = array[i + 1];
				array[i + 1] = tmp;
			}
		}
		searchLength -= 1;
	}
	Console.WriteLine(String.Join(", ", array)); ;
}