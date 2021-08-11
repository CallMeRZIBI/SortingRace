using System;

namespace Algorithms
{
	class RecursiveBubbleSort : Base
	{
		private int n;
		public RecursiveBubbleSort(int[] input) : base(input) { }

		internal override void solution()
		{
			n = _arr.Length;
			solution(_arr, n);
		}
		internal void solution(int[] arr, int n)
		{
			if (n == 1) return;
			for (int i = 0; i < n - 1; i++)
			{
				if (_arr[i] > _arr[i + 1])
				{
					int temp = _arr[i];
					_arr[i] = _arr[i + 1];
					_arr[i + 1] = temp;
				}
			}
			solution(_arr, n - 1);
		}
	}
}
