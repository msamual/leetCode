﻿using System;

namespace leetCode
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string input = Console.ReadLine();
				//Console.WriteLine(new leetCode.ZigZagConversion.Solution().Convert(input.Split()[0], int.Parse(input.Split()[1])));
				//Console.WriteLine(new ReverseInteger.Solution().Reverse(int.Parse(input)));
				//Console.WriteLine(new Atoi.Solution().MyAtoi(input));
				Console.WriteLine(new IsPalindrome.Solution().IsPalindrome(int.Parse(input)));
			}
		}
	}
}
