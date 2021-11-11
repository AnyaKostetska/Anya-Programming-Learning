using System;

namespace Anya_Programming_Learning
{
	public class Cycles
	{
		public static double AtopowerB(double A, double B)
		{
			double count = 1;
				for (int i = 1; i < B; i++)
			{
				count *= A; 
			}
			return count;
		}
	}
}
