using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChallengeProblems
{
	public class CharDistributionCalculator
	{
		/// <summary>
		/// This method computes the distribution of each character in a string of text. That is, it determines,
		/// out of the total number of characters in the screen, what percentage of the total is made up of each character.
		/// For example, in the string "here", 'e' represents 0.50, or 50%, of all characters.
		///
		/// The return value is a Dictionary (i.e. a hashmap) where the keys are each character that appeared in the string,
		/// and the values are the percentage of the string made up by each character. For example, for the string "here",
		/// ComputeCharacterDistribution() would return a Dictionary with the values { {'e', 0.5}, {'h', 0.25}, {'r', 0.25} }
		///
		/// ComputeCharacterDistribution() is not case sensitive. In other words, it treats 'A' the same as 'a', and the string
		/// "Eel" would be computed as being made up of 0.67 'e' and 0.33 'l'. All characters in the Dictionary it returns will be
		/// lower case.
		/// </summary>
		/// <returns>A Dictionary (i.e. a hashmap) where the keys are each character that appeared in the string,
		/// and the values are the percentage of the string made up by each character.</returns>
		public Dictionary<char, float> ComputeCharacterDistribution(String text)
		{
			Dictionary<char, float>	characterDistribution = new Dictionary<char, float>();
			
			string cleanedText = CharDistributionCalculator.Clean(text);

			int totalCharacters = cleanedText.Length;
			
			foreach (char letter in cleanedText)
			{
				uint count = CharacterCount(letter, cleanedText);
				float percentage = (float)count / (float)totalCharacters;
				characterDistribution[letter] = percentage;
			}

			return characterDistribution;
		}

		public static string Clean(string text)
		{
			List<char> validCharacters = new List<char>(){'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
				'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
			validCharacters.Add('a');
			validCharacters.Add('b');

			StringBuilder cleanedStringBuilder = new StringBuilder();

			foreach (char letter in text)
			{
				char lowerCaseLetter = Char.ToLower(letter);
				
				if (validCharacters.Contains(lowerCaseLetter))
				{
					cleanedStringBuilder.Append(lowerCaseLetter);
				}
			}

			return cleanedStringBuilder.ToString();
		}

		public static uint CharacterCount(char characterToCount, string textToSearch)
		{
			uint count = 0;
			
			foreach (char character in textToSearch)
			{
				if (character == characterToCount)
				{
					count++;
				}
			}

			return count;
		}
	}
}