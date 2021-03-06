using System;

namespace Algorithms
{
    public class IterativeMergeSort : Base
    {
        public IterativeMergeSort(int[] input) : base(input) {}
        internal override void solution() => sort(_arr, 0, _arr.Length - 1);

        // Iterative mergesort function to sort arr[0...n-1]
        public void sort(int[] arr, int l, int r)
        {
			if (l < r)
			{

				// Same as (l+r)/2 but avoids  
				// overflow for large l & h 
				int m = l + (r - l) / 2;
				sort(arr, l, m);
				sort(arr, m + 1, r);
				merge(arr, l, m, r);
			}
		}

        // Function to merge the two haves arr[1..m] and arr[m+1..r] of array arr[]
        private void merge(int[] arr, int l, int m, int r)
        {
			int i, j, k;
			int n1 = m - l + 1;
			int n2 = r - m;

			/* create temp arrays */
			int[] L = new int[n1];
			int[] R = new int[n2];

			/* Copy data to temp arrays 
			L[] and R[] */
			for (i = 0; i < n1; i++)
				L[i] = arr[l + i];
			for (j = 0; j < n2; j++)
				R[j] = arr[m + 1 + j];

			/* Merge the temp arrays back  
			into arr[l..r]*/
			i = 0;
			j = 0;
			k = l;
			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					arr[k] = L[i];
					i++;
				}
				else
				{
					arr[k] = R[j];
					j++;
				}
				k++;
			}

			/* Copy the remaining elements of 
			L[], if there are any */
			while (i < n1)
			{
				arr[k] = L[i];
				i++;
				k++;
			}

			/* Copy the remaining elements of 
			R[], if there are any */
			while (j < n2)
			{
				arr[k] = R[j];
				j++;
				k++;
			}
		}
    }
}
