using System;
using System.Collections.Generic;

namespace ChallengeProblems
{
	public static class Maths
	{
		/// <summary>
		/// Computes the factorial of n
		/// </summary>
		/// <param name="n">A number the factorial of which is returned</param>
		/// <returns>The factorial of n</returns>
		public static uint Factorial(uint n)
		{
			uint factorial = n;
			for (; n > 1; n--)
			{
				factorial = factorial * (n - 1);
			}

			return factorial;
		}
		
		/// <param name="numbers">The integers to be averaged</param>
		/// <returns>The average of all the integers in numbers</returns>
		public static float Average(List<int> numbers)
		{
			throw new Exception("Average() doesn't do anything yet!");
		}

		/// <returns>The result of raising a to the power x. </returns>
		public static int RaiseToPower(int a, int x)
		{
			throw new Exception("RaiseToPower() doesn't do anything yet!");
		}
	}
}