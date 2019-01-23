using System;

namespace ChallengeProblems
{
	public class PalindromeFinder
	{
		/// <param name="word">The String to check</param>
		/// <returns>true if word is a palindrome, false if not</returns>
		public bool IsPalindrome(String word)
		{
			for (int i = 0; i < word.Length / 2; i++)
			{
				char firstCharacter = word[i];
				char secondCharacter = word[word.Length - 1 - i];

				if (firstCharacter != secondCharacter)
				{
					return false;
				}

			}

			return true;
		}
	}
}