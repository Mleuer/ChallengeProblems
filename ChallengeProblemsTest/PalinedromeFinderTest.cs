using ChallengeProblems;
using Xunit;

namespace ChallengeProblemsTest
{
	public class PalinedromeFinderTest
	{
		[Fact]
		public void PalindromeFinderShouldFindPalindromes()
		{
			PalindromeFinder palindromeFinder = new PalindromeFinder();

			Assert.True(palindromeFinder.IsPalindrome("racecar"));
			Assert.False(palindromeFinder.IsPalindrome("doofus"));
			Assert.True(palindromeFinder.IsPalindrome("murdrum"));
			Assert.False(palindromeFinder.IsPalindrome("airplane"));
		}
	}
}