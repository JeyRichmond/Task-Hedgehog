# Task-Hedgehog
Hedgehog Test (C#)
This program solves the Hedgehog Test problem, where there is a population of hedgehogs in a forest, and each hedgehog can only be one of three colors: red, green, or blue. When two hedgehogs of different colors meet, they can change their color to the third color (for example, a red and blue hedgehog can both become green). Hedgehogs want to become a certain color, and they can plan their meetings to achieve this goal.

Getting Started
To run the program, you need to have Visual Studio for Mac installed on your computer. Once you have Visual Studio installed, you can open the solution file (HedgehogTest.sln) and build the solution.

Usage
The program takes in the following inputs:

A desired color, represented as an integer (0 for red, 1 for green, or 2 for blue)
An initial population of hedgehogs, represented as an array of three integers, where each integer represents the number of hedgehogs of that color (for example, [8, 1, 9] represents 8 red, 1 green, and 9 blue hedgehogs)
The program returns the minimum number of meetings needed to change all hedgehogs to the desired color, or -1 if this is impossible (for example, if all hedgehogs are initially the same color as the desired color).

Example
arduino
Copy code
int desiredColor = 1;
int[] initialPopulation = { 8, 1, 9 };
int result = HedgehogTest.Solve(desiredColor, initialPopulation);
Console.WriteLine(result); // Output: 9
In this example, the desired color is green, and there are initially 8 red, 1 green, and 9 blue hedgehogs. The minimum number of meetings needed to change all hedgehogs to green is 9.
