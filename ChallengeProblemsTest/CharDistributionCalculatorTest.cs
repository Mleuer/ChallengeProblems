using System;
using System.Collections.Generic;
using ChallengeProblems;
using Xunit;

namespace ChallengeProblemsTest
{
	public class CharDistributionCalculatorTest
	{
		[Fact]
		public void CharDistributionCalculatorShouldComputeCharacterDistribution()
		{
			CharDistributionCalculator calculator = new CharDistributionCalculator();

			String battysSoliloquy = "I've seen things you people wouldn't believe. " +
									 "Attack ships on fire off the shoulder of Orion. " +
									 "I watched C -beams glitter in the dark near the Tannhäuser Gate. " +
									 "All those moments will be lost in time, like tears in rain. Time to die.";

			IDictionary<char, float> characterDistribution = calculator.ComputeCharacterDistribution(battysSoliloquy);
			
			Assert.Equal(0.050, characterDistribution['r'], 2);
			Assert.Equal(0.061, characterDistribution['a'], 2);
			Assert.Equal(0.09497, characterDistribution['i'], 3);
			Assert.Equal(0.0726, characterDistribution['n'], 3);
		}
	}
}