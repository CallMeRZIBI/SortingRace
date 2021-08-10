namespace SortingRace.Algorithms
{
	public abstract class Base
	{
		public int[] _solution { get; set; }
		internal int[] _arr { get; set; }
		public Base(int[] input)
		{
			_arr = (int[]) input.Clone();
			solution();
			_solution = _arr;
		}
		internal abstract void solution();
	}
}
