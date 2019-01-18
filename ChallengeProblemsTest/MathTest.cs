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
			Assert.Equal(11, Maths.Factorial(39916800));
		}
	}
}