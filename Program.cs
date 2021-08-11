using Algorithms;
using System;
using System.Diagnostics;

namespace SortingRace
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = RandomNumbers(10);

			SelectionSort(arr);
			BubbleSort(arr);
			RecursiveBubbleSort(arr);
			InsertionSort(arr);
			RecursiveinsertSort(arr);
			MergeSort(arr);
			IterativeMergeSort(arr);
			QuickSort(arr);
		}

		private static void QuickSort(int[] arr)
		{
			Console.WriteLine("Quick sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var quickSort = new QuickSort(arr);
			PrintArr(quickSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
		}

		private static void IterativeMergeSort(int[] arr)
		{
			Console.WriteLine("Iterative Merge Sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var iterativeMergeSort = new IterativeMergeSort(arr);
			PrintArr(iterativeMergeSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
		}

		private static void RecursiveinsertSort(int[] arr)
		{
			Console.WriteLine("Recursive Insortion sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var RecursiveInseSort = new RecursiveInsertionSort(arr);
			PrintArr(RecursiveInseSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
		}

		private static void InsertionSort(int[] arr)
		{
			Console.WriteLine("Insortion sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var insetionsort = new InsertionSort(arr);
			PrintArr(insetionsort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
		}

		private static void MergeSort(int[] arr)
		{
			Console.WriteLine("Merge sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var mergesort = new MergeSort(arr);
			PrintArr(mergesort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
		}

		private static void RecursiveBubbleSort(int[] arr)
		{
			Console.WriteLine("Recursive Bubble sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var recursiveBubbleSort = new RecursiveBubbleSort(arr);
			PrintArr(recursiveBubbleSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
		}

		private static void BubbleSort(int[] arr)
		{
			Console.WriteLine("Bubble sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var Bubble = new BubbleSort(arr);
			PrintArr(Bubble._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
		}

		private static void SelectionSort(int[] arr)
		{
			Console.WriteLine("Selection Sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var Selection = new SelectionSort(arr);
			PrintArr(Selection._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");
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
			Console.WriteLine("");
			Console.WriteLine("");
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
		}
	}
}
