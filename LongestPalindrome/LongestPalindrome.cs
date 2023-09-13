using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
	public partial class Solution
	{
		public string LongestPalindrome(string s)
		{
			int startPos = 0, len = 0;
			for (int i = 0; i < s.Length; i++)
			{
				for (int j = 0; j <= i && j + i < s.Length && s[i - j] == s[i + j]; ++j)
				{
					if (len < j * 2 + 1)
					{
						startPos = i - j;
						len = j * 2 + 1;
					}
				}
				for (int j = 0; j <= i && j + i < s.Length - 1 && s[i - j] == s[i + j + 1]; ++j)
				{
					if (len < (j + 1) * 2)
					{
						startPos = i - j;
						len = (j + 1) * 2;
					}
				}
			}
			return s.Substring(startPos, len);
		}
	}
}
