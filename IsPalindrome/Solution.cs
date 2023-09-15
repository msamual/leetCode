using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.IsPalindrome
{
	public class Solution
	{
		public bool IsPalindrome(int x)
		{
			if (x < 0) return false;
			int r = 0, c = x;
			while (c > 0)
			{
				r = r * 10 + c % 10;
				c /= 10;
			}
			return r == x;
		}
	}
}
