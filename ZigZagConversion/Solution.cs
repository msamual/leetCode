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
			char[] res = new char[s.Length];
			int[] rowIndexes = new int[numRows];
			int period = numRows * 2 - 2;
			rowIndexes[0] = 0;
			int waveCount = s.Length / period, tail = s.Length % period;
			for (int i = 1; i < numRows; i++)
			{
				if (i == 1)
				{
					rowIndexes[i] = waveCount;
					rowIndexes[i] += tail > 0 ? 1 : 0;
				}
				else
				{
					rowIndexes[i] = waveCount * 2 + rowIndexes[i - 1];
					if (tail > period - i + 1)
						rowIndexes[i] += 2;
					else if (tail >= i)
						rowIndexes[i]++;
				}
			}
			int curRow = 0, dir = -1;
			for (int i = 0; i < s.Length; ++i)
			{
				if (curRow == 0 || curRow == numRows - 1)
					dir *= -1;
				res[rowIndexes[curRow]++] = s[i];
				curRow += dir;
			}

			return new string(res);
		}
	}
}
