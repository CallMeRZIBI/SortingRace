using System;

namespace Algorithms
{
	class InsertionSort : Base
	{
		public InsertionSort(int[] input) : base(input) { }
		internal override void solution()
		{
			int n = _arr.Length;
			for (int i = 1; i < n; ++i)
			{
				int key = _arr[i];
				int j = i - 1;
				while (j >= 0 && _arr[j] > key)
				{
					_arr[j + 1] = _arr[j];
					j = j - 1;
				}
				_arr[j + 1] = key;
			}
			_solution = _arr;
		}
	}
}
