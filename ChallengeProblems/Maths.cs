using System;

namespace ChallengeProblems
{
	public static class Maths
	{
		/// <summary>
		/// Computes the factorial of n
		/// </summary>
		/// <param name="n">A number the factorial of which is returned</param>
		/// <returns>The factorial of n</returns>
		public static int Factorial(int n)
		{
			if (n == 0)
			{
				return 0;
			}
			else if (n == 1)
			{
				return 1;
			}
			else
			{
				return n * (Factorial(n - 1));
			}
		}
	}
}