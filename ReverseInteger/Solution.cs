using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.ReverseInteger
{
	public class Solution
	{
		public int Reverse(int x)
		{
			int res = 0;
			int tail;

			while (x != 0)
			{
				tail = x % 10;
				if (res != ((res = res * 10 + tail) - tail) / 10)
					return 0;
				x /= 10;
			}

			return res;
		}
	}
}
