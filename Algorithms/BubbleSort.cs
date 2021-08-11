using System;

namespace Algorithms
{
	public class BubbleSort : Base
	{
		public BubbleSort(int[] input) : base(input) { }
		internal override void solution()
		{
			for (int i = 0; i < _arr.Length - 1; i++)
			{
				for (int j = 0; j < _arr.Length - i - 1; j++)
				{
					if (_arr[j + 1] < _arr[j])
					{
						int tmp = _arr[j + 1];
						_arr[j + 1] = _arr[j];
						_arr[j] = tmp;
					}
				}
			}
		}

	}
}
