using System;

namespace leetCode
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string input = Console.ReadLine();
				Console.WriteLine(new Solution().LongestPalindrome(input));
			}
		}
	}
}
