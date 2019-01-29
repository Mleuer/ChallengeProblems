using System.Collections.Generic;
using ChallengeProblems;
using Xunit;

namespace ChallengeProblemsTest
{
	public class MathTest
	{
		[Fact]
		public void FactorialShouldComputeFactorialOfN()
		{
			Assert.Equal(24u, Maths.Factorial(4));
			Assert.Equal(720u, Maths.Factorial(6));
			Assert.Equal(362880u, Maths.Factorial(9));
		}
		
		[Fact]
		public void AverageShouldComputeAverageOfGivenNumbers()
		{
			Assert.Equal(2.0, Maths.Average(new List<int>{1, 2, 3}));
			Assert.Equal(121208.0, Maths.Average(new List<int>{24, 720, 362880}));
			Assert.Equal(4.667, Maths.Average(new List<int>{2, 3, 9}),3);
		}
		
		[Fact]
		public void RaiseToPowerShouldRaiseNToPower()
		{
			Assert.Equal(25, Maths.RaiseToPower(5, 2));
			Assert.Equal(27, Maths.RaiseToPower(3, 3));
			Assert.Equal(387420489, Maths.RaiseToPower(9, 9));
		}
	}
}