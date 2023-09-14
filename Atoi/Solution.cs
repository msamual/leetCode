using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.Atoi
{
	public class Solution
	{
		public int MyAtoi(string s)
		{
			bool neg = false;
			int res = 0;
			short i = 0;

			while (i < s.Length && (s[i] == ' ' || (s[i] > 8 && s[i] < 14)))
				++i;
			if (i < s.Length && (s[i] == '-'))
				neg = true;
			if (i < s.Length && (s[i] == '-' || s[i] == '+'))
				i++;
			while (i < s.Length && (s[i] > 47 && s[i] < 58))
			{
				res = res * 10 + (s[i] - 48);
				if (res < 0)
					return neg ? -2147483648 : 2147483647;
				i++;
			}
			if (neg)
				return -res;
			return res;
		}
	}
}
