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
 	 *is used to create a line chart
  	 *
 	 *This will be used in the ChartJsBuilder class 
 	 */	
	public class LineChart : ChartJs
	{
		/*
 		 *Constructor of Line Chart
 		 *Creates Line Chart from parent ChartJs
 		 */
		public LineChart(): base(ChartType.line) { }
	}
}
