using Algorithms;
using System;
using System.Diagnostics;

namespace SortingRace
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = RandomNumbers(50000);
			string[] times = new string[8];
			string[] algos = new string[]
			{
				"Selection Sort",
				"Bubble Sort",
				"Recursive Bubble Sort",
				"Insertion Sort",
				"Recursive Insertion Sort",
				"Merge Sort",
				"Interative Merge Sort",
				"Quick sort"
			};

			times[0] = SelectionSort(arr);
			times[1] = BubbleSort(arr);
			times[2] = RecursiveBubbleSort(arr);
			times[3] = InsertionSort(arr);
			times[4] = RecursiveinsertSort(arr);
			times[5] = MergeSort(arr);
			times[6] = IterativeMergeSort(arr);
			times[7] = QuickSort(arr);

			Summary(times, algos);
		}

		private static string QuickSort(int[] arr)
		{
			Console.WriteLine("Quick sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var quickSort = new QuickSort(arr);
			PrintArr(quickSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
		}

		private static string IterativeMergeSort(int[] arr)
		{
			Console.WriteLine("Iterative Merge Sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var iterativeMergeSort = new IterativeMergeSort(arr);
			PrintArr(iterativeMergeSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
		}

		private static string RecursiveinsertSort(int[] arr)
		{
			Console.WriteLine("Recursive Insortion sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var RecursiveInseSort = new RecursiveInsertionSort(arr);
			PrintArr(RecursiveInseSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
		}

		private static string InsertionSort(int[] arr)
		{
			Console.WriteLine("Insortion sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var insetionsort = new InsertionSort(arr);
			PrintArr(insetionsort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
		}

		private static string MergeSort(int[] arr)
		{
			Console.WriteLine("Merge sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var mergesort = new MergeSort(arr);
			PrintArr(mergesort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
		}

		private static string RecursiveBubbleSort(int[] arr)
		{
			Console.WriteLine("Recursive Bubble sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var recursiveBubbleSort = new RecursiveBubbleSort(arr);
			PrintArr(recursiveBubbleSort._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
		}

		private static string BubbleSort(int[] arr)
		{
			Console.WriteLine("Bubble sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var Bubble = new BubbleSort(arr);
			PrintArr(Bubble._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
		}

		private static string SelectionSort(int[] arr)
		{
			Console.WriteLine("Selection Sort");

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			var Selection = new SelectionSort(arr);
			PrintArr(Selection._solution);
			stopWatch.Stop();

			Console.WriteLine(" : " + stopWatch.Elapsed.ToString());
			Console.WriteLine("");

			return stopWatch.Elapsed.ToString();
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

		static void Summary(string[] times, string[] algos)
		{
			if(times.Length != algos.Length) return;

			for(int i = 0; i < times.Length; i++)
			{
				Console.WriteLine(algos[i] + ": " + times[i]);
			}
		}
	}
}
