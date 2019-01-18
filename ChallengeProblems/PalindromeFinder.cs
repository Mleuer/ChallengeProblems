using System;

namespace ChallengeProblems
{
	public class PalindromeFinder
	{
		/// <param name="word">The String to check</param>
		/// <returns>true if word is a palindrome, false if not</returns>
		public bool IsPalindrome(String word)
		{
			if (word.Length == 0)
			{
				return false;
			}
			if (word.Length == 1)
			{
				return true;
			}
			else if (word.Length == 2)
			{
				return word[0] == word[1];
			}
			else
			{
				if (word[0] == word[word.Length - 1])
				{
					int newLength = word.Length - 2;
					string trimmedWord = word.Substring(1, newLength);
					return IsPalindrome(trimmedWord);
				}
				else
				{
					return false;
				}
			}
			
		}
	}
}