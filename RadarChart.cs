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
	 *This class extends the class ChartJS and
	 *is used to create a Radar Chart
	 *
	 *This will be used in the ChartJsBuilder class 
	 * */
	public class RadarChart : ChartJs
	{
		/*
		 * Constructor for Radar Chart
		 * Creates a radar chart from parent ChartJs 
		 * */
		public RadarChart() : base(ChartType.radar) { }
	}
}
