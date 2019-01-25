using ChallengeProblems;
using Xunit;

namespace ChallengeProblemsTest
{
	public class MathTest
	{
		[Fact]
		public void FactorialShouldComputeFactorialOfN()
		{
			Assert.Equal(24, Maths.Factorial(4));
			Assert.Equal(720, Maths.Factorial(6));
			Assert.Equal(362880, Maths.Factorial(9));
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