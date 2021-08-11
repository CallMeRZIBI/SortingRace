using System;

namespace Algorithms
{
	public class MergeSort : Base
	{
		public MergeSort(int[] input) : base(input) { }
		internal override void solution() => sort(_arr);
		private void Merge(int[] input, int[] left, int[] right)
		{
			int i = 0;
			int j = 0;
			// dokud nevyjedeme z jednoho z poli
			while ((i < left.Length) && (j < right.Length))
			{
				// dosazeni toho mensiho prvku z obou poli a posunuti indexu
				if (left[i] < right[j])
				{
					input[i + j] = left[i];
					i++;
				}
				else
				{
					input[i + j] = right[j];
					j++;
				}
			}
			// doliti zbytku z nevyprazdneneho pole
			if (i < left.Length)
			{
				while (i < left.Length)
				{
					input[i + j] = left[i];
					i++;
				}
			}
			else
			{
				while (j < right.Length)
				{
					input[i + j] = right[j];
					j++;
				}
			}
		}
		public void sort(int[] input)
		{
			if (input.Length <= 1) //podmínka rekurze
				return;

			int center = input.Length / 2; //stred pole

			int[] left = new int[center]; //vytvoreni a naplneni leveho pole
			for (int i = 0; i < center; i++)
				left[i] = input[i];

			int[] right = new int[input.Length - center]; //vytvoreni a naplneni praveho pole
			for (int i = center; i < input.Length; i++) //vytvoreni a naplneni praveho pole
				right[i - center] = input[i];

			sort(left); // rekurzivni zavolani na obe nova pole
			sort(right);
			Merge(input, left, right); //sliti poli
		}
	}
}
