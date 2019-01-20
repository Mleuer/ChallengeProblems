# Challenge Problems
A selection of code challenges for a new programmer

## The Objective

This project was created to give you - a new programmer - the chance to test your mettle. It contains a few coding exercises designed to teach you about important concepts in computer science (like string manipulation and recursion) while also helping to develop your problem-solving skills.

In order to complete this challenge you will need to write the necessary code to make all of the project's tests pass.

## Prerequisites

* [Homebrew](https://brew.sh/)
* .NET Core
  * It can be installed from the Microsoft .NET SDK [download page](https://dotnet.microsoft.com/download), or by running:
  > `brew install dotnet-sdk`
* [JetBrains Rider](https://www.jetbrains.com/rider/)
* This project somewhere in your file system (e.g. `~/Developer/ChallengeProblems`)

## Setup

* Open this project in Rider.
* In the solution view on the left-hand side, right-click `ChallengeProblemsTests`, then click "Run All Tests".
* If this is your first time running the tests, you should see a set of tests failures near the bottom of the window, accompanied by exception messages complaining that the methods being called are incomplete.
* To fix this, and complete this project, you'll need to implement each of the methods being tested. For example, to make the test `CharDistributionCalculatorShouldComputeCharacterDistribution()` pass, fix the `CharDistributionCalculator.ComputeCharacterDistribution()` method.
* Each of the unfinished methods has a documentation comment explaining exactly what the method does (or rather, should do). It's your job to complete the method such that it does exactly what it claims to do.
  > **Tip**: Position your cursor inside the name of the method and press `F1` (or on some systems, `CTRL` + `Q`) to see a cleanly formatted view of its documentation.
* Once you think you've fixed a method, run its tests again. You'll know you've successfully completed the challenge when all tests in the project are green (passing).

## Hints
* When you first run the code, you'll notice that all the methods do is throw exceptions. Start out by removing the exception statements.
* You may find [this Microsoft developer guide for strings](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/index) handy, especially the **Accessing Individual Characters** and **Substrings** sections.
* You can always create more methods to help the existing ones do their job. For example, `ComputeCharacterDistribution()` could probably benefit from something that could clean up the strings it's processing, to remove all the unimportant noise and whitespace. Something to compute the total occurrences of each character might help too... 
