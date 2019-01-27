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
									 "I watched C -beams glitter in the dark near the Tannhauser Gate. " +
									 "All those moments will be lost in time, like tears in rain. Time to die.";

			Dictionary<char, float> characterDistribution = calculator.ComputeCharacterDistribution(battysSoliloquy);
			
			Assert.Equal(0.050, characterDistribution['r'], 2);
			Assert.Equal(0.07, characterDistribution['a'], 2);
			Assert.Equal(0.09, characterDistribution['i'], 2);
			Assert.Equal(0.07, characterDistribution['n'], 2);
		}
	}
}