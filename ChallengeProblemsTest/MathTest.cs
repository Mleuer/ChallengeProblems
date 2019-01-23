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
	}
}