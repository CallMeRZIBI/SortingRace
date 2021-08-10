using Algorithms;
using System;

namespace SortingRace
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = RandomNumbers(5);

			SelectionSort(arr);
			BubbleSort(arr);
			RecursiveBubbleSort(arr);
			InsertionSort(arr);
			RecursiveinsertSort(arr);
			MergeSort(arr);
			IterativeMergeSort(arr);
		}

		private static void IterativeMergeSort(int[] arr)
		{
			Console.WriteLine("Iterative Merge Sort");
			var iterativeMergeSort = new IterativeMergeSort(arr);
			PrintArr(iterativeMergeSort._solution);
		}

		private static void RecursiveinsertSort(int[] arr)
		{
			var RecursiveInseSort = new RecursiveInsertionSort(arr);
			Console.WriteLine("Recursive Insortion sort");
			PrintArr(RecursiveInseSort._solution);
		}

		private static void InsertionSort(int[] arr)
		{
			Console.WriteLine("Insortion sort");
			var insetionsort = new InsertionSort(arr);
			PrintArr(insetionsort._solution);
		}

		private static void MergeSort(int[] arr)
		{
			Console.WriteLine("Merge sort");
			var mergesort = new MergeSort(arr);
			PrintArr(mergesort._solution);
		}

		private static void RecursiveBubbleSort(int[] arr)
		{
			var recursiveBubbleSort = new RecursiveBubbleSort(arr);
			recursiveBubbleSort.solution();
			Console.WriteLine("Recursive Bubble sort");
			PrintArr(recursiveBubbleSort._solution);
		}

		private static void BubbleSort(int[] arr)
		{
			Console.WriteLine("Bubble sort");
			var Bubble = new BubbleSort(arr);
			PrintArr(Bubble._solution);
		}

		private static void SelectionSort(int[] arr)
		{
			Console.WriteLine("Selection Sort");
			var Selection = new SelectionSort(arr);
			PrintArr(Selection._solution);
		}

		private static int[] RandomNumbers(int HowMany)
		{
			int[] arr = new int[HowMany];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new Random().Next(0, arr.Length * 10);
			}
			Console.WriteLine("unsorted");
			PrintArr(arr);
			return arr;
		}

		static void PrintArr(int[] arr)
		{
			Console.Write("[");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + ", ");
			}
			Console.Write("]");
			Console.WriteLine("");
			Console.WriteLine("");
		}
	}
}
