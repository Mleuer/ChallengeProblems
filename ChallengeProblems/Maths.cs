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
		public static uint Factorial(uint n)
		{
//			int factorial = g;
//			for (; g > 1; g--)
//			{
//				factorial = factorial * (g - 1);
//			}
//
//			return factorial;
			uint factorial = 0;
			
			if (n == 0)
			{
				factorial = 1;
				return factorial;
			}
			else if (n == 1)
			{
				factorial = 1;
                return factorial;
			}
			else
			{
				return n * Factorial(n - 1);
			}

		}
	}
}