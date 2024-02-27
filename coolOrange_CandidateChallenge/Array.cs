using System;

namespace coolOrange_CandidateChallenge
{
	public class Array
	{
		//ToDo

		public static int FindMaxValue(int[] array, int position1, int position2)
		{
			if (array == null || position1 < 0 || position1 >= array.Length || position2 <= position1 || position2 > array.Length) {
				throw new ArgumentException("Invalid array or positions");
			}
			
			var maxValue = array[position1];
			for (int i=position1+1; i<position2; i++){
				if (array[i] > maxValue) {
					maxValue = array[i];
				}
			}
			return maxValue;
		}


		public static int FindMinPosition(int[] array, int position1, int position2)
		{
			if (array == null || position1 < 0 || position1 >= array.Length || position2 <= position1 || position2 > array.Length) {
				throw new ArgumentException("Invalid array or positions");
			}

			var minPosition = position1;
			var minValue = array[position1];
			for (int i=position1+1; i<position2; i++) {
				if (array[i] < minValue) {
					minValue = array[i];
					minPosition = i;
				} 
			}
			return minPosition;
		}

		public static void Swap(int[] array, int position1, int position2)
		{
			if (array == null || position1 < 0 || position1 >= array.Length || position2 <= position1 || position2 > array.Length) {
				throw new ArgumentException("Invalid array or positions");
			}

			(array[position1], array[position2]) = (array[position2], array[position1]);
		}

		public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
			if (array == null || position1 < 0 || position1 >= array.Length || position2 <= position1 || position2 > array.Length) {
				throw new ArgumentException("Invalid array or positions");
			}

			for (int i=position1; i<position2-1; i++) {
				array[i] = array[i + 1];
			}
		}


		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
			if (size <= 0) {
				throw new ArgumentException("Invalid size.");
			}	

			int[] arr = new int[size];
			Random random = new Random();
			for (int i=0; i<size; i++) {
				arr[i] = random.Next(minValue+1, maxValue);
			}
			return arr;
		}

		public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
		{
			if (rows <= 0 || columns <= 0) {
				throw new ArgumentException("Invalid rows & columns.");
			}	

			int[,] arr = new int[rows, columns];
			Random random = new Random();
			for (int i=0; i<rows; i++) {
				for (int j=0; j<columns; j++) {
					arr[i, j] = random.Next(minValue+1, maxValue);
				}
			}
			return arr;
		}

		public static int[][] CopyArray(int[] array)
		{
			if (array == null) {
				throw new ArgumentException("Invalid array.");
			}	

			int[][] arr = new int[2][];

			arr[0] = array;
			int[] copy = new int[array.Length];
			for (int i=0; i<array.Length; i++)
			{
				copy[i] = array[i];
			}
			arr[1] = copy;

			return arr;
		}

		public static int FindInSortedArray(int[] array, int number)
		{
			var beginning = 0;
			var end = array.Length - 1;

			while (beginning <= end) {
				var mid = beginning + (end - beginning) / 2;
				if (array[mid] == number) {
					return mid;
				} else if (array[mid] < number){
					beginning = mid + 1;
				} else {
					end = mid - 1;
				}
			}
			return -1;
		}

	}
}
