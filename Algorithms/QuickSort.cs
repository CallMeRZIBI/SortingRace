using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class QuickSort : Base
	{
		public QuickSort(int[] input) : base(input) { }
		internal override void solution() => solve(_arr, 0, _arr.Length - 1);

		public void solve(int[] arr, int low, int high)
		{
			if(low < high)
			{
				// pi is partitioning index, arr[p] is now at right place
				int pi = partition(arr, low, high);

				// Separately sort elements before partition and after partition
				solve(arr, low, pi - 1);
				solve(arr, pi + 1, high);
			}
		}

		// This function takes las element as pivot, places this pivot element at its correct position in sorted array, and places all smaller (smallet than pivot) to left of pivot
		// and all greater elements to right of pivot
		private int partition(int[] arr, int low, int high)
		{
			// pivot
			int pivot = arr[high];

			// Index of smaller element and indicates the right position of pivot found so far
			int i = (low - 1);

			for (int j = low; j <= high - 1; j++)
			{
				// If current element is smaller than the pivot
				if(arr[j] < pivot)
				{
					// Increment index of smaller element
					i++;
					swap(arr, i, j);
				}
			}

			swap(arr, i + 1, high);
			return (i + 1);
		}

		private void swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	}
}
