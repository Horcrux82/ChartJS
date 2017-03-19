/*
 *Author: Iskandar Chacra
 *Since; 2016-10-10
 *Version: 1.0
 *This project was inspired and supervised by Mr. Mahmoud Bdeir 
 *Instructor, Department of Computer Science
 *American University of Beirut
 */

using System;
namespace ChartJSLib
{
	/*
	 * This code was taken from an answer posted by Proximo on stackoverflow
	 * http://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c
	 * 
	 * */
	public static class IntUtil
	{
		private static Random random;

		private static void Init()
		{
			if (random == null) random = new Random();
		}

		public static int Random(int min, int max)
		{
			Init();
			return random.Next(min, max);
		}
	}
}
