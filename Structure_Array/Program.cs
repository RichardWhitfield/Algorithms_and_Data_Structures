// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

int length = 10;
LowLevelArrayHeap? array = new(length);
for (int i = 0; i < length; i++)
{
	array[i] = i;
}
for (int i = 0; i < length; i++)
{
	Console.WriteLine(array[i]);
}
array = null;
GC.Collect();
GC.WaitForPendingFinalizers();

unsafe class LowLevelArrayHeap{
	private int* _array;
	private int _length;
	public LowLevelArrayHeap(int length)
	{
		_length = length;
		_array = (int*)Marshal.AllocHGlobal(length * sizeof(int));
	}

	public int this[int index]
	{
		get {
			if (index < 0 || index >= _length)
			{
				throw new IndexOutOfRangeException();
			}
			return _array[index];
		}
		set {
			if (index < 0 || index >= _length)
			{
				throw new IndexOutOfRangeException();
			}
			_array[index] = value;
		}
	}
	public int Length => _length;

	~LowLevelArrayHeap()
	{
		Marshal.FreeHGlobal((IntPtr)_array);
		_array = null;
	}
}