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
	 * This class extends ChartJs class and is used
	 * to create a bubble chart
	 * 
	 * This will be used in ChartJsBuilder class
	 * */
	public class BubbleChart : ChartJs
	{
		/*
		 * Constructor for Bubble Chart
		 * Creates a bubble chart from parent ChartJs
		 * */
		public BubbleChart() : base(ChartType.bubble)
		{
		}
	}
}
