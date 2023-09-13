using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.ZigZagConversion
{
	public class Solution
	{
		public string Convert(string s, int numRows)
		{
			if (numRows == 1 || s.Length <= numRows)
				return s;
			StringBuilder res = new StringBuilder(s.Length);
			int period = numRows * 2 - 2;
			for (short row = 0; row < numRows; ++row)
			{
				int inc = 2 * row;

				for (int i = row; i < s.Length; i += inc)
				{
					res.Append(s[i]);
					if (inc != period)
						inc = period - inc;
				}
			}
			return res.ToString();
		}
	}
}
