using System;

namespace Algorithms
{
	public class SelectionSort : Base
	{
		public SelectionSort(int[] input) : base(input) { }
		internal override void solution()
		{
			int n = _arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				int min_idx = i;
				for (int j = i + 1; j < n; j++)
				{
					if (_arr[j] < _arr[min_idx]) min_idx = j;
				}
				int temp = _arr[min_idx];
				_arr[min_idx] = _arr[i];
				_arr[i] = temp;
			}
		}
	}
}
